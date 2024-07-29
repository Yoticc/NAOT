class PostNative : KornTask
{
    public override void Execute()
    {
        ExecuteCascadeWithLogging(ExecuteASMTasks);
    }

    void ExecuteASMTasks()
    {
        CoreEnv.TaskManager.Invoke<ASMTask>(msBuildTask, [Paths.GetOutputNativeTargetFile()]);
    }
}