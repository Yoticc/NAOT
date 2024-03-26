using Korn.Core.Utils;

class KornTaskFactory
{
    static readonly MethodInfo executeMethod =
        typeof(KornTask)
        .GetMethods()
        .First(method =>
            method.Name == nameof(KornTask.Execute) &&
            method.GetParameters().Length == 0
        )!;

    static readonly FieldInfo msBuildTaskField =
        typeof(KornTask)
        .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
        .First(field => field.Name == nameof(KornTask.msBuildTask))!;

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
                msBuildTask.Log.Error($"Exception in KornTask->ExecuteNewTask->{typeof(T).Name}:" + ex);
            }
        }
        catch (Exception ex)
        {
            msBuildTask.Log.Error($"Exception in KornTask->ExecuteNewTask for task type {typeof(T).Name}" + ex);
        }
    }
}