using System.Diagnostics;
using System.Security.Principal;
using CV2_Modding_Framework_UI.Utils;

namespace CV2_Modding_Framework_UI;

public partial class MainUi : Form
{
    private readonly FileSystem pFileSystem = new();
    private string? pActiveModPath;
    private string? pModsDirectory;
    private string? pPackagedModsDirectory;
    
    public MainUi()
    {
        InitializeComponent();
        currentToolStatusStripStatusLabel.Text = @"Loading in progress...";
        pFileSystem.LoadFileSystemConfig("config.json");
        if (pFileSystem.WorkspaceDirectory != String.Empty)
        {
            currentToolStatusStripStatusLabel.Text = @"Loading workspace...";
            currentWorkspaceIndicatorStripStatusLabel.Text = pFileSystem.WorkspaceDirectory;
            // Create the Mods directory if it doesn't exist
            currentToolStatusStripStatusLabel.Text = @"Checking workspace compliance...";
            pModsDirectory = Path.Combine(pFileSystem.WorkspaceDirectory, "Mods");
            UnrealPakHelpers.CreateModsDirectory(pModsDirectory);
            pPackagedModsDirectory = Path.Combine(pFileSystem.WorkspaceDirectory, "PackagedMods");
            UnrealPakHelpers.CreateModsDirectory(pPackagedModsDirectory);
            
            currentToolStatusStripStatusLabel.Text = @"Loading mods...";
            LoadMods();
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
            currentToolStatusStripStatusLabel.Text = @"Vanilla Paks symlink loaded!";
        }
        if (pFileSystem.SymLinkDestinationDirectory != String.Empty)
        {
            currentToolStatusStripStatusLabel.Text = @"SymLink destination loaded!";
        }
        currentToolStatusStripStatusLabel.Text = @"Tool loaded successfully! Happy modding!";
    }

