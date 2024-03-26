namespace Korn.Core.Tasks;
public abstract class InitTask(double Order = -1) : BaseTask
{
    public abstract void Execute();
}