var dotnetProcesses = Process.GetProcessesByName("dotnet").ToList();
dotnetProcesses.ForEach(p => p.Kill());
if (dotnetProcesses.Count > 0)
    Thread.Sleep(250); // Wait when all handles will be free

var user = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
var packages = Combine(user, $@".nuget\packages");

var packageId = "korn";
var packageName = "Korn";
var outPath = @"\bin\x64\Release\net8.0-windows";

var package = Combine(packages, packageId);
if (Directory.Exists(package))
    Directory.Delete(package, true);

var storage = Combine(user, $@"source\dotnetnative\{packageName}\{packageName}\nuget\storage");

var lib = Combine(storage, "lib");
var lib_bin = Combine(lib, "net8.0");

var build = Combine(storage, "build");

var project = Combine(user, $@"source\dotnetnative\{packageName}");
var korn_bin = Combine(project, $@"{packageName}{outPath}");
var core_bin = Combine(project, $@"{packageName}.Core{outPath}");
var tasks_bin = Combine(project, $@"{packageName}.Tasks{outPath}");
var analyzer_bin = Combine(project, $@"{packageName}.Analyzer{outPath}");
var commands_bin = Combine(project, $@"{packageName}.Commands{outPath}");
var dnb_package = Directory.GetDirectories(Combine(packages, "DotnetNativeBase")).Last();
var dnb_bin = Combine(dnb_package, @"lib\net8.0");

((string dir, string path) from, (string dir, string path) to)[] files = [
    ((korn_bin, $"{packageName}.dll"), (lib_bin, $"{packageName}.dll")),
    ((korn_bin, $"{packageName}.pdb"), (lib_bin, $"{packageName}.pdb")),

    ((core_bin, $"{packageName}.Core.dll"), (build, $"{packageName}.Core.dll")),
    ((Combine(user, @".nuget\packages\dnlib\4.4.0\lib\net6.0"), "dnlib.dll"), (build, "dnlib.dll")),
    ((tasks_bin, $"{packageName}.Tasks.dll"), (build, $"{packageName}.Tasks.dll")),
    ((analyzer_bin, $"{packageName}.Analyzer.dll"), (build, $"{packageName}.Analyzer.dll")),
    ((dnb_bin, "DotnetNativeBase.dll"), (build, "DotnetNativeBase.dll")),

    .. GetConsoleAppCopyFiles(commands_bin, build, $"{packageName}.Commands")
];

((List<string>)[
    storage,
    lib, lib_bin,
    build
]).ForEach(d => Directory.CreateDirectory(d));

files
.Select(f => (from: Combine(f.from.dir, f.from.path), to: Combine(f.to.dir, f.to.path)))
.ToList()
.ForEach(file =>
{
    var (from, to) = file;

    if (File.Exists(to))
        File.Delete(to);
    File.Copy(from, to);
});

((string, string), (string, string))[] GetConsoleAppCopyFiles(string from, string to, string name)
    => ((string[])["dll", "exe", "runtimeconfig.json"])
    .Select(e => $"{name}.{e}")
    .Select(n => ((from, n), (to, n)))
    .ToArray();