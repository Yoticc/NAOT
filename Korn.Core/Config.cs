namespace Korn.Core;
public class Config
{
    public Models.EntryPoint EntryPoint = new();
    public Models.CustomNativeOut CustomNativeOut = new();
    public Models.AddictionalBuildArguments AddictionalBuildArguments = new();
    public bool BypassNonStaticNativeMethods = true;
    public bool AutoCloseDotnetProcesses = true;
    [JsonProperty] string desc => "Optimizing compiler by adding some libraries to ignore, it's worth adding here libraries-mappings that have a lot of non-user code. Example of name: \"UnrealEngine.Mappings\"";
    public List<string> LibrariesToIgnore = [];

    public class Models 
    {
        public class EntryPoint
        {
            [JsonProperty] string desc => "Use if you want to make a custom EntryPoint. Usually, if you are making a Console App, you do not need to use this option";
            public bool UseCustomEntryPoint = true;
            public CustomEntryPointPath EntryPointPath = new();

            public class CustomEntryPointPath
            {
                [JsonProperty] string desc => "Instead of using the EntryPointAttribute. Here can be written path to EntryPoint method without the EntryPointAttrbute";
                public bool Use = true;

                public string Path = "EntryPoint.Main";
            }
        }
            
        public class CustomNativeOut
        {
            [JsonProperty] string desc => "Copy output native file to the path. DirectoryPath relative to the project dir";
            public bool Use = true;

            public string DirectoryPath = @"out";
            public OutputFileName FileName = new();

            public class OutputFileName
            {
                public bool UseCustomName = true;
                public string CustomName = "Module";
            }

            public bool ExportPdbFile = true;
        }

        public class AddictionalBuildArguments
        {
            [JsonProperty] string desc => "Adds an additional argument to the build command. Set null if you don't want to consider the argument";
            [JsonProperty] string desc_ => "For best file size use: [InvariantGlobalization = true, StackTraceSupport = false, UseSystemResourceKeys = true]";

            public bool? InvariantGlobalization = true;
            public bool? StackTraceSupport = true;
            public bool? UseSystemResourceKeys = true;
            public bool? GenerateLogFile = false;
        }
    }
}