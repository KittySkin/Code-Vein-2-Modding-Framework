using CV2_Modding_Framework_UI.Utils;

namespace CV2_Modding_Framework_UI.UI;

public partial class EditModUi : Form
{
    private readonly FileSystem pFileSystem;
    private readonly ModProject pModProject = new();

    public EditModUi(FileSystem fileSystem)
    {
        pFileSystem = fileSystem;
        InitializeComponent();
        LoadModProject();
        if (pModProject.SrcPath != null)
        {
            string sourceBaseContentPath = Path.Join(pModProject.SrcPath, "CodeVein2");
            ListDirectory(currentlyModdedFilesTreeView, sourceBaseContentPath);
        }
    }

    #region UI Initialization and Population Methods

    private void LoadModProject()
    {
        pModProject.LoadModProjectConfig(Path.Join(pFileSystem.ActiveModPath,
            $"{Path.GetFileName(pFileSystem.ActiveModPath)}"));
        this.Text = pModProject.Name;
        descriptionRichTextBox.Text = pModProject.Description;
        versionTextBox.Text = pModProject.Version;
        nexusLinkTextBox.Text = pModProject.NexusModsLink;
    }

    private void ListDirectory(TreeView treeView, string path)
    {
        treeView.Nodes.Clear();
        var rootDirectoryInfo = new DirectoryInfo(path);
        treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        treeView.ExpandAll();
    }

    private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
    {
        var directoryNode = new TreeNode(directoryInfo.Name);
        foreach (var directory in directoryInfo.GetDirectories())
            directoryNode.Nodes.Add(CreateDirectoryNode(directory));
        foreach (var file in directoryInfo.GetFiles())
            directoryNode.Nodes.Add(new TreeNode(file.Name));
        return directoryNode;
    }

    #endregion

    private void updateModButton_Click(object sender, EventArgs e)
    {
        pModProject.Description = descriptionRichTextBox.Text;
        pModProject.Version = versionTextBox.Text;
        pModProject.NexusModsLink = nexusLinkTextBox.Text;
        pModProject.SaveModProjectConfig(Path.Join(pFileSystem.ActiveModPath,
            $"{Path.GetFileName(pFileSystem.ActiveModPath)}"));
        DialogResult = DialogResult.OK;
        Close();
    }
}