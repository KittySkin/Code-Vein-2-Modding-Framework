namespace CV2_Modding_Framework_UI.Utils;

public class UnrealPakHelpers
{
    public static bool CreateModsDirectory(string path)
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
            return true;
        }
        return false;
    }
}