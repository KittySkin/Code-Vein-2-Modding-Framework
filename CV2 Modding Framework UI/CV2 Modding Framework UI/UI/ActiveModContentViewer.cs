using System.Diagnostics;

namespace CV2_Modding_Framework_UI.UI;

public partial class ActiveModContentViewer : Form
{
    private readonly Utils.FileSystem pFileSystem;
    public ActiveModContentViewer(Utils.FileSystem fileSystem)
    {
        pFileSystem = fileSystem;
        InitializeComponent();
        modContentTreeView.NodeMouseDoubleClick += ModContentTreeView_NodeMouseDoubleClick;
        // Valuable snipped of code from https://stackoverflow.com/questions/32082280/right-click-on-node-in-treeview-and-have-a-menu-pop-up-with-the-option-of-open
        // It makes the node get selected when you right-click on it before handling the event.
        modContentTreeView.NodeMouseClick += (sender, args) => modContentTreeView.SelectedNode = args.Node;
        modContentTreeView.MouseClick += ModContentTreeView_MouseClick;
    }

    #region Tree View Population Helpers

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
        directoryNode.Tag = directoryInfo.FullName;
        foreach (var directory in directoryInfo.GetDirectories())
            directoryNode.Nodes.Add(CreateDirectoryNode(directory));
        foreach (var file in directoryInfo.GetFiles())
        {
            if (file.Extension != Utils.Constants.UassetExtension) continue;
            TreeNode fileNode = new TreeNode(file.Name);
            fileNode.Tag = file.FullName;
            directoryNode.Nodes.Add(fileNode);
            
        }
        return directoryNode;
    }

    #endregion
    
    #region UI Event Handlers

    private void ModContentTreeView_NodeMouseDoubleClick(object? sender, TreeNodeMouseClickEventArgs? e)
    {
        // Check if the Tag is a string (which we use for file paths)
        if (e?.Node?.Tag is string filePath && filePath.EndsWith(Utils.Constants.UassetExtension))
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = pFileSystem.UAssetGuiPath,
                Arguments = $"\"{filePath}\" VER_UE5_4 \"CV2\"",
                WindowStyle = ProcessWindowStyle.Maximized,
                UseShellExecute = false,
                CreateNoWindow = false
            };
            Process.Start(startInfo);
        }
    }

    private void ModContentTreeView_MouseClick(object? sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right) 
        {
            rightClickContextMenu.Show(Cursor.Position);
        }
    }
    
    private void openInExplorerContextMenuItem_Click(object sender, EventArgs e)
    {
        if (modContentTreeView.SelectedNode?.Tag is string filePath)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "Explorer.exe",
                ArgumentList = { "/select,", filePath },
                UseShellExecute = true
            };
            Process.Start(startInfo);
        }
    }
    #endregion
    
    #region UI Population API

    public void PopulateTreeView(string path)
    {
        ListDirectory(modContentTreeView, path);
    }
    
    #endregion
    
}