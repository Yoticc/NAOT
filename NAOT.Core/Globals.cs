using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NAOT.Core;
public static class Globals
{
    public static string PackageVersion = "1.0.0";

    public static Random Rnd = new();

    [AllowedValues("Debug", "Release")]
    public static string Configuration;
    public static string RuntimeIdentifier;
    public static string TargetBinDir;
    public static string TargetObjDir;
    public static string AssemblyName;
    public static string ProjectDir;

    public static string NaotDir;
    public static string NaotConfigFile;
    public static string NaotAnalyzersDir;
    public static string ObjNaotDir;
    public static string MirrorLibsDir;
    public static string RspFile;

    public static string PackagesDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @".nuget\packages");
    public static string PackageNaotDir = Path.Combine(PackagesDir, "naot", PackageVersion);

    public static List<string> OriginalLibPaths;
    public static List<string> SpoofedLibPaths;
    public static List<string> AllLibPaths;
    public static string MainLibPath;

    public static List<Assembly> Analyzers;
    public static List<object> AllTaskInstances;
    public static List<object> ILTaskInstances;
    public static List<object> ILMainTaskInstances;
    public static List<object> ASMTaskInstances;
    public static List<object> InitTaskInstances;

    public static ModuleContext DnContext;
    public static List<ModuleDefMD> DnModules;
    public static ModuleDefMD DnMainModule;
    public static ModuleDefMD DnMscorelib;
    public static ModuleDefMD DnSystemPrivateCorLib;
    public static ModuleDefMD DnSystemRuntimeInteropServices;
}