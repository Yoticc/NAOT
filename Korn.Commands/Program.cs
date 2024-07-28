using System.Xml;

try
{
    if (args.Length < 2)
    {
        Crash("Bad arguments");
        return;
    }

    var processID = int.Parse(args[0]);
    var process = Process.GetProcessById(processID);

    var directory = args[1];

    string? kornProject = null;
    string? solution = null;
    
    solution = Directory.GetFiles(directory).FirstOrDefault(f => Path.GetExtension(f) == ".sln");
    if (solution is not null)
    {
        FindProjectsInSubDirectories();
        if (kornProject is null)
            FindProjectsByReferences();

        void FindProjectsInSubDirectories()
        {
            var projectPaths = Directory.GetDirectories(directory);

            var kornProjects =
                projectPaths
                .Where(p => !p.StartsWith('.'))
                .Where(p => Directory.Exists(Path.Combine(p, "korn")))
                .ToList();

            if (kornProjects.Count == 0)
                Crash($"FindProjectsInSubDirectories: Unable find korness project for directory \"{directory}\"");

            if (kornProjects.Count > 1)
                Crash($"FindProjectsInSubDirectories: Found a few korness projects: [{string.Join(", ", kornProjects)}]. Should be only one");

            kornProject = kornProjects[0]!;
        }

        void FindProjectsByReferences()
        {
            var projectPaths =
                File.ReadAllLines(solution)
                .Where(l => l.StartsWith("Project(\""))
                .Select(l => l.Split('\"')[5])
                .Select(p => Path.Combine(directory, string.Join('\\', p.Split('\\')[0..^1])))
                .ToList();

            var kornProjects =
                projectPaths
                .Where(p => Directory.Exists(Path.Combine(p, "korn")))
                .ToList();

            if (kornProjects.Count == 0)
                Crash($"FindProjectsByReferences: Unable find korness project for directory \"{directory}\"");

            if (kornProjects.Count > 1)
                Crash($"FindProjectsByReferences: Found a few korness projects: [{string.Join(", ", kornProjects)}]. Should be only one");

            kornProject = kornProjects[0]!;
        }
    }

    if (kornProject is null)
    {
        var projects = Directory.GetFiles(directory, "*.csproj").Select(Path.GetDirectoryName).ToArray();
        if (projects.Length == 0)
            Crash($"Unable find korness project for directory \"{directory}\"");

        kornProject = projects[0];
    }

    if (kornProject is null)
        Crash($"Unable find .sln or .csproj file in directory \"{directory}\"");

    var kornFolder = Path.Combine(kornProject!, "korn");
    var kornConfigFile = Path.Combine(kornFolder, "config.json");
    var kornBuildCommandFile = Path.Combine(kornFolder, "korn-build command.txt");

    var kornConfigText = File.Exists(kornConfigFile) ? File.ReadAllText(kornConfigFile) : "null";
    var config = JsonSerializer.Deserialize<ConfigPresentation>(kornConfigText);

    var kornBuildCommand = 
        File.Exists(kornBuildCommandFile)
        ? File.ReadAllText(kornBuildCommandFile)
        : "dotnet publish -r win-x64 -c Release -p:PublishAot=true -p:IncludeNativeLibrariesForSelfExtract=true -p:StripSymbols=true";

    if (config is not null)
    {
        var logFile =
            config.CustomNativeOut.Use
            ? Path.Combine(config.CustomNativeOut.DirectoryPath, "msbuild.log")
            : "msbuild.log";

        var arguments = config.AddictionalBuildArguments;
        if (arguments is not null)
        {
            if (arguments.InvariantGlobalization is not null)
                kornBuildCommand += $" -p:InvariantGlobalization={arguments.InvariantGlobalization}";
            if (arguments.StackTraceSupport is not null)
                kornBuildCommand += $" -p:StackTraceSupport={arguments.StackTraceSupport}";
            if (arguments.UseSystemResourceKeys is not null)
                kornBuildCommand += $" -p:UseSystemResourceKeys={arguments.UseSystemResourceKeys}";
            if (arguments.GenerateLogFile is not null && arguments.GenerateLogFile.Value && !kornBuildCommand.Contains("-fl"))
            {
                kornBuildCommand += $" -fl";
                if (!kornBuildCommand.Contains("-flp:"))
                    kornBuildCommand += $" -flp:logfile={logFile}";
            }
        }
    }

    SetupProject(Directory.GetFiles(kornProject!, "*.csproj").First());

    Console.WriteLine("OK");
    Console.WriteLine($"cd {kornProject}");
    Console.WriteLine(kornBuildCommand);
}
catch (Exception ex) { Crash($"Exception: {ex}"); }

void Crash(string message)
{
    Console.WriteLine(message);
    Environment.Exit(-1);
}

