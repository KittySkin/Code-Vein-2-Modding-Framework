namespace CV2_Modding_Framework_UI.Utils;

public static class UnrealPakHelpers
{
    public static void CreateModsDirectory(string path)
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
    }
}