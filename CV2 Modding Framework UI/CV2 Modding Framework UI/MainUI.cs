using System.Diagnostics;
using CV2_Modding_Framework_UI.Utils;

namespace CV2_Modding_Framework_UI;

public partial class MainUi : Form
{
    private readonly FileSystem pFileSystem = new();
    private string? pActiveModPath;
    private string? pModsDirectory;
    private string? pPackagedModsDirectory;
    private ModProject? pActiveModProject;
    private readonly UI.ActiveModContentViewer pActiveModContentViewer;

    public MainUi()
    {
        InitializeComponent();
        pActiveModContentViewer = new UI.ActiveModContentViewer(pFileSystem);
        pActiveModContentViewer.FileExported += ActiveModContentViewer_FileExported;
        pActiveModContentViewer.StartPosition = FormStartPosition.Manual;
        AddOwnedForm(pActiveModContentViewer);
        currentToolStatusStripStatusLabel.Text = @"Loading in progress...";
        LoadSettings();
        currentToolStatusStripStatusLabel.Text = @"Tool loaded successfully! Happy modding!";
        pActiveModContentViewer.Show();
    }

    #region UI Initialization and Population Methods

    private void LoadSettings()
    {
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
                LoadModProject();
                currentToolStatusStripStatusLabel.Text = @"Active mod selected!";
                if (pActiveModProject != null && String.IsNullOrEmpty(pActiveModProject.SrcPath) == false)
                {
                    pActiveModContentViewer.PopulateTreeView(Path.Join(pActiveModProject.SrcPath, "CodeVein2"));
                }
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

        if (pFileSystem.DisableDeployPopup != null)
        {
            disableDeployPopupToolStripMenuItem.Checked = pFileSystem.DisableDeployPopup.Value;
        }

        Location = pFileSystem.MainUiPosition;
        Size = pFileSystem.MainUiSize;
        pActiveModContentViewer.Location = pFileSystem.ModContentViewerPosition;
        pActiveModContentViewer.Size = pFileSystem.ModContentViewerSize;

#if DEBUG_ABOUT
        UI.About aboutForm = new UI.About();
        aboutForm.Show();
#endif
#if DEBUG_SETUP_MODULE
        UI.SetupModule setupModule = new UI.SetupModule(pFileSystem);
        setupModule.ShowDialog();
#endif
    }

    private void LoadMods()
    {
        if (pModsDirectory == null)
        {
            currentToolStatusStripStatusLabel.Text =
                @"Mods directory not set. Please set the mods directory in settings.";
            return;
        }

        modSelectionComboBox.Items.Clear();
        foreach (string path in Directory.EnumerateDirectories(pModsDirectory))
        {
            modSelectionComboBox.Items.Add(path);
        }
    }

    private void LoadModProject()
    {
        pActiveModProject = new ModProject();
        pActiveModProject.LoadModProjectConfig(Path.Join(pFileSystem.ActiveModPath,
            $"{Path.GetFileName(pFileSystem.ActiveModPath)}"));
    }

    #endregion

    #region Helper Methods

    /// <summary>
    /// Reloads the mod list. Its main function is to be called instead of LoadMods() to keep this method in the helpers' region.
    /// </summary>
    private void ReloadMods()
    {
        currentToolStatusStripStatusLabel.Text = @"Reloading mods...";
        LoadMods();
        currentToolStatusStripStatusLabel.Text = @"Mods reloaded.";
    }

    #endregion

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

    private void disableDeployPopupToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
    {
        pFileSystem.DisableDeployPopup = disableDeployPopupToolStripMenuItem.Checked;
        pFileSystem.SaveFileSystemConfig();
    }