    private void LoadMods()
    {
        if (pModsDirectory == null)
        {
            currentToolStatusStripStatusLabel.Text = @"Mods directory not set. Please set the mods directory in settings.";
            return;
        }
        modSelectionComboBox.Items.Clear();
        foreach (string path in Directory.EnumerateDirectories(pModsDirectory))
        {
            modSelectionComboBox.Items.Add(path);
        }
    }
    #region Menu Strip Items
    // Settings
    private void launchSetupModuleToolStripMenuItem_Click(object sender, EventArgs e)
    {
        currentToolStatusStripStatusLabel.Text = @"Launching Setup Module...";
        UI.SetupModule setupModule = new UI.SetupModule(pFileSystem);
        setupModule.ShowDialog();
        if (setupModule.DialogResult == DialogResult.OK)
        {
            pModsDirectory = Path.Combine(pFileSystem.WorkspaceDirectory, "Mods");
            pPackagedModsDirectory = Path.Combine(pFileSystem.WorkspaceDirectory, "PackagedMods");
            UnrealPakHelpers.CreateModsDirectory(pModsDirectory);
            UnrealPakHelpers.CreateModsDirectory(pPackagedModsDirectory);
            currentToolStatusStripStatusLabel.Text = @"Setup Module completed.";
            currentWorkspaceIndicatorStripStatusLabel.Text = pFileSystem.WorkspaceDirectory;
            LoadMods();
        }
        else
        {
            currentToolStatusStripStatusLabel.Text = @"Setup Module cancelled.";
        }
    }
    // Utilities
    private async void unpackGameFilesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
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
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            currentToolStatusStripStatusLabel.Text = @"Error unpacking game files";
        }
    }
    private void checkGameFilesForDifferencesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        UI.GameFilesComparison gameFilesComparison = new UI.GameFilesComparison();
        gameFilesComparison.Show();
    }
    // Mods
    private void addNewModToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (pModsDirectory == null)
            return;
        UI.AddNewModUi addNewModUi = new UI.AddNewModUi(pModsDirectory, currentToolStatusStripStatusLabel);
        addNewModUi.ShowDialog();
        if (addNewModUi.DialogResult == DialogResult.OK)
        {
            LoadMods();
        }
    }
    private void deleteActiveModToolStripMenuItem_Click(object sender, EventArgs e)
    {
        DialogResult deleteModDialogResult = MessageBox.Show($@"You are about to delete the active mod: {pFileSystem.ActiveModPath}. This action cannot be undone.", @"Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        if (deleteModDialogResult == DialogResult.OK)
        {
            pFileSystem.DeleteActiveMod();
            if (pModsDirectory != null) LoadMods();
            modSelectionComboBox.SelectedIndex = 0;
            pFileSystem.SaveFileSystemConfig();
        }
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
        if (String.IsNullOrEmpty(pFileSystem.UAssetGuiPath))
        {
            MessageBox.Show(@"UAssetGui is not setup. Please select its location from the Settings menu.", @"Missing Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        Process.Start(new ProcessStartInfo { FileName = pFileSystem.UAssetGuiPath, WorkingDirectory = Path.GetDirectoryName(pFileSystem.UAssetGuiPath), UseShellExecute = true });
    }
    private void StartFModelButton_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(pFileSystem.FModelPath))
        {
            MessageBox.Show(@"FModel is not setup. Please select its location from the Settings menu.", @"Missing Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        Process.Start(new ProcessStartInfo { FileName = pFileSystem.FModelPath, WorkingDirectory = Path.GetDirectoryName(pFileSystem.FModelPath), UseShellExecute = true });
    }
    private void StartDDSToolsButton_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(pFileSystem.DdsToolsPath))
        {
            MessageBox.Show(@"DDS Tools is not setup. Please select its location from the Settings menu.", @"Missing Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        Process.Start(new ProcessStartInfo { FileName = pFileSystem.DdsToolsPath, WorkingDirectory = Path.GetDirectoryName(pFileSystem.DdsToolsPath), UseShellExecute = true });
    }
    private void StartUeLocresEditorButton_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(pFileSystem.UnrealLocresEditorPath))
        {
            MessageBox.Show(@"Unreal Locres Editor is not setup. Please select its location from the Settings menu.", @"Missing Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        Process.Start(new ProcessStartInfo { FileName = pFileSystem.UnrealLocresEditorPath, WorkingDirectory = Path.GetDirectoryName(pFileSystem.UnrealLocresEditorPath), UseShellExecute = true });
    }
    #endregion

    #region Mod Handling
    private async void packageModButton_Click(object sender, EventArgs e)
    {
        try
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
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            currentToolStatusStripStatusLabel.Text = @"Error packaging mod files";
        }
    }
    private void packageAndDeployButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(pFileSystem.ActiveModPath))
        {
            MessageBox.Show(@"No active mod selected. Please select a mod first.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (string.IsNullOrEmpty(pFileSystem.GameModsFolderPath))
        {
            MessageBox.Show(@"Game mods folder path is not set. Please configure the game mods folder path first.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        string modName = Path.GetFileName(pFileSystem.ActiveModPath);
        string packagedModDirectoryPath = Path.Join(pPackagedModsDirectory, modName);
        if (!Directory.Exists(packagedModDirectoryPath))
        {
            MessageBox.Show(@"Packaged mod directory does not exist. Please package the mod first.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        try
        {
            Directory.CreateDirectory(Path.Join(pFileSystem.GameModsFolderPath, modName));
            File.Copy(Path.Join(packagedModDirectoryPath, $"{modName}_P.utoc"), Path.Join(pFileSystem.GameModsFolderPath, modName, $"{modName}_P.utoc"), true);
            File.Copy(Path.Join(packagedModDirectoryPath, $"{modName}_P.ucas"), Path.Join(pFileSystem.GameModsFolderPath, modName, $"{modName}_P.ucas"), true);
            File.Copy(Path.Join(packagedModDirectoryPath, $"{modName}_P.pak"), Path.Join(pFileSystem.GameModsFolderPath, modName, $"{modName}_P.pak"), true);
            currentToolStatusStripStatusLabel.Text = @"Mod deployed successfully";
            MessageBox.Show(@"Mod deployed successfully", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            currentToolStatusStripStatusLabel.Text = @"Error deploying mod";
        }
    }
    private void modSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (modSelectionComboBox.SelectedItem == null)
            return;
        
        pActiveModPath = modSelectionComboBox.SelectedItem.ToString();

        if (pActiveModPath != null)
        {
            string modName = Path.GetFileNameWithoutExtension(pActiveModPath);
            if (modName != String.Empty)
            {
                if (File.Exists(Path.Join(pActiveModPath, $"{modName}.txt")))
                {
                    modDescriptionRichTextbox.Text = File.ReadAllText(Path.Join(pActiveModPath, $"{modName}.txt"));
                }
                else
                {
                    File.Create(Path.Join(pActiveModPath, $"{modName}.txt")).Close();
                    modDescriptionRichTextbox.Text = "";
                }
            }
            pFileSystem.ActiveModPath = pActiveModPath;
            pFileSystem.SaveFileSystemConfig();
        }
    }
    #endregion

    private void modDescriptionRichTextbox_TextChanged(object sender, EventArgs e)
    {
        string? modName = Path.GetFileNameWithoutExtension(pActiveModPath);
        if (modName == null)
            return;
        using var fileStream = new FileStream(Path.Join(pActiveModPath, $"{modName}.txt"), FileMode.Create, FileAccess.Write);
        using var writer = new StreamWriter(fileStream);
        writer.Write(modDescriptionRichTextbox.Text);
    }
}