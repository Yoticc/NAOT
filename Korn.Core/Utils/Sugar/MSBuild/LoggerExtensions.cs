using Microsoft.Build.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korn.Core.Utils;
public static partial class SugarExtensions
{
    public static void Error(this TaskLoggingHelper log, string text)
    {
        WriteLine("Error", text);
        log.LogError(text);
    }

    public static void Warning(this TaskLoggingHelper log, string text)
    {
        WriteLine("Warning", text);
        log.LogWarning(text);
    }

    public static void Message(this TaskLoggingHelper log, string text)
    {
        WriteLine("Message", text);
        log.LogMessage(text);
    }

    static void WriteLine(string tag, string text) => KornLogger.FileLogger.WriteLine($"[{tag}] {text}");
}