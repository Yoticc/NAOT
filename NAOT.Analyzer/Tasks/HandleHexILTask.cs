using dnlib.DotNet.Emit;
using NAOT.Analyzer.Utils.Dn;
using NAOT.Analyzer.Utils.Sugar;
using NAOT.Core.Tasks;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace NAOT.Analyzer.Tasks;
public class HandleHexILTask : ILActualTask
{
    public override void Execute(ModuleDefMD module)
    {
        (string name, Handler target)[] handlers = [
            ("EmptyArray", EmptyArrayHandler),
            ("LocalArray", LocalArrayHandler),
            ("Array", ArrayHandler)
        ];

        var sam = new StaticArraysManager(module);

        var naotDefinesMethods = AGlobals.NAOTDefinesType.Methods.ToList();

        var hexMethod = naotDefinesMethods.Find(m => m.Name == "hex")!;
        var hexMethodFullName = hexMethod.FullName;

        foreach (var type in module.GetTypes())
            foreach (var method in type.Methods)
                HandleMethod(method);

        void HandleMethod(MethodDef method)
        {
            if (!method.HasBody)
                return;

            var body = method.Body;
            if (!body.HasInstructions)
                return;

            var counter = 0;
            var insts = body.Instructions;
            for (int i = 0; i < insts.Count; i++)
            {
                var inst = insts[i];
                var opcode = inst.OpCode;
                var code = opcode.Code;

                if (code != Code.Call)
                    continue;

                var operand = inst.Operand;
                var callMethod = operand as IMethodDefOrRef;
                if (callMethod == null)
                    continue;

                var callMethodFullName = callMethod.FullName;

                if (hexMethodFullName != callMethodFullName)
                    continue;

                foreach (var (name, target) in handlers)
                {
                    try
                    {
                        if (target(module, sam, insts, i))
                            goto NEXT;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Exception in HandleHexILTask->handler->{name}: {ex}");
                    }
                }

                Console.WriteLine($"HandleHexILTask: Unable convert hex-type method in method \'{method.FullName}\'[{counter}]");

                NEXT:
                counter++;
            }
        }
    }

    #region Handlers
    delegate bool Handler(ModuleDefMD module, StaticArraysManager sam, IList<Instruction> insts, int index);

    Handler EmptyArrayHandler = (module, sam, insts, i) =>
    {
        var prevInstIndex = i - 1;
        var prevInst = insts[i - 1];
        var prevInstCode = prevInst.OpCode.Code;
        /*
         *  [i-1]  call  System.Array::Empty<?>()
         *  [i]    call  uint8[] NaotDefines::hex(object[]) 
        */
        if (prevInstCode == Code.Call)
        {
            var callMethod = prevInst.GetOperandMethod()!;
            if (callMethod.FullName.Contains("System.Array::Empty"))
            {
                insts[i - 1] = new(OpCodes.Ldc_I4_0);
                insts[i] = new(OpCodes.Newarr, new TypeSpecUser(module.CorLibTypes.Byte));
                /*
                 *  [i-1]  ldc.i4.0
                 *  [i]    newarr   uint8
                */
                return true;
            }
        }
        /*
         *  [i-2]  ldc.i4.0
         *  [i-1]  newarr    ?
         *  [i]    call      uint8[] NaotDefines::hex(object[]) 
        */
        else if (prevInstCode == Code.Newarr)
        {
            if (insts[i - 2].OpCode.Code == Code.Ldc_I4_0)
            {
                insts[i] = new(OpCodes.Newarr, new TypeSpecUser(module.CorLibTypes.Byte));
                insts.RemoveAt(i - 1);
                /*
                 *  [i-2]  ldc.i4.0
                 *  [i]    newarr    uint8
                */
                return true;
            }    
        }
        return false;
    };

