namespace Korn.Core.Tasks;
public class BaseTask
{
    [AllowNull] TaskLoggingHelper log;
    public TaskLoggingHelper Log { get => log; set => LogInstance = log = value; }

    public static TaskLoggingHelper? LogInstance;
}

/*
 * Scheme:
 * -InitTask                called after build has started
 * -ILTask                  uses for all IL dll's
 * --ILInputTask            uses for all non-bcl dll's
 * ---ILMainTask            uses for target dll
 * -PreIlcTask              called after IL part ended. Before calling ilc
 * -ASMTask                 uses for output native dll
 * 
 * Arguments:
 * -Order:
 * --Default: -1
 * --The more, the bigger priority of task and the later it will be called
*/