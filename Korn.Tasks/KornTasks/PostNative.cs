using Korn.Core.Tasks;
using Korn.Core;

public class PostNative : KornTask
{
    public override void Execute()
    {
        ExecuteASMTasks();
    }

    void ExecuteASMTasks()
    {
        Globals.TaskManager.Invoke<ASMTask>([Globals.Paths.OutputNativeTargetFile]);
    }
}