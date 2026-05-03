using System.Reflection;
using System.Text.Json.Serialization;
namespace CV2_Modding_Framework_UI.Utils;

[Serializable]
public class FileSystem
{
    #region Workspace and Modding Paths
    [JsonPropertyName("WorkspaceDirectory")]
    public string WorkspaceDirectory
    {
        get
        {
            if (field == null)
            {
                return String.Empty;
            }
            return field;
        }
        set
        {
            if (Directory.Exists(value) && field != value)
            {
                field = value;
            }
        }
    }
    
    [JsonPropertyName("ActiveModPath")]
    public string ActiveModPath
    {
        get
        {
            if (field == null)
            {
                return String.Empty;
            }
            return field;
        }
        set
        {
            if (Directory.Exists(value) && field != value)
            {
                field = value;
            }
        }
    }
    
    [JsonPropertyName("GameModsFolderPath")]
    public string GameModsFolderPath
    {
        get
        {
            if (field == null)
            {
                return String.Empty;
            }
            return field;
        }
        set
        {
            if (Directory.Exists(value) && field != value)
            {
                field = value;
            }
        }
    }
    #endregion

    #region SymLinks Paths
    [JsonPropertyName("VanillaPaksSymLinkPath")]
    public string[] VanillaPaksSymLinkPath
    {
        get
        {
            if (field == null)
            {
                return Array.Empty<string>();
            }
            return field;
        }
        set
        {
            if (value.All(File.Exists) && !value.SequenceEqual(field ?? Array.Empty<string>()))
            {
                field = value;
            }
        }
    }
    
    [JsonPropertyName("SymLinkDestinationDirectory")]
    public string SymLinkDestinationDirectory
    {
        get
        {
            if (field == null)
            {
                return String.Empty;
            }
            return field;
        }
        set
        {
            if (Directory.Exists(value) && field != value)
            {
                field = value;
            }
        }
    }
    #endregion
    
    #region Tools Paths
    [JsonPropertyName("UAssetGuiPath")]
    public string UAssetGuiPath
    {
        get
        {
            if (field == null)
            {
                return String.Empty;
            }
            return field;
        }
        set
        {
            if (File.Exists(value) && field != value)
            {
                field = value;
            }
        }
    }
    
    [JsonPropertyName("FModelPath")]
    public string FModelPath
    {
        get
        {
            if (field == null)
            {
                return String.Empty;
            }
            return field;
        }
        set
        {
            if (File.Exists(value) && field != value)
            {
                field = value;
            }
        }
    }
    
    [JsonPropertyName("RetocPath")]
    public string RetocPath
    {
        get
        {
            if (field == null)
            {
                return String.Empty;
            }
            return field;
        }
        set
        {
            if (File.Exists(value) && field != value)
            {
                field = value;
            }
        }
    }
    
    [JsonPropertyName("DdsToolsPath")]
    public string DdsToolsPath
    {
        get
        {
            if (field == null)
            {
                return String.Empty;
            }
            return field;
        }
        set
        {
            if (File.Exists(value) && field != value)
            {
                field = value;
            }
        }
    }
    
    [JsonPropertyName("UnrealLocresEditorPath")]
    public string UnrealLocresEditorPath
    {
        get
        {
            if (field == null)
            {
                return String.Empty;
            }
            return field;
        }
        set
        {
            if (File.Exists(value) && field != value)
            {
                field = value;
            }
        }
    }
    
    [JsonPropertyName("CV2LocresToolPath")]
    public string CV2LocresToolPath
    {
        get
        {
            if (field == null)
            {
                return String.Empty;
            }
            return field;
        }
        set
        {
            if (File.Exists(value) && field != value)
            {
                field = value;
            }
        }
    }
    #endregion

    #region File System Helpers
    public void DeleteActiveMod()
    {
        if (!String.IsNullOrEmpty(ActiveModPath) && Directory.Exists(ActiveModPath))
        {
            Directory.Delete(ActiveModPath, true);
        }
        ActiveModPath = String.Empty;
    }
    #endregion

    #region Serialization Methods
    public void SaveFileSystemConfig()
    {
        FileSystemSerializer.SaveToFile(this, "config.json");
    }
    public void LoadFileSystemConfig(string filePath)
    {
        if (File.Exists(filePath))
        {
            FileSystem? loadedFileSystemSettings = FileSystemSerializer.LoadFromFile(filePath);
            if (loadedFileSystemSettings != null)
            {
                PropertyInfo[] properties = typeof(FileSystem).GetProperties(BindingFlags.Public | BindingFlags.Instance);

                foreach (PropertyInfo property in properties)
                {
                    if (property.CanRead && property.CanWrite)
                    {
                        object? value = property.GetValue(loadedFileSystemSettings);
                        property.SetValue(this, value);
                    }
                }
            }
        }
    }
    #endregion
}