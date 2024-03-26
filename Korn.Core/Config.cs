using Newtonsoft.Json;

namespace Korn.Core;
public class Config
{
    public Models.CustomEntryPointPath CustomEntryPointPath = new();
    public Models.CustomNativeOut CustomNativeOut = new();
    public Models.AddictionalBuildArguments AddictionalBuildArguments = new();
    public bool BypassNonStaticNativeMethods = true;

    public class Models 
    {
        public class CustomEntryPointPath
        {
            [JsonProperty] string desc => "Instead of using the EntryPointAttribute. Here can be written path to EntryPoint method without the EntryPointAttrbute";
            public bool Use = false;

            public string Path = "MyProj.Program.Main";
        }
            
        public class CustomNativeOut
        {
            [JsonProperty] string desc => "Copy output native file to the path. Base path is the project dir";
            public bool Use = false;

            public string Path = @"out\Module.dll";
            public bool ExportPdbFile = true;
            public bool AutoRenamePdbFileToDllName = true;
        }

        public class AddictionalBuildArguments
        {
            [JsonProperty] string desc => "Adds an additional argument to the build command. Set null if you don't want to consider the argument";
            [JsonProperty] string desc_ => "For best file size use: [InvariantGlobalization = true, StackTraceSupport = false, UseSystemResourceKeys = true]";

            public bool? InvariantGlobalization = true;
            public bool? StackTraceSupport = true;
            public bool? UseSystemResourceKeys = true;
        }
    }
}