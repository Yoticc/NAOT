using dnlib.PE;
using NAOT.Analyzer.Utils.Sugar;
using NAOT.Core.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NAOT.Analyzer.Utils.Dn;
public class StaticArraysManager
{
    const string PID_TYPE_NAME = "<PrivateImplementationDetails>";

    public StaticArraysManager(ModuleDefMD module)
    {
        Module = module;

        pid = module.FindType(PID_TYPE_NAME)!;
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

    TypeDef? GetStructType(int length)
    {
        foreach (var type in pid.NestedTypes)
            if (type.Name == GetStructTypeName(length))
                return type;

        return null;
    }

    TypeDef GetOrCreateStructType(int length)
    {
        var type = GetStructType(length);
        if (type == null)
        {
            type = new TypeDefUser(GetStructTypeName(length), AGlobals.ValueTypeType)
            { 
                PackingSize = 1,
                ClassSize = (uint)length
            };
            pid.NestedTypes.Add(type);
        }

        return type;
    }

    FieldDef GetOrCreateField(TypeDef type, byte[] array)
    {
        foreach (var field in pid.Fields)
        {
            if (!field.FieldType.IsSame(type))
                continue;

            //Console.WriteLine($"i: {field.}");

            Console.WriteLine($"{string.Join(", ", Module.GetTypes().SelectMany(t => t.Fields).Select(f => $"{f.HasFieldRVA} {f.RVA}"))}");

            var reader = Module.Metadata.PEImage.CreateReader(field.RVA);
            var b = reader.ReadBytes(array.Length);
            Console.WriteLine(string.Join(' ', b));

            //var bts = Module.ReadDataAt(fieldRVATable.Columns[0]);
        }

        return null;
    }

    public FieldDef CreateByteArray(byte[] array)
    {
        ValidatePID();

        var length = array.Length;
        var structType = GetOrCreateStructType(length);
        var field = GetOrCreateField(structType, array);

        return field;
    }
}