namespace Korn.Core;
public class Config
{
    public Models.CustomEntryPointPath CustomEntryPointPath = new();
    public Models.CustomNativeOut CustomNativeOut = new();
    public bool BypassNonStaticNativeMethods = true;

    public class Models 
    {
        public class CustomEntryPointPath
        {
            public string desc => "Instead of using the EntryPointAttribute. Here can be written path to EntryPoint method without the EntryPointAttrbute";
            public bool Use = false;

            public string Path = "MyProj.Program.Main";
        }
            
        public class CustomNativeOut
        {
            public string desc => "Copy output native file to the path. Base path is the project dir";
            public bool Use = false;

            public string Path = @"out\KornExample.dll";
            public bool ExportPdbFile = true;
            public bool AutoRenamePdbFileToDllName = true;
        }
    }
}