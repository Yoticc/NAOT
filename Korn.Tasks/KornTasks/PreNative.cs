﻿class PreNative : KornTask
{
    public override void Execute()
    {
        ExecuteCascadeWithLogging(
            SetupGlobals,
            SetupKorn,
            SetupLogger,
            LoadConfig,

            SetupIlc,
            SetupObjKorn,
            SetupLibs,
            CopyLibraries,

            InitTaskManager,

            LoadAnalyzers,
            LogAnalyzerStats,

            LoadLibraries,
            ExecuteILTasks,
            AddInputsInRsp,
            ExecutePrepareNativeTasks,
            SaveLibraries,
            PushRspArguments
        );
    }

    void SetupGlobals()
    {
        SetupVars();
        SetupPaths();

        void SetupVars()
        {
            Vars.Configuration = this["Configuration"] == "Debug" ? "Debug" : "Release";
            Vars.TargetBinDir = this["TargetDir"];
            Vars.AssemblyName = this["AssemblyName"];
            Vars.ProjectDir = this["ProjectDir"];
        }

        void SetupPaths()
        {
            Paths.TargetObjDir = Vars.TargetBinDir.Replace("\\bin", "\\obj"); // 🥶
            Paths.RspFile = Path.Combine(Paths.TargetObjDir, "native", $"{Vars.AssemblyName}.ilc.rsp");
            Paths.OutputNativeTargetFileWithoutExtension = Path.Combine(Vars.TargetBinDir, "native", Vars.AssemblyName);
            Paths.OutputTargetFile = Path.Combine(Paths.TargetObjDir, $"{Vars.AssemblyName}.dll");

            SetupKornPaths();
            SetupObjKornPaths();

            void SetupKornPaths()
            {
                KornPaths.Dir = Path.Combine(Vars.ProjectDir, "korn");
                KornPaths.ConfigFile = Path.Combine(KornPaths.Dir, "config.json");
                KornPaths.ConfigBuildCommandFile = Path.Combine(KornPaths.Dir, "korn-build command.txt");
                KornPaths.CacheFile = Path.Combine(KornPaths.Dir, "cache.data");
                KornPaths.LogFile = Path.Combine(KornPaths.Dir, "log.txt");
                KornPaths.AnalyzersDir = Path.Combine(KornPaths.Dir, "analyzers");
            }

            void SetupObjKornPaths()
            {
                ObjKornPaths.Dir = Path.Combine(Paths.TargetObjDir, "korn");
                ObjKornPaths.InDir = Path.Combine(ObjKornPaths.Dir, "in");
                ObjKornPaths.OutDir = Path.Combine(ObjKornPaths.Dir, "out");
            }
        }
    }

    void SetupKorn()
    {
        string DEFAULT_BUILD_COMMAND = string.Join(' ', [
            "dotnet", 
            "publish", 
            "-r win-x64",
            "-c Release",
            "-p:PublishAot=true",
            "-p:IncludeNativeLibrariesForSelfExtract=true",
            "-p:StripSymbols=true"
            ]);

        if (!Directory.Exists(KornPaths.Dir) || (Directory.GetFiles(KornPaths.Dir).Length == 0 && Directory.GetDirectories(KornPaths.Dir).Length == 0))
        {
            Directory.CreateDirectory(KornPaths.Dir);

            Json.FileSerial(KornPaths.ConfigFile, new Config());
            File.WriteAllText(KornPaths.ConfigBuildCommandFile, DEFAULT_BUILD_COMMAND);
            Json.FileSerial(KornPaths.CacheFile, new KornCache(Vars.PackageVersion));
            File.Create(KornPaths.LogFile).Dispose();

            Directory.CreateDirectory(KornPaths.AnalyzersDir);
            CreateAnalyzerLink();
        }
        else if (!Directory.Exists(KornPaths.AnalyzersDir))
        {
            Directory.CreateDirectory(KornPaths.AnalyzersDir);
            CreateAnalyzerLink();
        }
        else if (Directory.GetFiles(KornPaths.AnalyzersDir).Length == 0)
        {
            CreateAnalyzerLink();
        }
        else
        {
            var isVersionMatch = true;
            KornCache? cache = null;
            if (!File.Exists(KornPaths.CacheFile))
                isVersionMatch = false;
            else
            {
                cache = Json.FileDeserial<KornCache>(KornPaths.CacheFile);
                if (cache is not null)
                {
                    if (cache.LastPackageVersion != Vars.PackageVersion)
                        isVersionMatch = false;
                }
                else isVersionMatch = false;
            }

            if (!isVersionMatch)
            {
                cache = new(Vars.PackageVersion);
                File.Delete(Path.Combine(KornPaths.AnalyzersDir, "Korn.Analyzer.dll"));
                CreateAnalyzerLink();
                Json.FileSerial(KornPaths.CacheFile, cache);
            }
        }

        void CreateAnalyzerLink()
        {
            var filePath = Path.Combine(Paths.PackageBuildDir, "Korn.Analyzer.dll");
            var linkPath = Path.Combine(KornPaths.AnalyzersDir, "Korn.Analyzer.dll");
            var createdLink = File.CreateSymbolicLink(linkPath, filePath);

            if (!createdLink.Exists)
                KornLogger.ShowCriticalMessage($"Failed to create symbol link (from: \"{filePath}\", to: \"{linkPath}\"). Probably, because VS is not running with administrator privileges.");
        }
    }

    void SetupLogger()
    {
        KornLogger.FileLogger.SetFile(KornPaths.LogFile);
    }

    void SetupIlc()
    {
        Ilc.RspArguments = RSPArguments.Parse(File.ReadAllLines(Paths.RspFile));
    }

    void SetupObjKorn()
    {
        if (Directory.Exists(ObjKornPaths.Dir))
            Directory.Delete(ObjKornPaths.Dir, true);
        Directory.CreateDirectory(ObjKornPaths.Dir);
        Directory.CreateDirectory(ObjKornPaths.InDir);
        Directory.CreateDirectory(ObjKornPaths.OutDir);
    }

    List<(string oldPath, string newPath)> inLibrariesPath = new();
    void SetupLibs()
    {
        Libs.References = new();
        Libs.Main = Path.Combine(Paths.TargetObjDir, Vars.AssemblyName + ".dll");

        var addedLibNames = new List<string>();
        foreach (var lib in Ilc.RspArguments.References)
        {
            var libName = Path.GetFileName(lib);

            if (addedLibNames.Contains(libName))
                continue;

            addedLibNames.Add(libName);
            Libs.References.Add(lib);
        }

        SetupLibCopied();

        void SetupLibCopied()
        {
            Libs.CopiedIn.All = new();
            Libs.CopiedIn.Input = new();
            Libs.CopiedIn.References = new();
            Libs.CopiedOut.All = new();
            Libs.CopiedOut.Input = new();
            Libs.CopiedOut.References = new();
            Libs.CopiedOut.Main = Path.Combine(ObjKornPaths.OutDir, $"{Vars.AssemblyName}.dll");

            foreach (var lib in Libs.References)
            {
                var libName = Path.GetFileName(lib);
                var name = Path.GetFileNameWithoutExtension(lib);

                if (libName.Contains("microsoft.netcore.app.runtime") && libName.Contains("WindowsBase.dll"))
                    continue;

                var newInPath = Path.Combine(ObjKornPaths.InDir, libName);
                var newOutPath = Path.Combine(ObjKornPaths.OutDir, libName);
                if (CoreEnv.Config.LibrariesToIgnore.Contains(name))
                    newOutPath = newInPath;

                inLibrariesPath.Add((lib, newInPath));
                Libs.CopiedIn.All.Add(newInPath);
                Libs.CopiedOut.All.Add(newOutPath);
                if (lib.Contains("runtime.win-x64.microsoft.dotnet.ilcompiler") || lib.Contains("microsoft.netcore.app.runtime"))
                {
                    Libs.CopiedIn.References.Add(newInPath);
                    Libs.CopiedOut.References.Add(newOutPath);
                }
                else
                {
                    Libs.CopiedIn.Input.Add(newInPath);
                    Libs.CopiedOut.Input.Add(newOutPath);
                }
            }
        }
    }

    void CopyLibraries()
    {
        foreach ((var oldPath, var newPath) in inLibrariesPath)
            File.Copy(oldPath, newPath);
    }

    void LoadConfig()
    {
        try
        {
            CoreEnv.Config = Json.FileDeserial<Config>(KornPaths.ConfigFile)!;
        }
        catch (Exception ex)
        {
            KornLogger.ShowCriticalMessage($"PreNative->LoadConfig: Couldn't deserialize config. Will be used default: {ex}");
            CoreEnv.Config = new();
        }
    }

    void InitTaskManager()
    {
        CoreEnv.TaskManager = new(
            typeof(InitTask),
            typeof(ILTask),
            typeof(ILInputTask),
            typeof(ILMainTask),
            typeof(PreIlcTask),
            typeof(ASMTask)
        );
    }

    void LoadAnalyzers()
    {
        Analyzers = new();

        AppDomain.CurrentDomain.AssemblyResolve += (s, e) =>
        {
            var name = e.Name.Split(", ")[0].Replace(".resources", "");
            var loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies().Concat([typeof(ModuleDef).Assembly]).ToList();

            var assembly = loadedAssemblies.Find(a => a.FullName is not null && a.FullName.Split(", ")[0] == name);
            if (assembly is null)
                KornLogger.WriteWarning("PreNative->LoadAnalyzers: AppDomain.CurrentDomain.AssemblyResolve: Cannot find loaded assembly for " + e.Name);
            return assembly;
        };

        foreach (var file in Directory.GetFiles(KornPaths.AnalyzersDir))
        {
            var assembly = Assembly.LoadFrom(file);
            Analyzers.Add(assembly);
            CoreEnv.TaskManager.AddExtractedTasks(assembly);
        }
    }

    void LogAnalyzerStats() => KornLogger.WriteMessage($"Uses {Analyzers.Count} analyzers: [{string.Join(", ", Analyzers.Select(analyzer => analyzer.GetName().Name))}]");

    void LoadLibraries()
    {
        var resolver = new PathAssemblyResolver(Libs.CopiedIn.All);
        var ctx = new MetadataLoadContext(resolver, "mscorlib");
        Dn.Context = ModuleDef.CreateModuleContext();
        Dn.Modules.All = new();
        Dn.Modules.Input = new();
        Dn.Modules.References = new();
        Dn.DnModules.All = new();
        Dn.DnModules.Input = new();
        Dn.DnModules.References = new();

        var mainModule = LoadModule(Paths.OutputTargetFile)!;
        Dn.Modules.All.Add(mainModule);
        Dn.DnModules.All.Add(mainModule);

        foreach (var lib in Libs.CopiedIn.Input)
        {
            var module = LoadModule(lib);
            if (module is null)
                continue;
            Dn.Modules.All.Add(module);
            Dn.Modules.Input.Add(module);
            Dn.DnModules.All.Add(module.Module);
            Dn.DnModules.Input.Add(module.Module);
        }

        if (CoreEnv.TaskManager.HasILTasks)
        {
            foreach (var lib in Libs.CopiedIn.References)
                AddReferenceModule(lib);
        }
        else
        {
            AddReferenceModule(FindLib("System.Runtime.InteropServices"));
            AddReferenceModule(FindLib("System.Private.CoreLib"));
            AddReferenceModule(FindLib("System.Linq"));
            AddReferenceModule(FindLib("mscorlib"));

            string FindLib(string name) => Libs.CopiedIn.References.Find(reference => Path.GetFileNameWithoutExtension(reference) == name)!;
        }

        void AddReferenceModule(string lib)
        {
            var module = LoadModule(lib);
            if (module is null)
                return;
            Dn.Modules.All.Add(module);
            Dn.Modules.References.Add(module);
            Dn.DnModules.All.Add(module.Module);
            Dn.DnModules.References.Add(module.Module);
        }

        Dn.Modules.Main = mainModule;

        Dn.Modules.This = Find("Korn");
        Dn.Modules.SystemRuntimeInteropServices = Find("System.Runtime.InteropServices");
        Dn.Modules.SystemPrivateCoreLib = Find("System.Private.CoreLib");
        Dn.Modules.SystemLinq = Find("System.Linq");
        Dn.Modules.Mscorelib = Find("mscorlib");

        DnModule Find(string name)
        {
            var found = Dn.Modules.All.Find(m => m.Name == name);
            if (found is null)
                KornLogger.WriteWarning($"PreNative->LoadLibs: Couldn't find module {name}");
            return found!;
        }

        DnModule? LoadModule(string path)
        {
            var name = Path.GetFileNameWithoutExtension(path);
            if (CoreEnv.Config.LibrariesToIgnore.Contains(name))
                return null;

            var assembly = ctx.LoadFromAssemblyPath(path);
            var modules = assembly.Modules;

            var moduleCount = modules.Count();
            if (moduleCount == 0)
                KornLogger.WriteWarning($"Assembly {name} skipped because has no modules");
            else if (moduleCount > 1)
                KornLogger.WriteWarning($"Assembly {name} skipped because has more than one module");
            else
            {
                var reflectionModule = modules.First();
                var dnModule = ModuleDefMD.Load(reflectionModule, Dn.Context);
                var module = new DnModule(path, name, assembly, reflectionModule, dnModule);
                return module;
            }

            return null;
        }
    }

    void ExecuteILTasks()
    {
        CoreEnv.TaskManager.Invoke<InitTask>(msBuildTask, []);
        CoreEnv.TaskManager.Invoke<ILMainTask>(msBuildTask, [Dn.DnModules.Main]);
        CoreEnv.TaskManager.InvokeFor<ILTask>(msBuildTask, Dn.DnModules.All.Select(m => (object?[]?)[m]).ToList());
        CoreEnv.TaskManager.InvokeFor<ILInputTask>(msBuildTask, [.. Dn.DnModules.Input.Select(m => (object?[]?)[m]), [Dn.DnModules.Main]]);
    }

    void SaveLibraries()
    {
        
        foreach (var module in Dn.Modules.All)
            module.Module.Write(Path.Combine(ObjKornPaths.OutDir, Path.GetFileName(module.Path)));
        
    }

    void AddInputsInRsp()
    {
        var nonDllInputs = Ilc.RspArguments.Inputs.Where(i => !i.EndsWith(".dll")).ToList();
        Ilc.RspArguments.Inputs.Clear();
        Ilc.RspArguments.Inputs.AddRange(nonDllInputs);
        Ilc.RspArguments.Inputs.Add(Libs.CopiedOut.Main);
        Ilc.RspArguments.Inputs.AddRange(Libs.CopiedOut.Input);

        Ilc.RspArguments.References.Clear();
        Ilc.RspArguments.References.AddRange(Libs.CopiedOut.References);
    }

    void ExecutePrepareNativeTasks()
    {
        CoreEnv.TaskManager.Invoke<PreIlcTask>(msBuildTask, []);
    }

    void PushRspArguments()
    {
        File.WriteAllLines(Paths.RspFile, Ilc.RspArguments.Serialize());
    }
}

record KornCache(string LastPackageVersion);