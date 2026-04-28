using System.Text.Json;

namespace CV2_Modding_Framework_UI.Utils;

public static class FileSystemSerializer
{
    private static readonly JsonSerializerOptions Options = new()
    {
        WriteIndented = true
    };

    public static string Serialize(FileSystem fileSystem)
    {
        return JsonSerializer.Serialize(fileSystem, Options);
    }

    public static FileSystem? Deserialize(string json)
    {
        return JsonSerializer.Deserialize<FileSystem>(json, Options);
    }

    public static void SaveToFile(FileSystem fileSystem, string filePath)
    {
        string json = Serialize(fileSystem);
        File.WriteAllText(filePath, json);
    }

    public static FileSystem? LoadFromFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            return null;
        }

        string json = File.ReadAllText(filePath);
        return Deserialize(json);
    }
}
