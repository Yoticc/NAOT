class ConfigPresentation
{
    public AddictionalBuildArguments? AddictionalBuildArguments { get; set; }
}

class AddictionalBuildArguments
{
    public bool? InvariantGlobalization { get; set; } = true;
    public bool? StackTraceSupport { get; set; } = true;
    public bool? UseSystemResourceKeys { get; set; } = true;
    public bool? GenerateLogFile = false;
}