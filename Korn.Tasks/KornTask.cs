abstract class KornTask
{
    public abstract void Execute();

    protected private string this[string key] => BuildEngine.GetEnvVar(key);

    #region Task implementation mirror
    internal MsBuildTask msBuildTask;
    public IBuildEngine BuildEngine => msBuildTask.BuildEngine;
    public IBuildEngine2 BuildEngine2 => msBuildTask.BuildEngine2;
    public IBuildEngine3 BuildEngine3 => msBuildTask.BuildEngine3;
    public IBuildEngine4 BuildEngine4 => msBuildTask.BuildEngine4;
    public IBuildEngine5 BuildEngine5 => msBuildTask.BuildEngine5;
    public IBuildEngine6 BuildEngine6 => msBuildTask.BuildEngine6;
    public IBuildEngine7 BuildEngine7 => msBuildTask.BuildEngine7;
    public IBuildEngine8 BuildEngine8 => msBuildTask.BuildEngine8;
    public IBuildEngine9 BuildEngine9 => msBuildTask.BuildEngine9;
    public ITaskHost HostObject => msBuildTask.HostObject;
    public TaskLoggingHelper Log => msBuildTask.Log;
    #endregion
}