using System.Reflection;

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

    public void InvokeAll(object?[]? args)
    {
        foreach (var instace in Instances.OrderBy(i => i.Order))
        {
            try
            {
                ExecuteMethod.Invoke(instace.Instance, args);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in TaskData.InvokeAll->{Type.Name}->{instace.GetType().Name}: " + ex);
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
        Order = GetOrderFromILBytes(type.GetConstructors()[0].GetMethodBody().GetILAsByteArray());

        double GetOrderFromILBytes(byte[] il)
        {
            return BitConverter.ToDouble(il, il.Length - 14);
        }
    }

    public object Instance;
    public double Order;
}