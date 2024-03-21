using dnlib.DotNet;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Korn.Core;
public static class Globals
{
    public static Random Rnd = new();

    public static List<Assembly> Analyzers;
    public static TaskManager TaskManager;

    public static Config Config;

    public static class Vars
    {
        public static string PackageVersion = "1.0.0";

        [AllowedValues("Debug", "Release")]
        public static string Configuration;
        public static string AssemblyName;
        public static string ProjectDir;
        public static string TargetBinDir;
    }

    public static class Paths
    {
        public static string UserDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        public static string PackagesDir = Path.Combine(UserDir, @".nuget\packages");
        public static string PackageDir = Path.Combine(PackagesDir, "korn", Vars.PackageVersion);
        public static string PackageBuildDir = Path.Combine(PackageDir, "build");
        public static string PackageToolsDir = Path.Combine(PackageDir, "tools");

        public static string TargetObjDir;
        public static string RspFile;
        public static string OutputNativeTargetFile;
        public static string OutputTargetFile;

        public static class Korn
        {
            public static string Dir;
            public static string ConfigFile;
            public static string ConfigBuildCommandFile;
            public static string AnalyzersDir;
        }

        public static class ObjKorn
        {
            public static string Dir;
            public static string InDir;
            public static string OutDir;
        }
    }

    public static class Libs
    {
        public static string Main;

        public static List<string> References;

        public static class CopiedIn
        {
            public static List<string> All;
            public static List<string> Input;
            public static List<string> References;
        }

        public static class CopiedOut
        {
            public static string Main;
            public static List<string> All;
            public static List<string> Input;
            public static List<string> References;
        }
    }

    public static class Dn
    {
        public static ModuleContext Context;

        public static class Modules
        {
            public static List<DnModule> All;
            public static List<DnModule> Input;
            public static List<DnModule> References;

            public static DnModule Main;

            public static DnModule This;
            public static DnModule Mscorelib;
            public static DnModule SystemPrivateCoreLib;
            public static DnModule SystemRuntimeInteropServices;
            public static DnModule SystemLinq;
        }

        public static class DnModules
        {
            public static List<ModuleDefMD> All;
            public static List<ModuleDefMD> Input;
            public static List<ModuleDefMD> References;

            public static ModuleDefMD Main => Modules.Main;

            public static ModuleDefMD This => Modules.This;
            public static ModuleDefMD Mscorelib => Modules.Mscorelib;
            public static ModuleDefMD SystemPrivateCoreLib => Modules.SystemPrivateCoreLib;
            public static ModuleDefMD SystemRuntimeInteropServices => Modules.SystemRuntimeInteropServices;
            public static ModuleDefMD SystemLinq => Modules.SystemLinq;
        }
    }

    public static class Ilc
    {
        public static RSPArguments RspArguments;
    }
}