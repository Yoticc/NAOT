global using dnlib.DotNet;
global using static NAOT.Core.Utils.SugarExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAOT.Analyzer;
public static class AGlobals
{
    public static TypeSig TypeType;
    public static TypeSig TypeArrayType;
    public static TypeDef UnmanagedCallersOnlyAttribute;
    public static MethodDef UnmanagedCallersOnlyAttributeCtor;
}