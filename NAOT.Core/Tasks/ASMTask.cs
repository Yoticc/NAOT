using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAOT.Core.Tasks;
public abstract class ASMTask
{
    public abstract void Execute(string exec);
}