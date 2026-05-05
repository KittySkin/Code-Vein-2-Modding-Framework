using System.Reflection;
using System.Text.Json.Serialization;

namespace CV2_Modding_Framework_UI.Utils;

public class ModProject
{
    #region Properties

    [JsonPropertyName("Name")] public string? Name { get; set; }

    [JsonPropertyName("Description")] public string? Description { get; set; }

    [JsonPropertyName("Version")] public string? Version { get; set; }

    [JsonPropertyName("SrcPath")] public string? SrcPath { get; set; }

    #endregion

    #region Serialization Methods

    public void SaveModProjectConfig(string modProjectPath)
    {
        ModProjectSerializer.SaveToFile(this, modProjectPath + Constants.ModProjectExtension);
    }

    public void LoadModProjectConfig(string filePath)
    {
        if (File.Exists(filePath + Constants.ModProjectExtension))
        {
            filePath += Constants.ModProjectExtension;
            ModProject? loadedModProjectSettings = ModProjectSerializer.LoadFromFile(filePath);
            if (loadedModProjectSettings != null)
            {
                PropertyInfo[] properties =
                    typeof(ModProject).GetProperties(BindingFlags.Public | BindingFlags.Instance);

                foreach (PropertyInfo property in properties)
                {
                    if (property.CanRead && property.CanWrite)
                    {
                        object? value = property.GetValue(loadedModProjectSettings);
                        property.SetValue(this, value);
                    }
                }
            }
        }
    }

    #endregion
}