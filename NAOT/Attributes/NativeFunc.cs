using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[AttributeUsage(AttributeTargets.Method)]
public class NativeFuncAttribute<T> : Attribute where T : INAOTCallConv
{
    public readonly string? EntryPoint;

    public NativeFuncAttribute(string? entryPoint = null) => EntryPoint = entryPoint;
}

public class NativeFuncAttribute(string? entryPoint = null) : NativeFuncAttribute<__stdcall>(entryPoint);