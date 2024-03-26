using Korn.Core.Utils;
using Microsoft.Build.Utilities;
using System.Reflection;

namespace Korn.Core;
public class TaskManager
{
    public TaskManager(params TaskData[] tasks) => Tasks = tasks;

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
            if (typeBaseType is null)
                continue;

            foreach (var task in Tasks)
            {
                if (!task.Type.IsEquivalentTo(typeBaseType))
                    continue;

                task.Add(type);
            }
        }
    }

    public void Invoke<T>(Microsoft.Build.Utilities.Task msBuildTask, object?[]? args)
    {
        var type = typeof(T);
        foreach (var task in Tasks)
        {
            if (!task.Type.IsEquivalentTo(type))
                continue;
                        
            task.InvokeAll(msBuildTask, args);

            return;
        }

        msBuildTask.Log.Error($"Unable find task data in TaskManager for task {typeof(T).Name}");
    }

    public void InvokeFor<T>(Microsoft.Build.Utilities.Task msBuildTask, List<object?[]?> listOfArgs)
    {
        var type = typeof(T);
        foreach (var task in Tasks)
        {
            if (!task.Type.IsEquivalentTo(type))
                continue;

            foreach (var args in listOfArgs)
                task.InvokeAll(msBuildTask, args);

            return;
        }

        msBuildTask.Log.Error($"Unable find task data in TaskManager for task {typeof(T).Name}");
    }
}