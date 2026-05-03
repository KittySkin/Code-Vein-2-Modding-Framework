namespace CV2_Modding_Framework_UI.Utils;

public static class Constants
{
    // Game invariable data
    public const string AesKey = "0x6B17F169C7C367C7C277987FDAE44185ED4D9CFC2D94F012E5A8110A8FDDF227";
    // Scripts paths
    public const string DiffLog = "diff-log.txt";
    public const string CompareGameFilesBathod = "CompareGameFiles.bat";
    public const string HelperScriptsFolder = "HelperScripts";
    // Download URLS
    public const string UassetGuiDownloadUrl = "https://github.com/atenfyr/UAssetGUI/releases";
    public const string FmodelDownloadUrl = "https://fmodel.app/download";
    public const string RetocDownloadUrl = "https://github.com/trumank/retoc/releases";
    public const string DdsToolsDownloadUrl = "https://github.com/matyalatte/UE4-DDS-Tools/releases";
    public const string UnrealLocresEditorDownloadUrl = "https://github.com/Snoozeds/UnrealLocresEditor/releases";
    public const string CodeVein2LocresToolDownloadUrl = "https://ayakamods.com/mods/cv2locrestool.1548/";
}

public class AboutInfo
{
    private readonly string pVersion = Application.ProductVersion;
    private readonly string? pAppName = Application.ProductName;
    private readonly string? pAppAuthor = Application.CompanyName;
    private const string AppDescription = "A modding framework for CV2.\nIntended to made handling multiple tools easier for all of us.";
    public const string AppUrl = "https://github.com/KittySkin/Code-Vein-2-Modding-Framework";
    public string GetAboutText()
    {
        return $"{pAppName}\n" +
               $"Version {pVersion}\n" +
               $"\n" +
               $"{AppDescription}\n" +
               $"\n" +
               $"Created with love by {pAppAuthor}\n" +
               $"\n" +
               $"{AppUrl}\n" +
               $"\n";
    }
}