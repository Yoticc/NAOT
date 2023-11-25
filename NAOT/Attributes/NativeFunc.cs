using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAOT;

[AttributeUsage(AttributeTargets.Method)]
public class NativeFuncAttribute<T> : Attribute where T : INAOTCallConv
{
    public readonly string? EntryPoint;

    public NativeFuncAttribute() { }

    public NativeFuncAttribute(string entryPoint) => EntryPoint = entryPoint;
}

public class NativeFuncAttribute : NativeFuncAttribute<__cdecl>;