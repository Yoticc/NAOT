using dnlib.DotNet;

namespace Korn.Core.Tasks;
public abstract class ILActualTask(double Order = -1)
{
    public abstract void Execute(ModuleDefMD module);
}