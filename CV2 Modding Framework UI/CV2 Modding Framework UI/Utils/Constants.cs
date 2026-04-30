namespace CV2_Modding_Framework_UI.Utils;

public static class Constants
{
    public const string VERSION = "1.0.0";
    public const string APP_NAME = "Code Vein 2 Modding Framework";
    public const string APP_AUTHOR = "KittySkin";
    public const string APP_URL = "https://github.com/KittySkin/Code-Vein-2-Modding-Framework";
    public const string APP_DESCRIPTION = "A modding framework for CV2.\nIntended to made handling multiple tools easier for all of us.";
    public const string AES_KEY = "0x6B17F169C7C367C7C277987FDAE44185ED4D9CFC2D94F012E5A8110A8FDDF227";
    
    public static string GetAboutText()
    {
        return $"{APP_NAME}\n" +
               $"Version {VERSION}\n" +
               $"\n" +
               $"{APP_DESCRIPTION}\n" +
               $"\n" +
               $"Created with love by {APP_AUTHOR}\n" +
               $"\n" +
               $"{APP_URL}\n" +
               $"\n";
    }
}