class PostNative : KornTask
{
    public override void Execute()
    {
        ExecuteASMTasks();
    }

    void ExecuteASMTasks()
    {
        CoreEnv.TaskManager.Invoke<ASMTask>(msBuildTask, [CoreEnv.Paths.OutputNativeTargetFile]);
    }
}