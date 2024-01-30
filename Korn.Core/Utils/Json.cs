using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korn.Core.Utils;
public static class Json
{
    public static JsonSerializerSettings Settings = new()
    {
        NullValueHandling = NullValueHandling.Ignore,
        Formatting = Formatting.Indented,
    };

    public static string Serial(object? value) => JsonConvert.SerializeObject(value, Settings);
    public static T? Deserial<T>(string data) => JsonConvert.DeserializeObject<T>(data);

    public static void FileSerial(string path, object? value) => File.WriteAllText(path, Serial(value));
    public static T? FileDeserial<T>(string path) => Deserial<T>(File.ReadAllText(path));

    public static T? FileLoad<T>(string path)
    {
        if (!File.Exists(path))
            FileSerial(
                path,
                Activator.CreateInstance(typeof(T))
            );

        return FileDeserial<T>(path);
    }
}