using NAOT.Core;
using NAOT.Core.Tasks;
using System.Security;

public class AfterIlcCompile : Microsoft.Build.Utilities.Task
{
    public override bool Execute()
    {
        try
        {
            ExecuteASMTasks();
        }
        catch (Exception ex) { Console.WriteLine($"Exception in AfterIlcCompile: " + ex); }

        return true;
    }

    void ExecuteASMTasks()
    {
        var asmExecute = typeof(ASMTask).GetMethods().First();

        foreach (var task in Globals.ASMTaskInstances)
        {
            try
            {
                asmExecute.Invoke(task, null);
            }
            catch (Exception ex) { Console.WriteLine($"Exception in AfterIlcCompile->{task.GetType().Name}: " + ex); }
        }
    }
}