using dnlib.DotNet.Emit;
using NAOT.Analyzer.Utils.Sugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NAOT.Analyzer.Utils.Dn;
public class StaticArraysManager
{
    const string PID_TYPE_NAME = "<PrivateImplementationDetails>";

    public StaticArraysManager(ModuleDefMD module)
    {
        Module = module;

        pid = module.FindType(PID_TYPE_NAME, true)!;
        isInited = pid != null;
    }

    public readonly ModuleDefMD Module;

    TypeDef pid;
    bool isInited;

    void ValidatePID()
    {
        if (isInited)
            return;

        isInited = true;
        pid = new TypeDefUser(PID_TYPE_NAME);
        Module.Types.Add(pid);
    }

    string GetStructTypeName(int length) => $"__StaticArrayInitTypeSize={length}";
    string GetArrayHash(byte[] array)
    {
        using var md5 = MD5.Create();
        return string.Concat(md5.ComputeHash(array).Select(b => $"{b:X2}"));
    }

    TypeDef? GetExistingStructType(int length)
    {
        foreach (var type in pid.NestedTypes)
            if (type.Name == GetStructTypeName(length))
                return type;

        return null;
    }

    FieldDef? GetExistingField(TypeDef type, string name, byte[] array)
    {
        foreach (var field in pid.Fields)
        {
            if (type != null && field.FieldType.IsSame(type))
            {
                if (field.HasFieldRVA)
                {
                    var reader = Module.Metadata.PEImage.CreateReader(field.RVA);
                    var readedBytes = reader.ReadBytes(array.Length);
                    if (Enumerable.SequenceEqual(readedBytes, array))
                        return field;
                }
            }
            else
            {
                if (field.FieldType.IsSame(AGlobals.ByteArray))
                    if (field.Name == name)
                        return field;
            }
        }

        return null;
    }

    MethodDef GetOrCreateCCtor()
    {
        var method = pid.Methods.ToList().Find(m => m.Name == ".cctor");
        if (method == null)
        {
            method = new MethodDefUser(".cctor", new MethodSig(CallingConvention.Default, 0, Module.CorLibTypes.Void), MethodAttributes.Static | MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName);
            var body = method.Body = new();
            body.Instructions.Add(new(OpCodes.Ret));
            pid.Methods.Add(method);
        }

        return method;
    }

    public FieldDef CreateByteArray(byte[] array)
    {
        ValidatePID();

        var length = array.Length;
        var structType = GetExistingStructType(length);
        var name = GetArrayHash(array);
        var field = GetExistingField(structType, name, array);
        if (field == null)
        {
            field = new FieldDefUser(name, new FieldSig(AGlobals.ByteArray), FieldAttributes.Static);
            pid.Fields.Add(field);

            var cctor = GetOrCreateCCtor();
            ((Instruction[])[
                Instruction.CreateLdcI4(length),
                new(OpCodes.Newarr, new TypeSpecUser(Module.CorLibTypes.Byte)),
                new(OpCodes.Stsfld, field),
                ..
                Enumerable.Range(0, length)
                .Where(i => array[i] != 0)
                .Select(i => (Instruction[])[
                    new(OpCodes.Ldsfld, field),
                    Instruction.CreateLdcI4(i),
                    Instruction.CreateLdcI4(array[i]),
                    new(OpCodes.Stelem_I1)
                ])
                .SelectMany(i => i)
            ])
            .Reverse()
            .ToList()
            .ForEach(i => cctor.Body.Instructions.Insert(0, i));
        }

        return field;
    }
}