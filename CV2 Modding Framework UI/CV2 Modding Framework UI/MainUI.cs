using System.Diagnostics;
using System.Security.Principal;
using CV2_Modding_Framework_UI.Utils;

namespace CV2_Modding_Framework_UI;

public partial class MainUi : Form
{
    private readonly FileSystem pFileSystem = new();
    private readonly bool pIsElevated;
    private string? pActiveModPath;
    private string? pModsDirectory;
    private string? pPackagedModsDirectory;
    
    public MainUi()
    {
        InitializeComponent();
        using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
        {
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            pIsElevated = principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        currentToolStatusStripStatusLabel.Text = @"Loading in progress...";
        pFileSystem.LoadFileSystemConfig("config.json");
        if (pFileSystem.WorkspaceDirectory != String.Empty)
        {
            currentToolStatusStripStatusLabel.Text = @"Loading workspace...";
            workspaceLocation.Text = pFileSystem.WorkspaceDirectory;
            // Create the Mods directory if it doesn't exist
            currentToolStatusStripStatusLabel.Text = @"Checking workspace compliance...";
            pModsDirectory = Path.Combine(pFileSystem.WorkspaceDirectory, "Mods");
            UnrealPakHelpers.CreateModsDirectory(pModsDirectory);
            pPackagedModsDirectory = Path.Combine(pFileSystem.WorkspaceDirectory, "PackagedMods");
            UnrealPakHelpers.CreateModsDirectory(pPackagedModsDirectory);
            
            currentToolStatusStripStatusLabel.Text = @"Loading mods...";
            foreach (string path in Directory.EnumerateDirectories(pModsDirectory))
            {
                modSelectionComboBox.Items.Add(path);
            }
            currentToolStatusStripStatusLabel.Text = @"Mods loaded!";
            if (pFileSystem.ActiveModPath != String.Empty)
            {
                modSelectionComboBox.SelectedItem = pFileSystem.ActiveModPath;
                currentToolStatusStripStatusLabel.Text = @"Active mod selected!";
            }
        }
        currentToolStatusStripStatusLabel.Text = @"Loading SymLink information...";
        if (pFileSystem.VanillaPaksSymLinkPath != Array.Empty<string>())
        {
            sysLinkTextBox.Text = String.Join(Environment.NewLine, pFileSystem.VanillaPaksSymLinkPath);
            currentToolStatusStripStatusLabel.Text = @"Vanilla Paks symlink loaded!";
        }
        if (pFileSystem.SymLinkDestinationDirectory != String.Empty)
        {
            textBoxSymLinkDestination.Text = pFileSystem.SymLinkDestinationDirectory;
            currentToolStatusStripStatusLabel.Text = @"SymLink destination loaded!";
        }
        currentToolStatusStripStatusLabel.Text = @"Tool loaded successfully! Happy modding!";
    }

    #region Menu Strip Items
    // Settings
    private void UAssetGUIMenuItem_Click(object sender, EventArgs e)
    {
        currentToolStatusStripStatusLabel.Text = @"Selecting UAssetGUI executable path...";
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = @"UAssetGUI executable|UAssetGUI.exe";
        openFileDialog.FilterIndex = 1;
        openFileDialog.RestoreDirectory = true;
        openFileDialog.Multiselect = false;
        
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            pFileSystem.UAssetGuiPath = openFileDialog.FileName;
            pFileSystem.SaveFileSystemConfig("config.json");
            currentToolStatusStripStatusLabel.Text = @"UAssetGUI executable path selected!";
        }
    }
    private void FModelMenuItem_Click(object sender, EventArgs e)
    {
        currentToolStatusStripStatusLabel.Text = @"Selecting FModel executable path...";
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = @"FModel executable|FModel.exe";
        openFileDialog.FilterIndex = 1;
        openFileDialog.RestoreDirectory = true;
        openFileDialog.Multiselect = false;
        
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            pFileSystem.FModelPath = openFileDialog.FileName;
            pFileSystem.SaveFileSystemConfig("config.json");
            currentToolStatusStripStatusLabel.Text = @"FModel executable path selected!";
        }
    }
    private void RetocToolStripMenuItemClick(object sender, EventArgs e)
    {
        currentToolStatusStripStatusLabel.Text = @"Selecting retoc executable path...";
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = @"retoc executable|retoc.exe";
        openFileDialog.FilterIndex = 1;
        openFileDialog.RestoreDirectory = true;
        openFileDialog.Multiselect = false;
        
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            pFileSystem.RetocPath = openFileDialog.FileName;
            pFileSystem.SaveFileSystemConfig("config.json");
            currentToolStatusStripStatusLabel.Text = @"retoc executable path selected!";
        }
    }
    private void DDSToolsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        currentToolStatusStripStatusLabel.Text = @"Selecting DDS Tools executable path...";
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = @"DDS Tools executable|GUI.exe";
        openFileDialog.FilterIndex = 1;
        openFileDialog.RestoreDirectory = true;
        openFileDialog.Multiselect = false;
        
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            pFileSystem.DdsToolsPath = openFileDialog.FileName;
            pFileSystem.SaveFileSystemConfig("config.json");
            currentToolStatusStripStatusLabel.Text = @"DDS Tools executable path selected!";
        }
    }
    // Utilities
    private async void unpackGameFilesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        currentToolStatusStripStatusLabel.Text = @"Checking for missing paths before unpacking game files...";
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
        currentToolStatusStripStatusLabel.Text = @"All checks passed!";
        string unpackedGameFilesPath = Path.Join(pFileSystem.WorkspaceDirectory, "UnpackedGameFiles");
        
        await UnrealPakHelpers.DeleteDirectoriesAsync(unpackedGameFilesPath, currentToolStatusStripStatusLabel);
        
        Directory.CreateDirectory(unpackedGameFilesPath);
        currentToolStatusStripStatusLabel.Text = @"Files deleted! Preparing to unpack game files...";
        
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = pFileSystem.RetocPath,
            Arguments = $"-a {Constants.AES_KEY} to-legacy -v \"{pFileSystem.SymLinkDestinationDirectory}\" \"{unpackedGameFilesPath}\"",
            UseShellExecute = false,
            CreateNoWindow = false
        };
        currentToolStatusStripStatusLabel.Text = @"Unpacking game files...";
        await UnrealPakHelpers.UnpackGameFilesAsync(startInfo, currentToolStatusStripStatusLabel);
    }
    // Mods
    private void addNewModToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (pModsDirectory == null)
            return;
        UI.AddNewModUi addNewModUi = new UI.AddNewModUi(pModsDirectory, currentToolStatusStripStatusLabel);
        addNewModUi.ShowDialog();
    }
    private void deleteActiveModToolStripMenuItem_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
    // About
    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        UI.About aboutForm = new UI.About();
        aboutForm.ShowDialog();
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
    private void StartDDSToolsButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(pFileSystem.DdsToolsPath))
        {
            MessageBox.Show(@"DDS Tools is not setup. Please select its location from the Settings menu.", @"Missing Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        Process.Start(new ProcessStartInfo { FileName = pFileSystem.DdsToolsPath, UseShellExecute = true });
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
    private async void packageModButton_Click(object sender, EventArgs e)
    {
        currentToolStatusStripStatusLabel.Text = @"Checking for missing paths before packaging mod files...";
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
        currentToolStatusStripStatusLabel.Text = @"All checks passed! Deleting existing mod files...";
        string modName = Path.GetFileName(pFileSystem.ActiveModPath);
        string activeModPath = Path.Join(pFileSystem.ActiveModPath, "src");
        string packagedModDirectoryPath = Path.Join(pPackagedModsDirectory, modName);
        string packagedModPath = Path.Join(pPackagedModsDirectory, modName, modName + "_P.utoc");
        if (!Directory.Exists(packagedModDirectoryPath))
        {
            Directory.CreateDirectory(packagedModDirectoryPath);
        }
        currentToolStatusStripStatusLabel.Text = @"Files deleted! Preparing to package mod files...";
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = pFileSystem.RetocPath,
            Arguments = $"to-zen -v \"{activeModPath}\" --version UE5_4 \"{packagedModPath}\"",
            UseShellExecute = false,
            CreateNoWindow = false
        };
        currentToolStatusStripStatusLabel.Text = @"Packaging mod files...";
        await UnrealPakHelpers.PackGameFilesAsync(startInfo, currentToolStatusStripStatusLabel);
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

    #region Public Accessors
    public void SetStatusStripStatusLabelText(string text)
    {
        statusTextStripStatusLabel.Text = text;
    }
    #endregion
}