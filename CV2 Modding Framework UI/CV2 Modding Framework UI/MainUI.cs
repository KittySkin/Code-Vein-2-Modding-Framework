using System.Diagnostics;
using System.Security.Principal;
using CV2_Modding_Framework_UI.Utils;

namespace CV2_Modding_Framework_UI;

public partial class MainUi : Form
{
    private readonly FileSystem pFileSystem = new();
    private readonly bool pIsElevated;
    private string? pActiveModPath;
    private readonly string pAesKey = "0x6B17F169C7C367C7C277987FDAE44185ED4D9CFC2D94F012E5A8110A8FDDF227";
    
    public MainUi()
    {
        InitializeComponent();
        using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
        {
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            pIsElevated = principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
        
        pFileSystem.LoadFileSystemConfig("config.json");
        if (pFileSystem.WorkspaceDirectory != String.Empty)
        {
            workspaceLocation.Text = pFileSystem.WorkspaceDirectory;
            // Create the Mods directory if it doesn't exist
            UnrealPakHelpers.CreateModsDirectory(Path.Combine(pFileSystem.WorkspaceDirectory, "Mods"));
            UnrealPakHelpers.CreateModsDirectory(Path.Combine(pFileSystem.WorkspaceDirectory, "PackagedMods"));

            foreach (string path in Directory.EnumerateDirectories(Path.Combine(pFileSystem.WorkspaceDirectory, "Mods")))
            {
                modSelectionComboBox.Items.Add(path);
            }

            if (pFileSystem.ActiveModPath != String.Empty)
            {
                modSelectionComboBox.SelectedItem = pFileSystem.ActiveModPath;
            }
        }
        if (pFileSystem.VanillaPaksSymLinkPath != Array.Empty<string>())
        {
            sysLinkTextBox.Text = String.Join(Environment.NewLine, pFileSystem.VanillaPaksSymLinkPath);
        }
        if (pFileSystem.SymLinkDestinationDirectory != String.Empty)
        {
            textBoxSymLinkDestination.Text = pFileSystem.SymLinkDestinationDirectory;
        }
    }

    #region Settings Items
    private void UAssetGUIMenuItem_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = @"UAssetGUI executable|UAssetGUI.exe";
        openFileDialog.FilterIndex = 1;
        openFileDialog.RestoreDirectory = true;
        openFileDialog.Multiselect = false;
        
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            pFileSystem.UAssetGuiPath = openFileDialog.FileName;
            pFileSystem.SaveFileSystemConfig("config.json");
        }
    }
    private void FModelMenuItem_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = @"FModel executable|FModel.exe";
        openFileDialog.FilterIndex = 1;
        openFileDialog.RestoreDirectory = true;
        openFileDialog.Multiselect = false;
        
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            pFileSystem.FModelPath = openFileDialog.FileName;
            pFileSystem.SaveFileSystemConfig("config.json");
        }
    }
    private void RetocToolStripMenuItemClick(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = @"retoc executable|retoc.exe";
        openFileDialog.FilterIndex = 1;
        openFileDialog.RestoreDirectory = true;
        openFileDialog.Multiselect = false;
        
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            pFileSystem.RetocPath = openFileDialog.FileName;
            pFileSystem.SaveFileSystemConfig("config.json");
        }
    }
    #endregion

    #region Utilities Items
    private void unpackGameFilesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        /*
            rmdir /S /Q "D:\CodeVein2Modding\legacy"
            "D:\CodeVein2Modding\retoc\retoc.exe"
            -a 0x6B17F169C7C367C7C277987FDAE44185ED4D9CFC2D94F012E5A8110A8FDDF227 
            to-legacy -v
            "D:\CodeVein2Modding\Vanilla Paks"
            "D:\CodeVein2Modding\legacy"
         */
        if (String.IsNullOrEmpty(pFileSystem.RetocPath))
        {
            MessageBox.Show(@"Retoc is not setup. Please select its location from the Settings menu.", @"Missing Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        if (String.IsNullOrEmpty(pFileSystem.WorkspaceDirectory))
        {
            MessageBox.Show(@"Workspace directory is not setup in the, please select its location from the 'Select Active Workspace' button.", @"Missing Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        if (pFileSystem.VanillaPaksSymLinkPath == Array.Empty<string>())
        {
            MessageBox.Show(@"Vanilla Paks symlink is not setup. Please select its location and create them using the 'Create or Update SymLink'.", @"Missing Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        if (String.IsNullOrEmpty(pFileSystem.SymLinkDestinationDirectory))
        {
            MessageBox.Show(@"Vanilla Paks symlink is not setup. Please setup it properly.", @"Missing Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        string unpackedGameFilesPath = Path.Join(pFileSystem.WorkspaceDirectory, "UnpackedGameFiles");
        if (Directory.Exists(unpackedGameFilesPath))
        {
            Directory.Delete(unpackedGameFilesPath, true);
        }
        Directory.CreateDirectory(unpackedGameFilesPath);
        
        string? paksPath = pFileSystem.SymLinkDestinationDirectory;
        
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = pFileSystem.RetocPath,
            Arguments = $"-a {pAesKey} to-legacy -v \"{paksPath}\" \"{unpackedGameFilesPath}\"",
            UseShellExecute = false,
            CreateNoWindow = false
        };
        Process? retocProccess = Process.Start(startInfo);
        retocProccess?.WaitForExit();
        if (retocProccess?.ExitCode == 0)
        {
            MessageBox.Show(@"Game files successfully unpacked into legacy format.", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show(@"Failed to unpackage game files.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    #endregion
    
    #region Tool Launcher
    private void StartUAssetGuiButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(pFileSystem.UAssetGuiPath))
        {
            MessageBox.Show(@"UAssetGui is not setup. Please select its location from the Settings menu.", @"Missing Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        Process.Start(new ProcessStartInfo { FileName = pFileSystem.UAssetGuiPath, UseShellExecute = true });
    }
    private void StartFModelButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(pFileSystem.FModelPath))
        {
            MessageBox.Show(@"FModel is not setup. Please select its location from the Settings menu.", @"Missing Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        Process.Start(new ProcessStartInfo { FileName = pFileSystem.FModelPath, UseShellExecute = true });
    }
    #endregion

    #region SymLink Handling
    private void createSysLink_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = @"Pakchunk files|*.pak;*.ucas;*.utoc";
        openFileDialog.FilterIndex = 1;
        openFileDialog.RestoreDirectory = true;
        openFileDialog.Multiselect = true;

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            sysLinkTextBox.Text = openFileDialog.FileName;
            pFileSystem.VanillaPaksSymLinkPath = openFileDialog.FileNames;
            pFileSystem.SaveFileSystemConfig("config.json");
        }
    }
    private void buttonBrowseSymLinkDestination_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        
        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        {
            textBoxSymLinkDestination.Text = folderBrowserDialog.SelectedPath;
            pFileSystem.SymLinkDestinationDirectory = folderBrowserDialog.SelectedPath;
            pFileSystem.SaveFileSystemConfig("config.json");
        }
    }
    private void buttonCreateSymLink_Click(object sender, EventArgs e)
    {
        if (pIsElevated == false)
        {
            MessageBox.Show(@"This operation requires elevated privileges. Please run the application as administrator.", @"Permission Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            foreach (string path in pFileSystem.VanillaPaksSymLinkPath)
            {
                File.CreateSymbolicLink(Path.Combine(pFileSystem.SymLinkDestinationDirectory, Path.GetFileName(path)), path);
            }
            MessageBox.Show(@"Symbolic links created successfully.", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (AccessViolationException ex)
        {
            MessageBox.Show(@"Failed to create symbolic links. Please ensure you have sufficient permissions and try again.", $@"Error {ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
    #endregion
    
    private void browseWorkspaceLocation_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        
        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        {
            workspaceLocation.Text = folderBrowserDialog.SelectedPath;
            pFileSystem.WorkspaceDirectory = folderBrowserDialog.SelectedPath;
            pFileSystem.SaveFileSystemConfig("config.json");
        }
    }

    #region Mod Handling
    private void packageModButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(pFileSystem.RetocPath))
        {
            MessageBox.Show(@"Retoc is not setup in the, please select its location from the Settings bar menu.", @"Missing Retoc Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        if (string.IsNullOrEmpty(pFileSystem.WorkspaceDirectory))
        {
            MessageBox.Show(@"Workspace directory is not setup in the, please select its location from the 'Select Active Workspace' button.", @"Missing Workspace Directory", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        if (string.IsNullOrEmpty(pFileSystem.ActiveModPath))
        {
            MessageBox.Show(@"Active mod is not setup in the, please select an active mod from the mod dropdown menu.", @"Missing Active Mod", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        string modName = Path.GetFileName(pFileSystem.ActiveModPath);
        string activeModPath = Path.Join(pFileSystem.ActiveModPath, "src");
        string packagedModDirectoryPath = Path.Join(pFileSystem.WorkspaceDirectory, "PackagedMods", modName);
        string packagedModPath = Path.Join(pFileSystem.WorkspaceDirectory, "PackagedMods", modName, modName + "_P.utoc");
        if (!Directory.Exists(packagedModDirectoryPath))
        {
            Directory.CreateDirectory(packagedModDirectoryPath);
        }
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = pFileSystem.RetocPath,
            Arguments = $"to-zen -v \"{activeModPath}\" --version UE5_4 \"{packagedModPath}\"",
            UseShellExecute = false,
            CreateNoWindow = false
        };
        Process? retocProccess = Process.Start(startInfo);
        retocProccess?.WaitForExit();
        if (retocProccess?.ExitCode == 0)
        {
            MessageBox.Show(@"Packaged mod created successfully.", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show(@"Failed to create packaged mod.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void modSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (modSelectionComboBox.SelectedItem == null)
            return;
        
        pActiveModPath = modSelectionComboBox.SelectedItem.ToString();

        if (pActiveModPath != null)
        {
            pFileSystem.ActiveModPath = pActiveModPath;
            pFileSystem.SaveFileSystemConfig("config.json");
        }
    }
    #endregion
}