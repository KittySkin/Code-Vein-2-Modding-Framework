using System.Diagnostics;

namespace CV2_Modding_Framework_UI;

public partial class MainUi : Form
{
    private readonly Utils.FileSystem pFileSystem = new();
    
    public MainUi()
    {
        InitializeComponent();
        this.pFileSystem.LoadFileSystemConfig("config.json");
        if (this.pFileSystem.ModFolderLocation != String.Empty)
        {
            modFolderLocation.Text = this.pFileSystem.ModFolderLocation;
        }
    }

    private void browseModFolder_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        
        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        {
            modFolderLocation.Text = folderBrowserDialog.SelectedPath;
            this.pFileSystem.ModFolderLocation = folderBrowserDialog.SelectedPath;
            this.pFileSystem.SaveFileSystemConfig("config.json");
        }
    }

    private void modFolderLocation_TextChanged(object sender, EventArgs e)
    {
        return;
    }

    private void createSysLink_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Pakchunk files|*.pak";
        openFileDialog.FilterIndex = 1;
        openFileDialog.RestoreDirectory = true;
        openFileDialog.Multiselect = true;

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            sysLinkTextBox.Text = openFileDialog.FileName;
        }
    }

    private void UAssetGUIMenuItem_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "UAssetGUI executable|UAssetGUI.exe";
        openFileDialog.FilterIndex = 1;
        openFileDialog.RestoreDirectory = true;
        openFileDialog.Multiselect = false;
        
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            this.pFileSystem.UAssetGuiPath = openFileDialog.FileName;
            this.pFileSystem.SaveFileSystemConfig("config.json");
        }
    }

    private void StartUAssetGuiButton_Click(object sender, EventArgs e)
    {
        Process.Start(this.pFileSystem.UAssetGuiPath);
    }
}