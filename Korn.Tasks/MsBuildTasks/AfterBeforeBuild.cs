public class AfterBeforeBuild : MsBuildTask
{
    public override bool Execute()
    {
        KornTaskFactory.ExecuteNew<PreBuild>(this);
        return true;
    }    
}