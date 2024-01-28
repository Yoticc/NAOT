using Korn.Core;
using Korn.Core.Tasks;

public class AfterCopyAotSymbols : Microsoft.Build.Utilities.Task
{
    public override bool Execute()
    {
        try
        {
            ExecuteASMTasks();
        }
        catch (Exception ex) { Console.WriteLine($"Exception in AfterCopyAotSymbols: " + ex); }

        return true;
    }

    void ExecuteASMTasks()
    {
        Globals.TaskManager.Invoke<ASMTask>([Globals.Paths.OutputNativeTargetFile]);
    }
}