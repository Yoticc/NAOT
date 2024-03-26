using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConfigPresentation
{
    public AddictionalBuildArguments? AddictionalBuildArguments { get; set; }
}

class AddictionalBuildArguments
{
    public bool? InvariantGlobalization { get; set; } = true;
    public bool? StackTraceSupport { get; set; } = true;
    public bool? UseSystemResourceKeys { get; set; } = true;
}