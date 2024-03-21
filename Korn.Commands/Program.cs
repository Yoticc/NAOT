using System.Diagnostics;

if (args.Length < 2)
{
    Console.WriteLine($"Bad arguments");
    return;
}

var processID = int.Parse(args[0]);
var process = Process.GetProcessById(processID);

var directory = args[1];

var solution = Directory.GetFiles(directory).FirstOrDefault(f => Path.GetExtension(f) == ".sln");

if (solution is null)
    Crash($"Unable find .sln file in project directory \"{directory}\"");

var projectPaths = 
    File.ReadAllLines(solution!)
    .Where(l => l.StartsWith("Project(\""))
    .Select(l => l.Split('\"')[5])
    .Select(p => Path.GetFullPath(p, directory))    
    .Select(Path.GetDirectoryName)
    .ToList();

var kornProjects = 
    projectPaths
    .Where(p => Directory.Exists(Path.Combine(p, "korn")))
    .ToList();

if (kornProjects.Count == 0)
    Crash($"Unable find korness project for directory \"{directory}\"");

if (kornProjects.Count > 1)
    Crash($"Found a few korness projects: [{string.Join(", ", kornProjects)}]. Should be only one");
    
var kornProject = kornProjects[0]!;
var kornBuildCommandFile = Path.Combine(kornProject, "korn", "korn-build command.txt");
string kornBuildCommand;

if (File.Exists(kornBuildCommandFile))
    kornBuildCommand = File.ReadAllText(kornBuildCommandFile);
else kornBuildCommand = "dotnet publish -r win-x64 -c Release";

Console.WriteLine("OK");
Console.WriteLine($"cd {kornProject}");
Console.WriteLine(kornBuildCommand);


void Crash(string message)
{
    Console.WriteLine(message);
    Environment.Exit(-1);
}
