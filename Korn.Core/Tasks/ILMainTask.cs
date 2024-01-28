using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korn.Core.Tasks;
public abstract class ILMainTask(double Order = -1)
{
    public abstract void Execute(ModuleDefMD module);
}