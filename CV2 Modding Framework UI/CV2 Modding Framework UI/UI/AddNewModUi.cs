using System.Text.Json;
using CV2_Modding_Framework_UI.Utils;

namespace CV2_Modding_Framework_UI.UI;

public partial class AddNewModUi : Form
{
    private readonly string pPath;
    private readonly ToolStripStatusLabel pToolStripStatusLabel;
    private bool pIsUpdatingCheckboxes = false;

    public AddNewModUi(string path, ToolStripStatusLabel toolStripStatusLabel)
    {
        pPath = path;
        pToolStripStatusLabel = toolStripStatusLabel;
        InitializeComponent();
        LoadFolderStructure();
    }

    private void LoadFolderStructure()
    {
        string jsonPath = "folder_structure.json";
        if (!File.Exists(jsonPath))
        {
            return;
        }

        try
        {
            string json = File.ReadAllText(jsonPath);
            var folderStructure = JsonSerializer.Deserialize<List<FolderStructureItem>>(json);
            if (folderStructure != null)
            {
                defaultStartingContentTreeView.Nodes.Clear();
                foreach (var item in folderStructure)
                {
                    defaultStartingContentTreeView.Nodes.Add(CreateTreeNode(item));
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($@"Failed to load folder structure: {ex.Message}", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private TreeNode CreateTreeNode(FolderStructureItem item)
    {
        TreeNode node = new TreeNode(item.Name);
        foreach (var subFolder in item.SubFolders)
        {
            node.Nodes.Add(CreateTreeNode(subFolder));
        }
        return node;
    }

    private void confirmButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(modNameTextBox.Text))
        {
            MessageBox.Show(@"Mod name cannot be empty", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!Directory.Exists(pPath))
        {
            MessageBox.Show(@"Mods directory seems to be missing, please restart the tool to create it.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        modNameTextBox.Text = modNameTextBox.Text.Replace(" ", "");
        string modPath = Path.Join(pPath, modNameTextBox.Text);
        string srcPath = Path.Join(modPath, "src");

        if (Directory.Exists(pPath))
        {   
            Directory.CreateDirectory(srcPath);
            File.Create(Path.Join(modPath, $"{modNameTextBox.Text}.txt")).Close();
            CreateFoldersFromNodes(defaultStartingContentTreeView.Nodes, srcPath);
            pToolStripStatusLabel.Text = $@"Mod {modNameTextBox.Text} created successfully!";
            DialogResult = DialogResult.OK;
            Close();
        }
    }

    private void CreateFoldersFromNodes(TreeNodeCollection nodes, string basePath)
    {
        foreach (TreeNode node in nodes)
        {
            if (node.Checked || HasCheckedChild(node))
            {
                string currentPath = Path.Combine(basePath, node.Text);
                Directory.CreateDirectory(currentPath);
                CreateFoldersFromNodes(node.Nodes, currentPath);
            }
        }
    }

    private bool HasCheckedChild(TreeNode node)
    {
        foreach (TreeNode child in node.Nodes)
        {
            if (child.Checked || HasCheckedChild(child))
            {
                return true;
            }
        }
        return false;
    }

    private void defaultStartingContentTreeView_AfterCheck(object sender, TreeViewEventArgs e)
    {
        if (pIsUpdatingCheckboxes)
        {
            return;
        }

        if (e.Node == null || !e.Node.Checked)
        {
            return;
        }

        pIsUpdatingCheckboxes = true;
        try
        {
            CheckParentNodes(e.Node);
        }
        finally
        {
            pIsUpdatingCheckboxes = false;
        }
    }

    private void CheckParentNodes(TreeNode node)
    {
        TreeNode? parent = node.Parent;
        while (parent != null)
        {
            if (!parent.Checked)
            {
                parent.Checked = true;
            }
            parent = parent.Parent;
        }
    }
}