using dnlib.DotNet;
using System.Reflection;

namespace Korn.Core;
public class DnModule
{
    public DnModule(string path, string name, Assembly assembly, Module reflectionModule, ModuleDefMD module)
    {
        Path = path;
        Name = name;
        Assembly = assembly;
        ReflectionModule = reflectionModule;
        Module = module;
    }

    public string Path;
    public string Name;
    public Assembly Assembly;
    public Module ReflectionModule;
    public ModuleDefMD Module;

    public static implicit operator ModuleDefMD(DnModule instance) => instance.Module;
}