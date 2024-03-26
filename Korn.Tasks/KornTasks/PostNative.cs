using Korn.Core.Tasks;
using Korn.Core;

class PostNative : KornTask
{
    public override void Execute()
    {
        ExecuteASMTasks();
    }

    void ExecuteASMTasks()
    {
        Globals.TaskManager.Invoke<ASMTask>(msBuildTask, [Globals.Paths.OutputNativeTargetFile]);
    }
}