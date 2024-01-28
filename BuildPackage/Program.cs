var user = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

var packageId = "korn";
var packageName = "Korn";

var package = Path.Combine(user, $@".nuget\packages\{packageId}");
if (Directory.Exists(package))
    Directory.Delete(package, true);

var storage = Path.Combine(user, $@"source\repos\{packageName}\{packageName}\nuget\storage");

var lib = Path.Combine(storage, "lib");
var lib_bin = Path.Combine(lib, "net8.0");

var build = Path.Combine(storage, "build");

var project = Path.Combine(user, $@"source\repos\{packageName}");
var korn_bin = Path.Combine(project, $@"{packageName}\bin\Release\net8.0");
var core_bin = Path.Combine(project, $@"{packageName}.Core\bin\Release\net8.0");
var tasks_bin = Path.Combine(project, $@"{packageName}.Tasks\bin\Release\net8.0");
var analyzer_bin = Path.Combine(project, $@"{packageName}.Analyzer\bin\Release\net8.0");

var folders = new[] {
    storage,
    lib, lib_bin,
    build
};

((string dir, string path) from, (string dir, string path) to)[] files = [
    ((korn_bin, $"{packageName}.dll"), (lib_bin, $"{packageName}.dll")),
    ((korn_bin, $"{packageName}.pdb"), (lib_bin, $"{packageName}.pdb")),
    ((core_bin, $"{packageName}.Core.dll"), (build, $"{packageName}.Core.dll")),
    ((Path.Combine(user, @".nuget\packages\dnlib\4.3.0\lib\net6.0"), "dnlib.dll"), (build, "dnlib.dll")),
    ((tasks_bin, $"{packageName}.Tasks.dll"), (build, $"{packageName}.Tasks.dll")),
    ((analyzer_bin, $"{packageName}.Analyzer.dll"), (build, $"{packageName}.Analyzer.dll")),
];

folders.ToList().ForEach(d => Directory.CreateDirectory(d));

files
.Select(f => (from: Path.Combine(f.from.dir, f.from.path), to: Path.Combine(f.to.dir, f.to.path)))
.ToList()
.ForEach(a => {
    var (from, to) = a;

    if (File.Exists(to))
        File.Delete(to);
    File.Copy(from, to);
});

((string, string), (string, string))[] GetConsoleAppCopyFiles(string from, string to, string name)
    => new[] { "dll", "exe", "pdb", "runtimeconfig.json" }
    .Select(e => $"{name}.{e}")
    .Select(n => ((from, n), (to, n)))
    .ToArray();