    Handler LocalArrayHandler = (module, sam, insts, i) =>
    {
        var prevInstIndex = i - 1;
        var prevInst = insts[i - 1];
        var prevInstCode = prevInst.OpCode.Code;

        /*
         * [p-1]  ldc.i4?
         * [p]    newarr
         * ...
         * [o]    stloc
         * ...
         * [i-1]  ldloc?
         * [i]    uint8[] NaotDefines::hex(object[])
        */
        if (prevInst.IsLdloc())
        {
            int value = prevInst.GetLdlocValue();

            for (int o = i - 1; o > 0; o--)
            {
                if (insts[o].IsStloc())
                {
                    if (insts[o].GetStlocValue() == value)
                    {
                        var innerIsnts = insts.ToList().GetRange(0, o);
                        var bytes = CompileToByteArray(innerIsnts);
                        return true;
                    }
                }
            }
        }

        return false;
    };

    Handler ArrayHandler = (module, sam, insts, i) =>
    {
        var prevInstIndex = i - 1;
        var prevInst = insts[i - 1];
        var prevInstCode = prevInst.OpCode.Code;
        /*
         *  [i-1]  stelem.ref
         *  [i]    call  uint8[] NaotDefines::hex(object[]) 
        */
        if (prevInstCode == Code.Stelem_Ref)
        {
            var bytes = CompileToByteArray(insts.ToList().GetRange(0, i));

            Console.WriteLine($"{string.Join(' ', bytes.Select(b => $"{b:X2}"))}");
            return true;
        }
        return false;
    };
    #endregion

