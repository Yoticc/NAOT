using static System.IO.Path;

var user = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

var packageId = "korn";
var packageName = "Korn";
var outPath = @"\bin\Release\net8.0";

var package = Combine(user, $@".nuget\packages\{packageId}");
if (Directory.Exists(package))
    Directory.Delete(package, true);

var storage = Combine(user, $@"source\repos\{packageName}\{packageName}\nuget\storage");

var lib = Combine(storage, "lib");
var lib_bin = Combine(lib, "net8.0");

var build = Combine(storage, "build");

var project = Combine(user, $@"source\repos\{packageName}");
var korn_bin = Combine(project, $@"{packageName}{outPath}");
var core_bin = Combine(project, $@"{packageName}.Core{outPath}");
var tasks_bin = Combine(project, $@"{packageName}.Tasks{outPath}");
var analyzer_bin = Combine(project, $@"{packageName}.Analyzer{outPath}");
var commands_bin = Combine(project, $@"{packageName}.Commands{outPath}");

((string dir, string path) from, (string dir, string path) to)[] files = [
    ((korn_bin, $"{packageName}.dll"), (lib_bin, $"{packageName}.dll")),
    ((korn_bin, $"{packageName}.pdb"), (lib_bin, $"{packageName}.pdb")),
    ((core_bin, $"{packageName}.Core.dll"), (build, $"{packageName}.Core.dll")),
    ((Combine(user, @".nuget\packages\dnlib\4.4.0\lib\net6.0"), "dnlib.dll"), (build, "dnlib.dll")),
    ((tasks_bin, $"{packageName}.Tasks.dll"), (build, $"{packageName}.Tasks.dll")),
    ((analyzer_bin, $"{packageName}.Analyzer.dll"), (build, $"{packageName}.Analyzer.dll")),
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
.ForEach(a =>
{
    var (from, to) = a;

    if (File.Exists(to))
        File.Delete(to);
    File.Copy(from, to);
});

((string, string), (string, string))[] GetConsoleAppCopyFiles(string from, string to, string name)
    => ((string[])["dll", "exe", "runtimeconfig.json"])
    .Select(e => $"{name}.{e}")
    .Select(n => ((from, n), (to, n)))
    .ToArray();