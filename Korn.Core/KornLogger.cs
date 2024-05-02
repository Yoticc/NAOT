namespace Korn.Core;
public static class KornLogger
{
    static readonly string logFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "korn.tasks.log.txt");
    public static readonly FileLogger FileLogger = new();

    static KornLogger()
    {
        FileLogger.SetFile(logFilePath);
        FileLogger.Clear();
    }

    public static void WriteLine(object obj)
    {
        FileLogger.WriteLine($"{obj}");

        if (BaseTask.LogInstance is null)
        {
            Console.WriteLine(obj);
            return;
        }

        BaseTask.LogInstance.LogMessage($"[Unknown source] {obj}");
    }
}

public class FileLogger
{
    public static Encoding Encoding = Encoding.UTF8;

    public string? Path;

    FileStream? stream;

    public void SetFile(string path) => stream = new(Path = path, FileMode.OpenOrCreate, FileAccess.ReadWrite);

    public void Clear() => stream?.SetLength(0);

    public void Write(object obj)
    {
        if (stream is null)
            return;

        var buffer = Encoding.GetBytes(obj.ToString());
        stream.Write(buffer, 0, buffer.Length);
        stream.Flush();
    }

    public void WriteLine(object obj)
    {
        Write(obj);
        Write('\n');
    }
}