namespace Korn.Core.Utils;
public static partial class SugarExtensions
{
    const BindingFlags bindingFlags = BindingFlags.NonPublic | BindingFlags.Instance;

    public static IEnumerable<string> GetAllKeyValueEnv(this IBuildEngine buildEngine)
    {
        var projectInstance = GetProjectInstance(buildEngine);

        return
            projectInstance.Items
            .Select(i => $"{i.ItemType}: {i.EvaluatedInclude}")
            .Concat(
                projectInstance.Properties
                .Select(i => $"{i.Name}: {i.EvaluatedValue}")
            );
    }

    public static IEnumerable<string> GetEnvVars(this IBuildEngine buildEngine, string key)
    {
        var projectInstance = GetProjectInstance(buildEngine);

        var items =
            projectInstance.Items
            .Where(x => string.Equals(x.ItemType, key, StringComparison.InvariantCultureIgnoreCase))
            .ToList();

        if (items.Count > 0)
            return items.Select(x => x.EvaluatedInclude);

        var properties =
            projectInstance.Properties
            .Where(x => string.Equals(x.Name, key, StringComparison.InvariantCultureIgnoreCase))
            .ToList();

        if (properties.Count > 0)
            return properties.Select(x => x.EvaluatedValue);
        else
            throw new Exception(string.Format("Could not extract from '{0}' environmental variables.", key));
    }

    public static string GetEnvVar(this IBuildEngine buildEngine, string key) => buildEngine.GetEnvVars(key).First();

    static ProjectInstance GetProjectInstance(IBuildEngine buildEngine)
    {
        var buildEngineType = buildEngine.GetType();

        var targetBuilderCallbackField = buildEngineType.GetField("_targetBuilderCallback", bindingFlags);
        if (targetBuilderCallbackField is null)
            throw new Exception("Could not extract targetBuilderCallback from " + buildEngineType.FullName);

        var targetBuilderCallback = targetBuilderCallbackField.GetValue(buildEngine);
        var targetCallbackType = targetBuilderCallback!.GetType();
        var projectInstanceField = targetCallbackType.GetField("_projectInstance", bindingFlags);
        if (projectInstanceField is null)
            throw new Exception("Could not extract projectInstance from " + targetCallbackType.FullName);

        return (projectInstanceField.GetValue(targetBuilderCallback) as ProjectInstance)!;
    }
}