public class AfterCopyAotSymbols : MsBuildTask
{
    public override bool Execute()
    {
        KornTaskFactory.ExecuteNew<PostNative>(this);
        return true;
    }
}