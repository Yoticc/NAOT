using NAOT.Core;
using NAOT.Core.Tasks;
using System.Security;

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
        var asmExecute = typeof(ASMTask).GetMethods().First();

        foreach (var instance in Globals.ASMTaskInstances)
        {
            var task = instance.Task;
            try
            {
                asmExecute.Invoke(task, [Globals.OutputNativeFile]);
            }
            catch (Exception ex) { Console.WriteLine($"Exception in AfterCopyAotSymbols->{task.GetType().Name}: " + ex); }
        }
    }
}