    static List<byte>? ParseString(string input)
    {
        try
        {
            input = input.Replace("0x", "").Replace(",", " ").TrimStart().TrimEnd().Trim();

            var result = new List<byte>();

            var splitted = input.Split(' ');
            foreach (var part in splitted)
            {
                if (part.StartsWith("_"))
                    result.AddRange(BigInteger.Parse(part.Substring(1, part.Length-1)).ToByteArray().Reverse());
                else result.AddRange(BigInteger.Parse(part, NumberStyles.HexNumber).ToByteArray().Reverse());
            }

            return result;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"HandleHexILTask->CompileToByteArray->ParseString: {ex}");
            return null;
        }
    }

    static byte[] ParseInteger(object integer, TypeKind kind) => integer.UnboxInArray(1 << (int)kind);

    static TypeKind? ParseKind(string name)
    {
        if (TypeNameToTypeKind.ContainsKey(name))
            return TypeNameToTypeKind[name];

        return null;
    }

    static List<byte>? CompileToByteArray(List<Instruction> instructions)
    {
        var result = new List<byte>();

        var arrayInstsNullable = GetArrayInstructions(instructions);
        if (arrayInstsNullable == null)
            return null;

        var arrayInsts = arrayInstsNullable.Value;

        foreach (var insts in arrayInsts.instructions)
        {
            int count = insts.Count;
            if (count == 0)
                Console.WriteLine($"HandleHexILTask->CompileToByteArray: Input 0 Instructions to parse.");
            else
            {
                var inst = insts[0];
                var instOpcode = inst.OpCode;
                var instCode = instOpcode.Code;
                var instOperand = inst.Operand;

                if (count == 1)
                {
                    if (instCode == Code.Ldstr)
                    {
                        var parsed = ParseString((string)instOperand);
                        result.AddRange(parsed);
                    }
                    else PrintError();
                }
                else if (count == 2)
                {
                    var nextInst = insts[1];
                    var nextInstOpcode = nextInst.OpCode;
                    var nextInstCode = nextInstOpcode.Code;
                    var nextInstOperand = nextInst.Operand;

                    if (instCode.ToString().StartsWith("Ldc"))
                    {
                        if (nextInstCode == Code.Box)
                        {
                            var typeName = ((TypeRef)nextInstOperand).FullName;
                            var boxType = ParseKind(typeName);
                            if (boxType != null)
                            {
                                var parsed = ParseInteger(inst.Operand, (TypeKind)boxType);
                                result.AddRange(parsed);
                            }
                            else Console.WriteLine($"HandleHexILTask->CompileToByteArray: Unable parse TypeKind for type \'{typeName}\'");
                        }
                        else PrintError();
                    }
                }
                else PrintError();
            }            

            void PrintError() => Console.WriteLine($"HandleHexILTask->CompileToByteArray: Unable parse instructions: [{string.Join(", ", insts.Select(i => $"{i.OpCode.Code} {i.Operand}"))}]");
        }

        Console.WriteLine($"\n\n\nFound method isntst:\n{string.Join('\n', arrayInsts.instructions.Select((e, i) => $"\t[{i}]:\n{string.Join('\n', e.Select(z => $"\t\t{z.OpCode.Code}\t{(z.Operand != null ? ($"{z.Operand}\t{z.Operand.GetType()}") : "null")}"))}"))}");

        return result;
    }

    #region Get Instructions
    static (List<List<Instruction>> instructions, int totalLength)? GetArrayInstructions(List<Instruction> insts)
    {
        var instructions = new List<List<Instruction>>();
        var foundElements = 0;
        var predicateElements = 0;
        var isLastStelem = false;
        List<Instruction>? currentNode = null;

        for (int i = insts.Count - 1; i >= 0; i--)
        {
            var inst = insts[i];
            var opcode = inst.OpCode;
            var code = opcode.Code;

            if (code == Code.Stelem_Ref)
            {
                foundElements++;

                if (!isLastStelem)
                    AddToResult();

                isLastStelem = true;
            }
            else if (code == Code.Newarr)
            {
                isLastStelem = false;

                i--;
                var arrayLength = insts[i].GetLdcI4Value();
                predicateElements += arrayLength;

                if (currentNode != null && currentNode.Count != 0)
                    AddToResult();

                if (predicateElements == foundElements)
                    return (instructions, insts.Count - i);
            }
            else
            {
                isLastStelem = false;

                if (inst.IsLdcI4() && i > 0 && insts[i - 1].OpCode.Code == Code.Dup)
                    i--;
                else if (inst.OpCode.Code.ToString().StartsWith("Conv")) { }
                else AddToCurrentNode(inst);
            }
        }

        Console.WriteLine($"HandleHexILTask->GetArrayInstructions: Unable parse il code. Vars: foundElements: {foundElements}, predicateElements: {predicateElements} Code:\n{string.Join('\n', insts.Select(i => $"{i.OpCode.Code} {i.Operand}"))}");
        return null;

        void AddToResult()
        {
            if (currentNode != null)
                if (currentNode.Count > 0)
                    instructions?.Insert(0, currentNode);
            currentNode = new();
        }
        void AddToCurrentNode(Instruction inst) => currentNode?.Insert(0, inst);
    }
    #endregion

    enum TypeKind
    {
        B1,
        B2,
        B4,
        B8
    }

    static List<(TypeKind kind, Type[] types)> TypeKindToTypes = [
        (TypeKind.B1, [typeof(byte), typeof(sbyte)]),
        (TypeKind.B2, [typeof(short), typeof(ushort)]),
        (TypeKind.B4, [typeof(int), typeof(uint), typeof(float)]),
        (TypeKind.B8, [typeof(long), typeof(ulong), typeof(double), typeof(nint)])
    ];

    static List<Type> UnmanagedTypes = [
        typeof(byte),  typeof(sbyte),
        typeof(short), typeof(ushort),
        typeof(int),   typeof(uint),   typeof(float),
        typeof(long),  typeof(ulong),  typeof(double), typeof(nint)
    ];

    static List<string> UnmanagedTypesNames = UnmanagedTypes.Select(t => t.Name).ToList();

    static Dictionary<string, TypeKind> TypeNameToTypeKind = TypeKindToTypes.SelectMany(z => z.types.Select(t => (z.kind, t))).ToDictionary(z => z.t.FullName!, z => z.kind);
}