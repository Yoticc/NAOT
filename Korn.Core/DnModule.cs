using dnlib.DotNet;
using System.Reflection;

namespace Korn.Core;
public record DnModule(string Path, string Name, Assembly Assembly, Module ReflectionModule, ModuleDefMD Module)
{
    public static implicit operator ModuleDefMD(DnModule instance) => instance.Module;
}