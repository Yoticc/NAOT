﻿namespace Korn.Core.Tasks;
public abstract class ILMainTask(double Order = -1) : BaseTask
{
    public abstract void Execute(ModuleDefMD module);
}