public class AfterWriteIlcRspFileForCompilation : MsBuildTask
{
    public override bool Execute()
    {
        KornTaskFactory.ExecuteNew<PreNative>(this);
        return true;
    }
}