namespace Korn.Core;
public static class KornLogger
{
    public static readonly FileLogger FileLogger = new();

    public static void WriteError(object obj) => WriteLine("Error", obj);

    public static void WriteWarning(object obj) => WriteLine("Warning", obj);

    public static void WriteException(object obj) => WriteLine("Exception", obj);

    public static void WriteMessage(object obj) => WriteLine("Message", obj);

    public static void ShowCriticalMessage(object obj)
    {
        WriteLine("Critical Error", obj);
        Interop.MessageBox(0, obj.ToString()!, "Korn critical message", 0);
    }

    public static void WriteLine(string tag, object obj)
    {
        var text = $"[{DateTime.Now:HH':'mm':'ss'.'fff}] [{tag}] {obj}";

        FileLogger.WriteLine(text);

        if (BaseTask.LogInstance is null)
        {
            Console.WriteLine(text);
            return;
        }

        BaseTask.LogInstance.LogMessage($"[Unknown source] {text}");
    }    
}

public class FileLogger
{
    public static Encoding Encoding = Encoding.UTF8;

    public string? Path;

    FileStream? stream;
    List<string> buffer = [];

    public void SetFile(string path)
    {
        stream = new(Path = path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        Clear();
        if (buffer.Count > 0)
        {
            foreach (var line in buffer)
                Write(line);
            buffer.Clear();
        }
    }

    public void Clear() => stream?.SetLength(0);

    public void Write(object obj)
    {
        var objString = obj.ToString()!;
        if (stream is null)
        {
            buffer.Add(objString);
            return;
        }

        var array = Encoding.GetBytes(objString);
        stream.Write(array, 0, array.Length);
        stream.Flush();
    }

    public void WriteLine(object obj)
    {
        var objString = obj + "\n";
        if (stream is null)
        {
            buffer.Add(objString);
            return;
        }

        Write(objString);
    }
}