using System.Text.Json.Serialization;

namespace CV2_Modding_Framework_UI.Utils;

public class FolderStructureItem
{
    [JsonPropertyName("Name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("SubFolders")]
    public List<FolderStructureItem> SubFolders { get; set; } = new();
}
