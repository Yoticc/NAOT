using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAOT.Core.Utils;
public static partial class SugarExtensions
{
    public static TypeDef? FindType(this ModuleDefMD module, string name) =>
        module
        .GetTypes()
        .SelectMany(t => t.GetTypes())
        .ToList()
        .Find(t => t.FullName == name);
}