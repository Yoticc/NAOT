namespace Korn.Core.Tasks;
public abstract class ASMTask(double Order = -1)
{
    public abstract void Execute(string module);
}