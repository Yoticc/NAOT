namespace Korn.Core.Tasks;
public abstract class ILInputTask(double Order = -1) : BaseTask
{
    public abstract void Execute(ModuleDefMD module);
}