void SetupProject(string projectPath)
{
    var shouldBeSaved = false;
    var projectXml = new XmlDocument();
    projectXml.Load(projectPath);

    var root = projectXml.DocumentElement;
    if (root is null)
    {
        Crash($"PreBuild->Execute->SetupProjects: Bad the project .projcs xml file");
        return;
    }

    var foundUsings = false;
    var foundFilesIgnoring = ((string[])[@"korn\analyzers\**", @"out\**", @"korn\cache.data"]).ToDictionary(a => a, a => false);

    for (var childIndex = 0; childIndex < root.ChildNodes.Count; childIndex++)
    {
        var childNode = root.ChildNodes[childIndex]!;

        if (childNode.Name == "PropertyGroup")
            SetupProperties(childNode);

        if (childNode.Name == "ItemGroup")
            SetupItemGroup(childNode);
    }

    var firstItemGroupNode = GetFirstNode(root, "ItemGroup") ?? projectXml.CreateElement("ItemGroup");

    if (!foundUsings)
    {
        var newNode = projectXml.CreateElement("Using");

        var attribute = projectXml.CreateAttribute("Include");
        attribute.Value = @"korn";
        newNode.Attributes.Append(attribute);

        var innerNode = projectXml.CreateElement("Static");
        innerNode.InnerText = "True";
        newNode.AppendChild(innerNode);

        firstItemGroupNode.AppendChild(newNode);
        shouldBeSaved = true;
    }

    var compileIgnoring = foundFilesIgnoring.Where(d => !d.Value).ToList();

    if (compileIgnoring.Count > 0)
    {
        foreach (var (Key, Value) in compileIgnoring)
        {
            var newNode = projectXml.CreateElement("None");
            var attribute = projectXml.CreateAttribute("Remove");

            attribute.Value = Key;
            newNode.Attributes.Append(attribute);
            firstItemGroupNode.AppendChild(newNode);
        }

        shouldBeSaved = true;
    }

    if (shouldBeSaved)
        projectXml.Save(projectPath);

    void SetupProperties(XmlNode node)
    {
        var foundPlatforms = false;
        var foundAllowUnsafeBlocks = false;

        for (var childIndex = 0; childIndex < node.ChildNodes.Count; childIndex++)
        {
            var childNode = node.ChildNodes[childIndex]!;

            var value = childNode.InnerText;
            if (value is null)
                continue;

            switch (childNode.Name)
            {
                case "TargetFramework":
                    if (value.EndsWith("-windows"))
                        break;

                    childNode.InnerText = $"{value}-windows";
                    shouldBeSaved = true;
                    break;
                case "Platforms":
                    foundPlatforms = true;

                    if (value == "x64")
                        break;

                    childNode.InnerText = "x64";
                    shouldBeSaved = true;
                    break;
                case "AllowUnsafeBlocks":
                    foundAllowUnsafeBlocks = true;

                    if (value.Equals("true", StringComparison.OrdinalIgnoreCase))
                        break;

                    childNode.InnerText = "true";
                    shouldBeSaved = true;
                    break;
            }
        }

        if (!foundPlatforms)
        {
            var newNode = projectXml.CreateElement("Platforms");
            newNode.InnerText = "x64";
            node.AppendChild(newNode);
            shouldBeSaved = true;
        }

        if (!foundAllowUnsafeBlocks)
        {
            var newNode = projectXml.CreateElement("AllowUnsafeBlocks");
            newNode.InnerText = "true";
            node.AppendChild(newNode);
            shouldBeSaved = true;
        }
    }

    void SetupItemGroup(XmlNode node)
    {
        if (node.ChildNodes.Count == 0)
            return;

        for (var childIndex = 0; childIndex < node.ChildNodes.Count; childIndex++)
        {
            var child = node.ChildNodes[childIndex]!;
            switch (child.Name)
            {
                case "Using":
                    {
                        var attributes = child.Attributes;
                        if (attributes is null)
                            continue;

                        var attribute = attributes.GetNamedItem("Include");
                        if (attribute is null)
                            continue;

                        var value = attribute.Value;
                        if (value is null)
                            continue;

                        if (value == "korn")
                        {
                            var children = child.ChildNodes;
                            var hasStatic = false;
                            for (var childIndex2 = 0; childIndex2 < children.Count; childIndex2++)
                            {
                                var child2 = children[childIndex2]!;

                                if (child2.Name != "Static")
                                    continue;

                                var value2 = child2.InnerText;
                                if (value2 is null || value2 != "true")
                                    child2.InnerText = "true";

                                hasStatic = true;
                                break;
                            }

                            if (!hasStatic)
                            {
                                var newNode = projectXml.CreateElement("Static");
                                newNode.InnerText = "true";
                                child.AppendChild(newNode);
                            }

                            foundUsings = true;
                            break;
                        }

                        break;
                    }
                case "Folder":
                    {
                        var attributes = child.Attributes;
                        if (attributes is null)
                            continue;

                        var attribute = attributes.GetNamedItem("Include");
                        if (attribute is null)
                            continue;

                        var value = attribute.Value;
                        if (value is null)
                            continue;

                        if (value == @"korn\")
                        {
                            node.RemoveChild(child);
                            break;
                        }

                        break;
                    }
                case "None":
                    {
                        var attributes = child.Attributes;
                        if (attributes is null)
                            continue;

                        var attribute = attributes.GetNamedItem("Remove");
                        if (attribute is null)
                            continue;

                        var value = attribute.Value;
                        if (value is null)
                            continue;

                        foundFilesIgnoring[value] = true;

                        break;
                    }
            }
        }
    }

    XmlNode? GetFirstNode(XmlNode node, string name)
    {
        if (!node.HasChildNodes)
            return null;

        for (var childIndex = 0; childIndex < node.ChildNodes.Count; childIndex++)
        {
            var child = node.ChildNodes[childIndex]!;
            if (child.Name == name)
                return child;
        }

        return null;
    }
}