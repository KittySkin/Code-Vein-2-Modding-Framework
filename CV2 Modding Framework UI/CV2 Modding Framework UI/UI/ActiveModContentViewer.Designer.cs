using System.ComponentModel;

namespace CV2_Modding_Framework_UI.UI;

partial class ActiveModContentViewer
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiveModContentViewer));
        modContentTreeView = new System.Windows.Forms.TreeView();
        rightClickContextMenu = new System.Windows.Forms.ContextMenuStrip(components);
        openInExplorerContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        openWorkspaceInExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        exportToJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        rightClickContextMenu.SuspendLayout();
        SuspendLayout();
        // 
        // modContentTreeView
        // 
        modContentTreeView.Location = new System.Drawing.Point(12, 12);
        modContentTreeView.Name = "modContentTreeView";
        modContentTreeView.Size = new System.Drawing.Size(556, 866);
        modContentTreeView.TabIndex = 0;
        // 
        // rightClickContextMenu
        // 
        rightClickContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { openInExplorerContextMenuItem, openWorkspaceInExplorerToolStripMenuItem, exportToJsonToolStripMenuItem });
        rightClickContextMenu.Name = "rightClickContextMenu";
        rightClickContextMenu.Size = new System.Drawing.Size(223, 92);
        // 
        // openInExplorerContextMenuItem
        // 
        openInExplorerContextMenuItem.Name = "openInExplorerContextMenuItem";
        openInExplorerContextMenuItem.Size = new System.Drawing.Size(222, 22);
        openInExplorerContextMenuItem.Text = "Open in Explorer";
        openInExplorerContextMenuItem.Click += openInExplorerContextMenuItem_Click;
        // 
        // openWorkspaceInExplorerToolStripMenuItem
        // 
        openWorkspaceInExplorerToolStripMenuItem.Name = "openWorkspaceInExplorerToolStripMenuItem";
        openWorkspaceInExplorerToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
        openWorkspaceInExplorerToolStripMenuItem.Text = "Open Workspace in Explorer";
        openWorkspaceInExplorerToolStripMenuItem.Click += openWorkspaceInExplorerToolStripMenuItem_Click;
        // 
        // exportToJsonToolStripMenuItem
        // 
        exportToJsonToolStripMenuItem.Name = "exportToJsonToolStripMenuItem";
        exportToJsonToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
        exportToJsonToolStripMenuItem.Text = "Export to Json";
        exportToJsonToolStripMenuItem.Click += exportToJsonToolStripMenuItem_Click;
        // 
        // ActiveModContentViewer
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(580, 890);
        ControlBox = false;
        Controls.Add(modContentTreeView);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        ShowIcon = false;
        ShowInTaskbar = false;
        Text = "Mod Content Viewer";
        rightClickContextMenu.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.ToolStripMenuItem exportToJsonToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem openWorkspaceInExplorerToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem openInExplorerContextMenuItem;

    private System.Windows.Forms.ContextMenuStrip rightClickContextMenu;

    private System.Windows.Forms.TreeView modContentTreeView;

    #endregion
}