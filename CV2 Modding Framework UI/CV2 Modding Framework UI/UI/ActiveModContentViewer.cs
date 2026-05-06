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
        if (e?.Node?.Tag is string filePath)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = pFileSystem.UAssetGuiPath,
                Arguments = $"\"{filePath}\" VER_UE5_4 \"CV2\"",
                UseShellExecute = false,
                CreateNoWindow = false
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