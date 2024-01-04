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

    public static RSPArguments RspArguments;

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
    public static string OutLibsDir; 
    public static string RspFile;
    public static string OutputNativeFile;

    public static string PackagesDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @".nuget\packages");
    public static string PackageNaotDir = Path.Combine(PackagesDir, "naot", PackageVersion);
    public static string PackageNaotBuildDir = Path.Combine(PackageNaotDir, "build");

    public static List<string> AdditionalCompilerLibPaths;
    public static List<string> SpoofedLibPaths;
    public static List<string> SpoofedActualLibPaths;
    public static List<string> ActualLibPaths;
    public static List<string> DnLibPaths;
    public static string MainLibPath;

    public static List<Assembly> Analyzers;
    public static List<TaskInstanceData> AllTaskInstances = new();
    public static List<TaskInstanceData> ILTaskInstances = new();
    public static List<TaskInstanceData> ILActualTaskInstances = new();
    public static List<TaskInstanceData> ILMainTaskInstances = new();
    public static List<TaskInstanceData> ASMTaskInstances = new();
    public static List<TaskInstanceData> InitTaskInstances = new();
    public static List<TaskInstanceData> PrepareNativeTaskInstances = new();

    public static ModuleContext DnContext;
    public static Dictionary<ModuleDefMD, string> DnModulesNames;
    public static Dictionary<ModuleDefMD, string> DnModulesPaths;
    public static List<ModuleDefMD> DnModules;
    public static List<ModuleDefMD> DnActualModules;
    public static ModuleDefMD DnNAOTModule;
    public static ModuleDefMD DnMainModule;
    public static ModuleDefMD DnMscorelib;
    public static ModuleDefMD DnSystemPrivateCoreLib;
    public static ModuleDefMD DnSystemRuntimeInteropServices;
}