namespace Korn.Core.Tasks;
public abstract class PreIlcTask(double Order = -1) : BaseTask
{
    public abstract void Execute();
}
