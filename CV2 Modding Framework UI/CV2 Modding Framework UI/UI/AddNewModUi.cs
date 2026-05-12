using System.Text.Json;
using CV2_Modding_Framework_UI.Utils;

namespace CV2_Modding_Framework_UI.UI;

public partial class AddNewModUi : Form
{
    private readonly string pPath;
    private readonly ToolStripStatusLabel pToolStripStatusLabel;
    private string? pModPath;
    private string? pSrcPath;
    private string? pModNameWithoutWhiteSpaces;
    private string? pModName;

    // ReSharper disable once RedundantDefaultMemberInitializer
    // For clarity we want to initialize this to false, even if not needed.
    private bool pIsUpdatingCheckboxes = false;

    public AddNewModUi(string path, ToolStripStatusLabel toolStripStatusLabel)
    {
        pPath = path;
        pToolStripStatusLabel = toolStripStatusLabel;
        InitializeComponent();
        LoadFolderStructure();
    }

    #region UI initialization and population methods

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
            MessageBox.Show($@"Failed to load folder structure: {ex.Message}", @"Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
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

    #endregion

    #region UI Event Handlers

    private void confirmButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(modNameTextBox.Text))
        {
            MessageBox.Show(@"Mod name cannot be empty", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!Directory.Exists(pPath))
        {
            MessageBox.Show(@"Mods directory seems to be missing, please restart the tool to create it.", @"Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        pModName = modNameTextBox.Text;
        pModNameWithoutWhiteSpaces = modNameTextBox.Text.Replace(" ", "");
        pModPath = Path.Join(pPath, pModNameWithoutWhiteSpaces);
        pSrcPath = Path.Join(pModPath, "src");

        if (Directory.Exists(pPath))
        {
            Directory.CreateDirectory(pSrcPath);
            File.Create(Path.Join(pModPath, $"{pModNameWithoutWhiteSpaces}.txt")).Close();
            CreateFoldersFromNodes(defaultStartingContentTreeView.Nodes, pSrcPath);
            pToolStripStatusLabel.Text = $@"Mod {pModNameWithoutWhiteSpaces} created successfully!";
            DialogResult = DialogResult.OK;
            CreateModProjectFile();
            Close();
        }
    }

    /// <summary>
    /// Updates Checked for all the parent nodes when a child node is checked.
    /// </summary>
    /// <param name="sender">The sender of the event</param>
    /// <param name="e">Event arguments for the AfterCheck event</param>
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

    #endregion

    #region Mod Creation Helpers

    /// <summary>
    /// Creates folders based on the nodes selected in the tree view.
    /// </summary>
    /// <param name="nodes">The collection of tree nodes to process</param>
    /// <param name="basePath">The base path for creating folders</param>
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

    private void CreateModProjectFile()
    {
        ModProject modProject = new ModProject
        {
            Name = pModName,
            Description = "",
            Version = "1.0.0",
            SrcPath = pSrcPath
        };
        modProject.SaveModProjectConfig(Path.Join(pModPath, pModNameWithoutWhiteSpaces));
    }

    #endregion

    #region UI Helpers

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

    #endregion
}