[AttributeUsage(AttributeTargets.Method)]
public class NativeFuncAttribute<T> : Attribute where T : ICallConv
{
    public readonly string? EntryPoint;

    public NativeFuncAttribute(string? entryPoint = null) => EntryPoint = entryPoint;
}

public class NativeFuncAttribute(string? entryPoint = null) : NativeFuncAttribute<__stdcall>(entryPoint);