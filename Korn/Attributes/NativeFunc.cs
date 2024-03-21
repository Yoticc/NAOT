[AttributeUsage(AttributeTargets.Method)]
public class NativeFuncAttribute<T> : Attribute where T : ICallConv
{
    public NativeFuncAttribute(string? entryPoint = null) => EntryPoint = entryPoint;

    public readonly string? EntryPoint;
}

public class NativeFuncAttribute(string? entryPoint = null) : NativeFuncAttribute<__stdcall>(entryPoint);