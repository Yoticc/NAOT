using dnlib.DotNet.Pdb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Korn.Core;
public class TaskManager
{
    public TaskManager(params TaskData[] tasks)
    {
        Tasks = tasks;
    }

    public TaskManager(params Type[] types)
    {
        Tasks = new TaskData[types.Length];
        for (int i = 0; i < types.Length; i++)
            Tasks[i] = new(types[i]);
    }

    public readonly TaskData[] Tasks;

    public void AddExtractedTasks(Assembly assembly)
    {
        foreach (var type in assembly.GetTypes())
        {
            var typeBaseType = type.BaseType;
            if (typeBaseType == null)
                continue;

            foreach (var task in Tasks)
            {
                if (!task.Type.IsEquivalentTo(typeBaseType))
                    continue;

                task.Add(type);
            }
        }
    }

    public void Invoke<T>(object?[]? args)
    {
        var type = typeof(T);
        foreach (var task in Tasks)
        {
            if (!task.Type.IsEquivalentTo(type))
                continue;

            task.InvokeAll(args);

            return;
        }

        Console.WriteLine($"Unable find task data in TaskManager for task {typeof(T).Name}");
    }

    public void InvokeFor<T>(List<object?[]?> listOfArgs)
    {
        var type = typeof(T);
        foreach (var task in Tasks)
        {
            if (!task.Type.IsEquivalentTo(type))
                continue;

            foreach (var args in listOfArgs)
                task.InvokeAll(args);

            return;
        }

        Console.WriteLine($"Unable find task data in TaskManager for task {typeof(T).Name}");
    }
}