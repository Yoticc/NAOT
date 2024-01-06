using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NAOT.Core;
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
}