    // Utilities
    private async void unpackGameFilesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            currentToolStatusStripStatusLabel.Text = @"Checking for missing paths before unpacking game files...";
            if (String.IsNullOrEmpty(pFileSystem.RetocPath))
            {
                MessageBox.Show(@"Retoc is not setup. Please select its location from the Settings menu.",
                    @"Missing Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (String.IsNullOrEmpty(pFileSystem.WorkspaceDirectory))
            {
                MessageBox.Show(
                    @"Workspace directory is not setup in the, please select its location from the 'Select Active Workspace' button.",
                    @"Missing Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (pFileSystem.VanillaPaksSymLinkPath == Array.Empty<string>())
            {
                MessageBox.Show(
                    @"Vanilla Paks symlink is not setup. Please select its location and create them using the 'Create or Update SymLink'.",
                    @"Missing Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (String.IsNullOrEmpty(pFileSystem.SymLinkDestinationDirectory))
            {
                MessageBox.Show(@"Vanilla Paks symlink is not setup. Please setup it properly.", @"Missing Path",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Arguments =
                    $"-a {Constants.AesKey} to-legacy -v \"{pFileSystem.SymLinkDestinationDirectory}\" \"{unpackedGameFilesPath}\"",
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
        gameFilesComparison.OperationCompleted += (_, _) =>
            currentToolStatusStripStatusLabel.Text = @"Game files comparison completed.";
        gameFilesComparison.FormClosed +=
            (_, _) => currentToolStatusStripStatusLabel.Text = @"Game files comparison closed.";
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
            ReloadMods();
        }
    }

    private void deleteActiveModToolStripMenuItem_Click(object sender, EventArgs e)
    {
        DialogResult deleteModDialogResult =
            MessageBox.Show(
                $@"You are about to delete the active mod: {pFileSystem.ActiveModPath}. This action cannot be undone.",
                @"Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        if (deleteModDialogResult == DialogResult.OK)
        {
            pFileSystem.DeleteActiveMod();
            if (pModsDirectory != null) ReloadMods();
            modSelectionComboBox.SelectedIndex = 0;
            pFileSystem.SaveFileSystemConfig();
        }
    }

    private void editActiveModToolStripMenuItem_Click(object sender, EventArgs e)
    {
        currentToolStatusStripStatusLabel.Text = @"Editing Active Mod";
        UI.EditModUi editModUi = new UI.EditModUi(pFileSystem);
        editModUi.ShowDialog();
        if (editModUi.DialogResult == DialogResult.OK)
        {
            pFileSystem.SaveFileSystemConfig();
            ReloadMods();
            currentToolStatusStripStatusLabel.Text = $@"Mod {pActiveModProject?.Name} Updated!";
        }
    }

    // About
    private void downloadLinksToolStripMenuItem_Click(object sender, EventArgs e)
    {
        UI.DownloadLinks downloadLinks = new UI.DownloadLinks();
        downloadLinks.Show();
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        UI.About aboutForm = new UI.About();
        aboutForm.Show();
    }

    // Launch Game
    private void launchGameToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (pFileSystem.GameModsFolderPath == String.Empty)
        {
            MessageBox.Show(
                @"Game mods folder path is not set. We need this to be set to calculate the game's exe location.",
                @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        DirectoryInfo? tempDirectoryInfo = Directory.GetParent(pFileSystem.GameModsFolderPath)?.Parent?.Parent;
        string gameExeFilePath =
            Path.Join(tempDirectoryInfo?.FullName, "Binaries", "Win64", "CodeVein2-Win64-Shipping.exe");
        string workingDirectory = Path.Join(tempDirectoryInfo?.FullName, "Binaries", "Win64");
        if (!File.Exists(gameExeFilePath))
        {
            MessageBox.Show(
                @"Game executable not found. Please make sure the game mods directory is correctly set and the game is installed properly.",
                @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        ProcessStartInfo processStartInfo = new ProcessStartInfo
        {
            FileName = gameExeFilePath,
            WorkingDirectory = workingDirectory,
            UseShellExecute = false,
            CreateNoWindow = false
        };
        Process.Start(processStartInfo);
    }

    #endregion

    #region Tool Launcher

    private void StartUAssetGuiButton_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(pFileSystem.UAssetGuiPath))
        {
            MessageBox.Show(@"UAssetGui is not setup. Please select its location from the Settings menu.",
                @"Missing Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        Process.Start(new ProcessStartInfo
        {
            FileName = pFileSystem.UAssetGuiPath, WorkingDirectory = Path.GetDirectoryName(pFileSystem.UAssetGuiPath),
            UseShellExecute = true
        });
    }

    private void StartFModelButton_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(pFileSystem.FModelPath))
        {
            MessageBox.Show(@"FModel is not setup. Please select its location from the Settings menu.", @"Missing Path",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        Process.Start(new ProcessStartInfo
        {
            FileName = pFileSystem.FModelPath, WorkingDirectory = Path.GetDirectoryName(pFileSystem.FModelPath),
            UseShellExecute = true
        });
    }

    private void StartDDSToolsButton_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(pFileSystem.DdsToolsPath))
        {
            MessageBox.Show(@"DDS Tools is not setup. Please select its location from the Settings menu.",
                @"Missing Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        Process.Start(new ProcessStartInfo
        {
            FileName = pFileSystem.DdsToolsPath, WorkingDirectory = Path.GetDirectoryName(pFileSystem.DdsToolsPath),
            UseShellExecute = true
        });
    }

    private void StartUeLocresEditorButton_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(pFileSystem.UnrealLocresEditorPath))
        {
            MessageBox.Show(@"Unreal Locres Editor is not setup. Please select its location from the Settings menu.",
                @"Missing Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        Process.Start(new ProcessStartInfo
        {
            FileName = pFileSystem.UnrealLocresEditorPath,
            WorkingDirectory = Path.GetDirectoryName(pFileSystem.UnrealLocresEditorPath), UseShellExecute = true
        });
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
                MessageBox.Show(@"Retoc is not setup in the, please select its location from the Settings bar menu.",
                    @"Missing Retoc Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(pFileSystem.WorkspaceDirectory))
            {
                MessageBox.Show(
                    @"Workspace directory is not setup in the, please select its location from the 'Select Active Workspace' button.",
                    @"Missing Workspace Directory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(pFileSystem.ActiveModPath))
            {
                MessageBox.Show(
                    @"Active mod is not setup in the, please select an active mod from the mod dropdown menu.",
                    @"Missing Active Mod", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    private void DeployButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(pFileSystem.ActiveModPath))
        {
            MessageBox.Show(@"No active mod selected. Please select a mod first.", @"Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        if (string.IsNullOrEmpty(pFileSystem.GameModsFolderPath))
        {
            MessageBox.Show(@"Game mods folder path is not set. Please configure the game mods folder path first.",
                @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        string modName = Path.GetFileName(pFileSystem.ActiveModPath);
        string packagedModDirectoryPath = Path.Join(pPackagedModsDirectory, modName);
        if (!Directory.Exists(packagedModDirectoryPath))
        {
            MessageBox.Show(@"Packaged mod directory does not exist. Please package the mod first.", @"Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        try
        {
            Directory.CreateDirectory(Path.Join(pFileSystem.GameModsFolderPath, modName));
            File.Copy(Path.Join(packagedModDirectoryPath, $"{modName}_P.utoc"),
                Path.Join(pFileSystem.GameModsFolderPath, modName, $"{modName}_P.utoc"), true);
            File.Copy(Path.Join(packagedModDirectoryPath, $"{modName}_P.ucas"),
                Path.Join(pFileSystem.GameModsFolderPath, modName, $"{modName}_P.ucas"), true);
            File.Copy(Path.Join(packagedModDirectoryPath, $"{modName}_P.pak"),
                Path.Join(pFileSystem.GameModsFolderPath, modName, $"{modName}_P.pak"), true);
            currentToolStatusStripStatusLabel.Text = @"Mod deployed successfully";
            if (pFileSystem.DisableDeployPopup is false)
            {
                MessageBox.Show(@"Mod deployed successfully", @"Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
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
            LoadModProject();
            pFileSystem.SaveFileSystemConfig();
            if (pActiveModProject != null && String.IsNullOrEmpty(pActiveModProject.SrcPath) == false)
            {
                pActiveModContentViewer.PopulateTreeView(pActiveModProject.SrcPath);
            }
        }
    }

    #endregion

    #region Event Handlers

    private void ActiveModContentViewer_FileExported(object? sender, UI.FileProcessedEventArgs e)
    {
        currentToolStatusStripStatusLabel.Text = $@"Successfully exported: {e.FileName}";
    }

    private void MainUi_FormClosing(object sender, FormClosingEventArgs e)
    {
        pFileSystem.MainUiPosition = Location;
        pFileSystem.MainUiSize = Size;
        pFileSystem.ModContentViewerPosition = pActiveModContentViewer.Location;
        pFileSystem.ModContentViewerSize = pActiveModContentViewer.Size;
        pFileSystem.SaveFileSystemConfig();
    }

    #endregion

    #region Mod Description Monitoring

    private void modDescriptionRichTextbox_TextChanged(object sender, EventArgs e)
    {
        string? modName = Path.GetFileNameWithoutExtension(pActiveModPath);
        if (modName == null)
            return;
        using var fileStream =
            new FileStream(Path.Join(pActiveModPath, $"{modName}.txt"), FileMode.Create, FileAccess.Write);
        using var writer = new StreamWriter(fileStream);
        writer.Write(modDescriptionRichTextbox.Text);
    }

    #endregion
}