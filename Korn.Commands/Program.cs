using System.Diagnostics;
using System.Text.Json;

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

var kornFolder = Path.Combine(kornProject!, "korn");

var kornBuildCommandFile = Path.Combine(kornFolder, "korn-build command.txt");
var kornBuildCommand = File.Exists(kornBuildCommandFile) ? File.ReadAllText(kornBuildCommandFile) : "dotnet publish -r win-x64 -c Release -p:PublishAot=true -p:IncludeNativeLibrariesForSelfExtract=true -p:StripSymbols=true";

var kornConfigFile = Path.Combine(kornFolder, "config.json");
var kornConfigText = File.Exists(kornConfigFile) ? File.ReadAllText(kornConfigFile) : "null";
var config = JsonSerializer.Deserialize<ConfigPresentation>(kornConfigText);

if (config is not null)
{
    var arguments = config.AddictionalBuildArguments;
    if (arguments is not null)
    {
        if (arguments.InvariantGlobalization is not null)
            kornBuildCommand += $" -p:InvariantGlobalization={arguments.InvariantGlobalization}";
        if (arguments.StackTraceSupport is not null)
            kornBuildCommand += $" -p:StackTraceSupport={arguments.StackTraceSupport}";
        if (arguments.UseSystemResourceKeys is not null)
            kornBuildCommand += $" -p:UseSystemResourceKeys={arguments.UseSystemResourceKeys}";
    }
} 

Console.WriteLine("OK");
Console.WriteLine($"cd {kornProject}");
Console.WriteLine(kornBuildCommand);


void Crash(string message)
{
    Console.WriteLine(message);
    Environment.Exit(-1);
}
