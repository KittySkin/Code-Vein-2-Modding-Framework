using System.Text.Json;

namespace CV2_Modding_Framework_UI.Utils;

public class ModProjectSerializer
{
    private static readonly JsonSerializerOptions Options = new()
    {
        WriteIndented = true
    };

    public static string Serialize(ModProject modProject)
    {
        return JsonSerializer.Serialize(modProject, Options);
    }

    public static ModProject? Deserialize(string json)
    {
        return JsonSerializer.Deserialize<ModProject>(json, Options);
    }

    public static void SaveToFile(ModProject modProject, string filePath)
    {
        string json = Serialize(modProject);
        File.WriteAllText(filePath, json);
    }

    public static ModProject? LoadFromFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            return null;
        }

        string json = File.ReadAllText(filePath);
        return Deserialize(json);
    }
}