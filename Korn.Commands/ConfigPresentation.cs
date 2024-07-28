class ConfigPresentation
{
    public Models.EntryPoint EntryPoint { get; set; } = new();
    public Models.CustomNativeOut CustomNativeOut { get; set; } = new();
    public Models.AddictionalBuildArguments AddictionalBuildArguments { get; set; } = new();
    public bool BypassNonStaticNativeMethods { get; set; } = true;
    public bool AutoCloseDotnetProcesses { get; set; } = true;
    public List<string> LibrariesToIgnore { get; set; } = [];

    public class Models
    {
        public class EntryPoint
        {
            public bool UseCustomEntryPoint { get; set; } = true;
            public CustomEntryPointPath EntryPointPath { get; set; } = new();

            public class CustomEntryPointPath
            {
                public bool Use { get; set; } = true;
                public string Path { get; set; } = "EntryPoint.Load";
            }
        }

        public class CustomNativeOut
        {
            public bool Use { get; set; } = false;
            public string DirectoryPath { get; set; } = @"out";
            public OutputFileName FileName { get; set; } = new();

            public class OutputFileName
            {
                public bool UseCustomName { get; set; } = true;
                public string CustomName { get; set; } = "Module";
            }

            public bool ExportPdbFile { get; set; } = true;
        }

        public class AddictionalBuildArguments
        {
            public bool? InvariantGlobalization { get; set; } = true;
            public bool? StackTraceSupport { get; set; } = true;
            public bool? UseSystemResourceKeys { get; set; } = true;
            public bool? GenerateLogFile { get; set; } = false;
        }
    }
}