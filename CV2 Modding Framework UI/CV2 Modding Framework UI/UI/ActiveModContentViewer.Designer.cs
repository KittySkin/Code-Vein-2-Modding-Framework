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
        exportUnpackagedOriginalToJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        rightClickContextMenu.SuspendLayout();
        SuspendLayout();
        // 
        // modContentTreeView
        // 
        modContentTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        modContentTreeView.Location = new System.Drawing.Point(12, 12);
        modContentTreeView.Name = "modContentTreeView";
        modContentTreeView.Size = new System.Drawing.Size(556, 866);
        modContentTreeView.TabIndex = 0;
        // 
        // rightClickContextMenu
        // 
        rightClickContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { openInExplorerContextMenuItem, openWorkspaceInExplorerToolStripMenuItem, toolStripSeparator1, exportToJsonToolStripMenuItem, exportUnpackagedOriginalToJsonToolStripMenuItem });
        rightClickContextMenu.Name = "rightClickContextMenu";
        rightClickContextMenu.ShowImageMargin = false;
        rightClickContextMenu.Size = new System.Drawing.Size(198, 98);
        // 
        // openInExplorerContextMenuItem
        // 
        openInExplorerContextMenuItem.Name = "openInExplorerContextMenuItem";
        openInExplorerContextMenuItem.Size = new System.Drawing.Size(197, 22);
        openInExplorerContextMenuItem.Text = "Open in Explorer";
        openInExplorerContextMenuItem.Click += openInExplorerContextMenuItem_Click;
        // 
        // openWorkspaceInExplorerToolStripMenuItem
        // 
        openWorkspaceInExplorerToolStripMenuItem.Name = "openWorkspaceInExplorerToolStripMenuItem";
        openWorkspaceInExplorerToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
        openWorkspaceInExplorerToolStripMenuItem.Text = "Open Workspace in Explorer";
        openWorkspaceInExplorerToolStripMenuItem.Click += openWorkspaceInExplorerToolStripMenuItem_Click;
        // 
        // exportToJsonToolStripMenuItem
        // 
        exportToJsonToolStripMenuItem.Name = "exportToJsonToolStripMenuItem";
        exportToJsonToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
        exportToJsonToolStripMenuItem.Text = "Export Modded to Json";
        exportToJsonToolStripMenuItem.Click += exportToJsonToolStripMenuItem_Click;
        // 
        // exportUnpackagedOriginalToJsonToolStripMenuItem
        // 
        exportUnpackagedOriginalToJsonToolStripMenuItem.Name = "exportUnpackagedOriginalToJsonToolStripMenuItem";
        exportUnpackagedOriginalToJsonToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
        exportUnpackagedOriginalToJsonToolStripMenuItem.Text = "Export Original to Json";
        exportUnpackagedOriginalToJsonToolStripMenuItem.Click += exportUnpackagedOriginalToJsonToolStripMenuItem_Click;
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
        // 
        // ActiveModContentViewer
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        AutoScroll = true;
        ClientSize = new System.Drawing.Size(580, 890);
        ControlBox = false;
        Controls.Add(modContentTreeView);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = System.Windows.Forms.FormStartPosition.Manual;
        Text = "Mod Content Viewer";
        rightClickContextMenu.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

    private System.Windows.Forms.ToolStripMenuItem exportUnpackagedOriginalToJsonToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem exportToJsonToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem openWorkspaceInExplorerToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem openInExplorerContextMenuItem;

    private System.Windows.Forms.ContextMenuStrip rightClickContextMenu;

    private System.Windows.Forms.TreeView modContentTreeView;

    #endregion
}