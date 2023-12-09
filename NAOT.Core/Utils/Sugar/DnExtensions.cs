using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAOT.Core.Utils;
public static partial class SugarExtensions
{
    public static TypeDef? FindType(this ModuleDefMD module, string name) => module.GetTypes().ToList().Find(t => t.FullName == name);

    public static bool IsEmpty(this TypeDef type) =>
        !type.HasFields &&
        !type.HasProperties &&
        !type.HasMethods &&
        !type.HasNestedTypes;

    public static void RemoveTypeFromModule(this TypeDef type)
    {
        if (type.IsNested)
            type.DeclaringType.NestedTypes.Remove(type);
        else type.Module.Types.Remove(type);
    }
}