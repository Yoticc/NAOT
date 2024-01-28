using dnlib.DotNet;

namespace Korn.Core.Tasks;
public abstract class ILInputTask(double Order = -1)
{
    public abstract void Execute(ModuleDefMD module);
}