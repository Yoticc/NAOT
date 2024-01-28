using dnlib.DotNet.Emit;
using Korn.Analyzer.Utils.Dn;
using Korn.Analyzer.Utils.Sugar;
using Korn.Core.Tasks;
using System.Globalization;
using System.Numerics;

namespace Korn.Analyzer.Tasks;
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

        var definesMethods = AGlobals.DefinesType.Methods.ToList();

        var hexMethod = definesMethods.Find(m => m.Name == "hex")!;
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
                        if (target(module, sam, insts, ref i))
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
    delegate bool Handler(ModuleDefMD module, StaticArraysManager sam, IList<Instruction> insts, ref int index);

    Handler EmptyArrayHandler = (ModuleDefMD module, StaticArraysManager sam, IList<Instruction> insts, ref int i) =>
    {
        var prevInstIndex = i - 1;
        var prevInst = insts[i - 1];
        var prevInstCode = prevInst.OpCode.Code;

        /*
         *  [i-1]  call  System.Array::Empty<?>()
         *  [i]    call  uint8[] hex(object[]) 
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
         *  [i]    call      uint8[] hex(object[]) 
        */
        else if (prevInstCode == Code.Newarr)
        {
            if (insts[i - 2].OpCode.Code == Code.Ldc_I4_0)
            {
                insts[i] = new(OpCodes.Newarr, new TypeSpecUser(module.CorLibTypes.Byte));
                insts.RemoveAt(i - 1);
                i -= 1;
                /*
                 *  [i-2]  ldc.i4.0
                 *  [i]    newarr    uint8
                */
                return true;
            }
        }
        return false;
    };

    Handler LocalArrayHandler = (ModuleDefMD module, StaticArraysManager sam, IList<Instruction> insts, ref int i) =>
    {
        var prevInstIndex = i - 1;
        var prevInst = insts[i - 1];
        var prevInstCode = prevInst.OpCode.Code;

        /*
         * [o]    stloc
         * ...
         * [i-1]  ldloc?
         * [i]    uint8[] hex(object[])
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
                        var bytes = CompileToByteArray(module, innerIsnts, out int affectedInstructions);
                        ReplaceInstructionsByByteArray(module, insts, o - affectedInstructions, i, bytes, sam, out int affectedInstructions2);
                        i -= affectedInstructions2;

                        return true;
                    }
                }
            }
        }

        return false;
    };

    Handler ArrayHandler = (ModuleDefMD module, StaticArraysManager sam, IList<Instruction> insts, ref int i) =>
    {
        var prevInstIndex = i - 1;
        var prevInst = insts[i - 1];
        var prevInstCode = prevInst.OpCode.Code;

        /*
         *  [i-1]  stelem.ref
         *  [i]    call  uint8[] hex(object[]) 
        */
        if (prevInstCode == Code.Stelem_Ref)
        {
            var bytes = CompileToByteArray(module, insts.ToList().GetRange(0, i), out int affectedInstructions);
            ReplaceInstructionsByByteArray(module, insts, i - affectedInstructions, i, bytes, sam, out int affectedInstructions2);
            i -= affectedInstructions2;
            return true;
        }
        return false;
    };
    #endregion

    static void ReplaceInstructionsByByteArray(ModuleDefMD module, IList<Instruction> insts, int startPos, int endPos, List<byte> bytes, StaticArraysManager sam, out int affectedInstructions)
    {
        if (bytes == null)
            Console.WriteLine($"HandleHexILTask->ReplaceInstructionsByByteArray: bytes is null");

        affectedInstructions = endPos - startPos;
        for (int i = 0; i <= endPos - startPos; i++)
            insts.RemoveAt(startPos);

        if (bytes.Count == 0)
        {
            insts.Insert(startPos, new(OpCodes.Ldc_I4_0));
            insts.Insert(startPos + 1, new(OpCodes.Newarr, new TypeSpecUser(module.CorLibTypes.Byte)));
            affectedInstructions -= 2;
        }
        else
        {
            var field = sam.CreateByteArray(bytes.ToArray());
            var isArray = field.FieldType.IsArray;

            if (isArray)
            {
                insts.Insert(startPos, new(OpCodes.Ldsfld, field));

                var toArrayMethRef = module.Import(AGlobals.EnumerableToArrayMethod);
                var toArrayMethSpec = new MethodSpecUser(toArrayMethRef, new GenericInstMethodSig(module.CorLibTypes.Byte));
                insts.Insert(startPos + 1, new(OpCodes.Call, toArrayMethSpec));

                affectedInstructions -= 2;
            }
            else
            {
                insts.Insert(startPos, Instruction.CreateLdcI4(bytes.Count));
                insts.Insert(startPos + 1, new(OpCodes.Newarr, new TypeSpecUser(module.CorLibTypes.Byte.ToTypeDefOrRefSig())));
                insts.Insert(startPos + 2, new(OpCodes.Dup));
                insts.Insert(startPos + 3, new(OpCodes.Ldtoken, field));
                insts.Insert(startPos + 4, new(OpCodes.Call, module.Import(AGlobals.InitializeArrayMethod)));

                affectedInstructions -= 5;
            }
        }
    }

    static List<byte>? ParseString(string input)
    {
        var whitelistChars = "0123456789abcdef_ ";
        var lastParsingPart = "UNKNOWN";
        try
        {
            input = input.ToLower();
            input = input.Replace("0x", "").Replace(",", " ");
            input = new string(
                input
                .Where(whitelistChars.Contains)
                .ToArray()
            );

            var result = new List<byte>();

            var splitted = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            for (var i = 0; i < splitted.Count; i++)
            {
                if (splitted[i].Length % 2 == 1)
                    splitted[i] = '0' + splitted[i];
            }

            foreach (var part in splitted)
            {
                lastParsingPart = part;
                if (part.StartsWith("_"))
                    result.AddRange(BigInteger.Parse(part.Substring(1, part.Length - 1)).ToByteArray().Reverse());
                else result.AddRange(BigInteger.Parse(part, NumberStyles.HexNumber).ToByteArray().Reverse());
            }

            return result;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"HandleHexILTask->CompileToByteArray->ParseString: Unable parse string \'{input}\'('{lastParsingPart}'): {ex}");
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

    static List<byte>? CompileToByteArray(ModuleDefMD module, List<Instruction> instructions, out int affectedInstructions)
    {
        affectedInstructions = -1;

        var result = new List<byte>();

        var arrayInstsNullable = GetArrayInstructions(module, instructions);
        if (arrayInstsNullable == null)
            return null;

        var arrayInsts = arrayInstsNullable.Value;
        affectedInstructions = arrayInsts.totalLength;

        foreach (var insts in arrayInsts.instructions)
        {
            var count = insts.Count;
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
                    else if (instCode == Code.Ldtoken)
                    {
                        var field = instOperand as FieldDef;
                        var name = field.FieldType.FullName;
                        var byteLength = int.Parse(name.Split("=")[1]);
                        var reader = module.Metadata.PEImage.CreateReader(field.RVA);
                        var bytes = reader.ReadBytes(byteLength);
                        result.AddRange(bytes);
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
                                byte[] parsed;

                                if (instOperand == null)
                                    parsed = ParseInteger(GetLdcInteger(inst), (TypeKind)boxType);
                                else
                                    parsed = ParseInteger(instOperand, (TypeKind)boxType);
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

        return result;
    }

    static object GetLdcInteger(Instruction inst) => inst.OpCode.Code switch
    {
        Code.Ldc_I4_0 => 0,
        Code.Ldc_I4_1 => 1,
        Code.Ldc_I4_2 => 2,
        Code.Ldc_I4_3 => 3,
        Code.Ldc_I4_4 => 4,
        Code.Ldc_I4_5 => 5,
        Code.Ldc_I4_6 => 6,
        Code.Ldc_I4_7 => 7,
        Code.Ldc_I4_8 => 8,
        Code.Ldc_I4_M1 => -1
    };

    #region Get Instructions
    static (List<List<Instruction>> instructions, int totalLength)? GetArrayInstructions(ModuleDefMD module, List<Instruction> insts)
    {
        var instructions = new List<List<Instruction>>();
        var foundElements = 0;
        var predicateElements = 0;
        var isLastStelem = false;
        var unmanagedArrayInstructions = new List<(int index, List<Instruction> instructions)>();
        List<Instruction>? currentNode = null;

        for (int i = insts.Count - 1; i >= 0; i--)
        {
            var inst = insts[i];
            var opcode = inst.OpCode;
            var code = opcode.Code;
            var operand = inst.Operand;

            if (code == Code.Stelem_Ref)
            {
                foundElements++;

                if (!isLastStelem)
                    AddToResult();

                isLastStelem = true;
            }
            else if (code.IsStelem())
            {
                if (!isLastStelem)
                    AddToUnmanagedList(i);

                isLastStelem = true;
            }
            else if (code == Code.Newarr)
            {
                isLastStelem = false;

                i--;
                var arrayLength = insts[i].GetLdcI4Value();
                var typeName = ((ITypeDefOrRef)operand).FullName;
                var isUnmanaged = UnmanagedTypesNames.Contains(typeName);

                if (currentNode != null && currentNode.Count != 0)
                {
                    if (isUnmanaged)
                    {
                        AddToUnmanagedList(i);
                        PushUnmanagedToResult((ITypeDefOrRef)operand, arrayLength);
                    }
                    else
                    {
                        AddToResult();
                    }
                }

                if (!isUnmanaged)
                    predicateElements += arrayLength;

                if (!isUnmanaged && predicateElements == foundElements)
                    return (instructions, insts.Count - i);
            }
            else
            {
                isLastStelem = false;

                if (code == Code.Call && operand != null && (operand as IMethodDefOrRef).Name == "InitializeArray")
                {
                    var prevInst = insts[i - 1];
                    if (prevInst.OpCode.Code == Code.Ldtoken)
                    {
                        AddToCurrentNode(prevInst);
                        i -= 6;
                    }
                    else Console.WriteLine("HandleHexILTask->GetArrayInstructions: Unexpected call instruction in hex's method arguments");
                }
                else if (inst.IsLdcI4() && i > 0 && insts[i - 1].OpCode.Code == Code.Dup)
                    i--;
                else if (inst.OpCode.Code.ToString().StartsWith("Conv")) { }
                else AddToCurrentNode(inst);
            }
        }

        Console.WriteLine($"HandleHexILTask->GetArrayInstructions: Unable parse IL code. Vars: foundElements: {foundElements}, predicateElements: {predicateElements}"); //  Code:\n{string.Join('\n', insts.Select(i => $"{i.OpCode.Code} {i.Operand}"))}
        return null;

        void AddToResult()
        {
            if (currentNode != null)
                if (currentNode.Count > 0)
                    instructions?.Insert(0, currentNode);
            currentNode = new();
        }
        void AddToUnmanagedList(int cursorIndex)
        {
            var index = -1;

            for (var o = cursorIndex; o < insts.Count; o++)
                if (insts[o].OpCode.Code == Code.Dup)
                {
                    var indexInstruction = insts[o + 1];
                    if (!indexInstruction.IsLdcI4())
                        Console.WriteLine($"HandleHexILTask->GetArrayInstructions->AddToUnmanagedList: Wrong instruction under Dup instruction.");

                    index = indexInstruction.GetLdcI4Value();
                }

            if (currentNode != null)
                if (currentNode.Count > 0)
                    unmanagedArrayInstructions?.Insert(0, (index, currentNode));
            currentNode = new();
        }
        void AddToCurrentNode(Instruction inst) => currentNode?.Insert(0, inst);
        void PushUnmanagedToResult(ITypeDefOrRef type, int arrayLength)
        {
            var array = new List<Instruction>[arrayLength];

            for (var i = 0; i < arrayLength; i++)
            {
                var existingElementIndex = unmanagedArrayInstructions.FindIndex(a => a.index == i);
                if (existingElementIndex != -1)
                {
                    var element = array[i] = unmanagedArrayInstructions[existingElementIndex].instructions;

                    if (element.FindIndex(e => e.OpCode.Code == Code.Box) != -1)
                        element.Add(new Instruction(OpCodes.Box, type));
                }
                else
                {
                    var element = array[i] = new List<Instruction>();
                    element.Add(Instruction.CreateLdcI4(0));
                    element.Add(new Instruction(OpCodes.Box, type));
                }
            }

            unmanagedArrayInstructions = new();
        }
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
        typeof(byte),
        typeof(sbyte),
        typeof(short),
        typeof(ushort),
        typeof(int),
        typeof(uint),
        typeof(float),
        typeof(long),
        typeof(ulong),
        typeof(double),
        typeof(nint)
    ];

    static List<string> UnmanagedTypesNames = UnmanagedTypes.Select(t => t.FullName).ToList();

    static Dictionary<string, TypeKind> TypeNameToTypeKind = TypeKindToTypes.SelectMany(z => z.types.Select(t => (z.kind, t))).ToDictionary(z => z.t.FullName!, z => z.kind);
}