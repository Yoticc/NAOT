using System.Diagnostics;

if (args.Length < 2)
{
    Console.WriteLine($"Bad arguments");
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
        Crash($"Unable find korness project for directory \"{directory}\"");

    if (kornProjects.Count > 1)
        Crash($"Found a few korness projects: [{string.Join(", ", kornProjects)}]. Should be only one");

    kornProject = kornProjects[0]!;
}

if (kornProject is null)
{
    var projects = Directory.GetFiles(directory, "*.csproj", SearchOption.TopDirectoryOnly).Select(Path.GetDirectoryName).ToArray();
    if (projects.Length == 0)
        Crash($"Unable find korness project for directory \"{directory}\"");

    kornProject = projects[0];
}


if (kornProject is null)
    Crash($"Unable find .sln or .csproj file in directory \"{directory}\"");

var kornBuildCommandFile = Path.Combine(kornProject!, "korn", "korn-build command.txt");
string kornBuildCommand;

if (File.Exists(kornBuildCommandFile))
    kornBuildCommand = File.ReadAllText(kornBuildCommandFile);
else kornBuildCommand = "dotnet publish -r win-x64 -c Release -p:PublishAot=true -p:IncludeNativeLibrariesForSelfExtract=true";

Console.WriteLine("OK");
Console.WriteLine($"cd {kornProject}");
Console.WriteLine(kornBuildCommand);


void Crash(string message)
{
    Console.WriteLine(message);
    Environment.Exit(-1);
}
