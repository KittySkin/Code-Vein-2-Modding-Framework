using System.Security.Principal;
using CV2_Modding_Framework_UI.Utils;

namespace CV2_Modding_Framework_UI.UI;

public partial class SetupModule : Form
{
    private readonly FileSystem pFileSystem;
    private readonly bool pIsElevated;
    public SetupModule(FileSystem fileSystem)
    {
        InitializeComponent();
        pFileSystem = fileSystem;
        using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
        {
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            pIsElevated = principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
        if (pFileSystem.WorkspaceDirectory != String.Empty)
        {
            activeWorkspaceTextBox.Text = pFileSystem.WorkspaceDirectory;
            // Create the Mods directory if it doesn't exist
            string modsDirectory = Path.Combine(pFileSystem.WorkspaceDirectory, "Mods");
            UnrealPakHelpers.CreateModsDirectory(modsDirectory);
            string packagedModsDirectory = Path.Combine(pFileSystem.WorkspaceDirectory, "PackagedMods");
            UnrealPakHelpers.CreateModsDirectory(packagedModsDirectory);
        }
        if (pFileSystem.VanillaPaksSymLinkPath != Array.Empty<string>())
        {
            vanillaPaksLocationTextBox.Text = String.Join(Environment.NewLine, pFileSystem.VanillaPaksSymLinkPath);
        }
        if (pFileSystem.SymLinkDestinationDirectory != String.Empty)
        {
            symLinkLocationTextBox.Text = pFileSystem.SymLinkDestinationDirectory;
        }
        if (pFileSystem.UAssetGuiPath != String.Empty)
        {
            uAssetGuiPathTextBox.Text = pFileSystem.UAssetGuiPath;
        }
        if (pFileSystem.FModelPath != String.Empty)
        {
            fModelPathTextBox.Text = pFileSystem.FModelPath;
        }

        if (pFileSystem.RetocPath != String.Empty)
        {
            retocPathTextBox.Text = pFileSystem.RetocPath;
        }
        if (pFileSystem.DdsToolsPath != String.Empty)
        {
            ddsToolsPathTextBox.Text = pFileSystem.DdsToolsPath;
        }
    }

    private void selectActiveWorkspaceButton_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        
        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        {
            activeWorkspaceTextBox.Text = folderBrowserDialog.SelectedPath;
            pFileSystem.WorkspaceDirectory = folderBrowserDialog.SelectedPath;
        }
    }

    private void browseVanillaPacksButton_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = @"Pakchunk files|*.pak;*.ucas;*.utoc";
        openFileDialog.FilterIndex = 1;
        openFileDialog.RestoreDirectory = true;
        openFileDialog.Multiselect = true;

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            vanillaPaksLocationTextBox.Text = openFileDialog.FileName;
            pFileSystem.VanillaPaksSymLinkPath = openFileDialog.FileNames;
        }
    }

    private void browseSymLinkDestinationButton_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        
        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        {
            symLinkLocationTextBox.Text = folderBrowserDialog.SelectedPath;
            pFileSystem.SymLinkDestinationDirectory = folderBrowserDialog.SelectedPath;
        }
    }
    
    private void createOrUpdateSymLinkButton_Click(object sender, EventArgs e)
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
    
    private void selectUAssetGuiLocationButton_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = @"UAssetGUI executable|UAssetGUI.exe";
        openFileDialog.FilterIndex = 1;
        openFileDialog.RestoreDirectory = true;
        openFileDialog.Multiselect = false;
        
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            uAssetGuiPathTextBox.Text = openFileDialog.FileName;
            pFileSystem.UAssetGuiPath = openFileDialog.FileName;
        }
    }

    private void selectFModelLocationButton_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = @"FModel executable|FModel.exe";
        openFileDialog.FilterIndex = 1;
        openFileDialog.RestoreDirectory = true;
        openFileDialog.Multiselect = false;
        
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            fModelPathTextBox.Text = openFileDialog.FileName;
            pFileSystem.FModelPath = openFileDialog.FileName;
        }
    }

    private void selectRetocLocationButton_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = @"retoc executable|retoc.exe";
        openFileDialog.FilterIndex = 1;
        openFileDialog.RestoreDirectory = true;
        openFileDialog.Multiselect = false;
        
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            retocPathTextBox.Text = openFileDialog.FileName;
            pFileSystem.RetocPath = openFileDialog.FileName;
        }
    }

    private void selectDdsToolsLocationButton_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = @"DDS Tools executable|GUI.exe";
        openFileDialog.FilterIndex = 1;
        openFileDialog.RestoreDirectory = true;
        openFileDialog.Multiselect = false;
        
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            ddsToolsPathTextBox.Text = openFileDialog.FileName;
            pFileSystem.DdsToolsPath = openFileDialog.FileName;
        }
    }

    private void selectLocresToolButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show(@"This tool is not yet supported.", @"Not Supported", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void selectEncryptionToolButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show(@"This tool is not yet supported.", @"Not Supported", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void closeSetupModuleButton_Click(object sender, EventArgs e)
    {
        pFileSystem.SaveFileSystemConfig();
        DialogResult = DialogResult.OK;
        Close();
    }
}