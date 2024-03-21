namespace Korn.Core;
public class RSPArguments
{
    RSPArguments() { }

    public List<string> Inputs;
    public string TargetObjectPath;
    public List<string> References;
    public List<RSPArgument> OtherArguments;

    public string[] Serialize() => [
        .. Inputs,
        $"-o:{TargetObjectPath}",
        .. References.Select(r => $"-r:{r}"),
        .. OtherArguments.Select(r => r.ToString())
    ];

    public string? this[string tag]
    {
        get
        {
            var found = OtherArguments.Find(a => a.Tag == tag);
            if (found is not null)
                if (found is RSPValueArgument)
                    return (found as RSPValueArgument)!.Value;

            return null;
        }
    }

    /*
     * Expected Pattern:
     * input
     * ...
     * input
     * -o
     * -r
     * ...
     * -r
    */
    public static RSPArguments Parse(string[] lines)
    {
        var args = new RSPArguments();
        args.Inputs = new();
        args.References = new();
        args.OtherArguments = new();
        int i = 0;
        for (; i < lines.Length; i++)
        {
            if (lines[i].StartsWith("-"))
                break;

            args.Inputs.Add(lines[i]);
        }

        for (; i < lines.Length; i++)
        {
            var line = lines[i];
            if (line.StartsWith("-r:"))
                args.References.Add(line.Substring(3));
            else if (line.StartsWith("-o:"))
                args.TargetObjectPath = line.Substring(3);
            else args.OtherArguments.Add(RSPArgument.Parse(line));
        }

        return args;
    }
}

public abstract class RSPArgument(string tag)
{
    public string Tag => tag;

    public static RSPArgument Parse(string str)
    {
        var splitted = str.Split(':');
        var hasValue = splitted.Length != 1;
        var doublePrefix = str.StartsWith("--");
        var tag = splitted[0].Substring(doublePrefix ? 2 : 1);
        var value = hasValue ? string.Join(':', splitted[1..^0]) : null;
        return
            doublePrefix
            ? hasValue ? new RSPDoubleValueArgument(tag, value) : new RSPDoubleArgument(tag)
            : hasValue ? new RSPSingleValueArgument(tag, value) : new RSPSingleArgument(tag);
    }
}

public abstract class RSPValueArgument(string tag, string value_) : RSPArgument(tag)
{
    public string Value { get => value_; set => value_ = value; }
}

public class RSPSingleArgument(string tag) : RSPArgument(tag)
{
    public override string ToString() => $"-{tag}";
}

public class RSPSingleValueArgument(string tag, string value) : RSPArgument(tag)
{
    public override string ToString() => $"-{tag}:{value}";
}

public class RSPDoubleArgument(string tag) : RSPArgument(tag)
{
    public override string ToString() => $"--{tag}";
}

public class RSPDoubleValueArgument(string tag, string value) : RSPArgument(tag)
{
    public override string ToString() => $"--{tag}:{value}";
}