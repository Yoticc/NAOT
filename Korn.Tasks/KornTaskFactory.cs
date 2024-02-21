public class KornTaskFactory
{
    static MethodInfo executeMethod =
        typeof(KornTask)
        .GetMethods()
        .First(m =>
            m.Name == nameof(KornTask.Execute) &&
            m.GetParameters().Length == 0
        )!;

    static FieldInfo msBuildTaskField =
        typeof(KornTask)
        .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
        .First(f => f.Name == nameof(KornTask.msBuildTask))!;

    public static void ExecuteNew<T>(MsBuildTask msBuildTask) where T : KornTask
    {
        try
        {
            var type = typeof(T);
            var instance = Activator.CreateInstance(type);

            msBuildTaskField.SetValue(instance, msBuildTask);

            try
            {
                executeMethod.Invoke(instance, []);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in KornTask->ExecuteNewTask->{typeof(T).Name}:" + ex);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception in KornTask->ExecuteNewTask for task type {typeof(T).Name}" + ex);
        }
    }
}