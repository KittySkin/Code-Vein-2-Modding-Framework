using System.Diagnostics;

namespace CV2_Modding_Framework_UI.Utils;

public static class UrlUtils
{
    public static void OpenLink(string url)
    {
        Process.Start(new ProcessStartInfo
        {
            FileName = url,
            UseShellExecute = true
        });
    }
}