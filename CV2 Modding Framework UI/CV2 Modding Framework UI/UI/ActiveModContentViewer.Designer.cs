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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiveModContentViewer));
        modContentTreeView = new System.Windows.Forms.TreeView();
        SuspendLayout();
        // 
        // modContentTreeView
        // 
        modContentTreeView.Location = new System.Drawing.Point(12, 12);
        modContentTreeView.Name = "modContentTreeView";
        modContentTreeView.Size = new System.Drawing.Size(556, 866);
        modContentTreeView.TabIndex = 0;
        // 
        // ActiveModContentViewer
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(580, 890);
        ControlBox = false;
        Controls.Add(modContentTreeView);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Text = "Mod Content Viewer";
        ResumeLayout(false);
    }

    private System.Windows.Forms.TreeView modContentTreeView;

    #endregion
}