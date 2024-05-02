public class KillDotnetProcessesTask() : ASMTask(10)
{
    public override void Execute(string module)
    {
        if (CoreEnv.Config.AutoCloseDotnetProcesses)
            return;

        new Thread(() =>
        {
            Thread.Sleep(1000);
            Process.GetProcessesByName("dotnet").ToList().ForEach(z => z.Kill());
        }).Start();
    }
}