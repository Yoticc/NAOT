using System.Diagnostics;

namespace Korn.Core;
public class TaskData
{
    public TaskData(Type type)
    {
        Type = type;
        ExecuteMethod = Type.GetMethods().First();
        Instances = new();
    }

    public readonly Type Type;
    public readonly MethodInfo ExecuteMethod;
    public readonly List<TaskInstance> Instances;

    public void Add(Type type) => Instances.Add(new(type));

    public void InvokeAll(Microsoft.Build.Utilities.Task msBuildTask, object?[]? args)
    {
        foreach (var instance in Instances.OrderBy(i => i.Order))
        {
            try
            {
                (instance.Instance as BaseTask)!.Log = msBuildTask.Log;

                var stopwatch = new Stopwatch();
                stopwatch.Start();
                ExecuteMethod.Invoke(instance.Instance, args);
                stopwatch.Stop();
                KornLogger.FileLogger.WriteLine($"[{DateTime.Now:HH':'mm':'ss'.'fff}] [Info] Task {Type.Name}->{instance.Instance.GetType().Name}[{instance.Order}] finished for {stopwatch.ElapsedMilliseconds}ms");
            }
            catch (Exception ex)
            {
                KornLogger.WriteException($"Core:TaskData->InvokeAll: Exception in TaskData.InvokeAll->{Type.Name}->{instance.Instance.GetType().Name}: " + ex);
            }
        }
    }
}

public class TaskData<T>() : TaskData(typeof(T));

public class TaskInstance
{
    public TaskInstance(Type type)
    {
        Instance = Activator.CreateInstance(type)!;
        Order = GetOrderFromILBytes(type.GetConstructors()[0].GetMethodBody()!.GetILAsByteArray()!);

        double GetOrderFromILBytes(byte[] il) => BitConverter.ToDouble(il, il.Length - 14);
    }

    public object Instance;
    public double Order;
}