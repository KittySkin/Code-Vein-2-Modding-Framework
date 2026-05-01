using System.Diagnostics;

namespace CV2_Modding_Framework_UI.Utils;

public class UnrealPakHelpers
{
    public static void CreateModsDirectory(string path)
    {
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
    }
    public static async Task DeleteDirectoriesAsync(string path, ToolStripStatusLabel currentToolStatusStripStatusLabel)
    {
        await Task.Run(() =>
        {
            if (Directory.Exists(path))
            {
                currentToolStatusStripStatusLabel.Text = @"Deleting old unpacked game files...";
                Directory.Delete(path, true);
            }
        });
        
        while (Directory.Exists(path))
            await Task.Delay(100);
    }
    public static async Task UnpackGameFilesAsync(ProcessStartInfo startInfo, ToolStripStatusLabel currentToolStatusStripStatusLabel)
    {
        using Process? process = Process.Start(startInfo);
    
        if (process != null)
        {
            await process.WaitForExitAsync();
            if (process.ExitCode != 0)
            {
                currentToolStatusStripStatusLabel.Text = @"Failed to unpack game files.";
                MessageBox.Show(@"Failed to unpack game files.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            currentToolStatusStripStatusLabel.Text = @"Game files unpacked successfully!";
        }
    }
    public static async Task PackGameFilesAsync(ProcessStartInfo startInfo, ToolStripStatusLabel currentToolStatusStripStatusLabel)
    {
        using Process? process = Process.Start(startInfo);

        if (process != null)
        {
            await process.WaitForExitAsync();
            if (process.ExitCode != 0)
            {
                currentToolStatusStripStatusLabel.Text = @"Failed to package mod files.";
                MessageBox.Show(@"Failed to package mod files.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            currentToolStatusStripStatusLabel.Text = @"Mod files packaged successfully!";
        }
    }
}