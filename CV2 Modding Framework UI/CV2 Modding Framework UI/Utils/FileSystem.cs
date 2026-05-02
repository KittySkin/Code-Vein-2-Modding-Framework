using System.Text.Json.Serialization;
namespace CV2_Modding_Framework_UI.Utils;

[Serializable]
public class FileSystem
{
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
    
    public void DeleteActiveMod()
    {
        if (!String.IsNullOrEmpty(ActiveModPath) && Directory.Exists(ActiveModPath))
        {
            Directory.Delete(ActiveModPath, true);
        }
        ActiveModPath = String.Empty;
    }
    
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
                WorkspaceDirectory = loadedFileSystemSettings.WorkspaceDirectory;
                UAssetGuiPath = loadedFileSystemSettings.UAssetGuiPath;
                FModelPath = loadedFileSystemSettings.FModelPath;
                VanillaPaksSymLinkPath = loadedFileSystemSettings.VanillaPaksSymLinkPath;
                SymLinkDestinationDirectory = loadedFileSystemSettings.SymLinkDestinationDirectory;
                ActiveModPath = loadedFileSystemSettings.ActiveModPath;
                RetocPath = loadedFileSystemSettings.RetocPath;
                DdsToolsPath = loadedFileSystemSettings.DdsToolsPath;
                UnrealLocresEditorPath = loadedFileSystemSettings.UnrealLocresEditorPath;
            }
        }
    }
}