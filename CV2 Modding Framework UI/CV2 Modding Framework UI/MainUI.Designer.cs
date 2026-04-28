namespace CV2_Modding_Framework_UI;

partial class MainUi
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        browseModFolder = new System.Windows.Forms.Button();
        modFolderLocation = new System.Windows.Forms.TextBox();
        createSysLinkButton = new System.Windows.Forms.Button();
        sysLinkTextBox = new System.Windows.Forms.TextBox();
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        SettingsMenu = new System.Windows.Forms.ToolStripMenuItem();
        UAssetGUIMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
        StartUAssetGuiButton = new System.Windows.Forms.Button();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // browseModFolder
        // 
        browseModFolder.Location = new System.Drawing.Point(676, 25);
        browseModFolder.Name = "browseModFolder";
        browseModFolder.Size = new System.Drawing.Size(112, 23);
        browseModFolder.TabIndex = 0;
        browseModFolder.Text = "Browse";
        browseModFolder.UseVisualStyleBackColor = true;
        browseModFolder.Click += browseModFolder_Click;
        // 
        // modFolderLocation
        // 
        modFolderLocation.BackColor = System.Drawing.SystemColors.Window;
        modFolderLocation.Location = new System.Drawing.Point(12, 25);
        modFolderLocation.Name = "modFolderLocation";
        modFolderLocation.ReadOnly = true;
        modFolderLocation.Size = new System.Drawing.Size(658, 23);
        modFolderLocation.TabIndex = 1;
        modFolderLocation.Text = "Select your mod folder location...";
        modFolderLocation.TextChanged += modFolderLocation_TextChanged;
        // 
        // createSysLinkButton
        // 
        createSysLinkButton.Location = new System.Drawing.Point(677, 54);
        createSysLinkButton.Name = "createSysLinkButton";
        createSysLinkButton.Size = new System.Drawing.Size(111, 23);
        createSysLinkButton.TabIndex = 2;
        createSysLinkButton.Text = "Create SysLink";
        createSysLinkButton.UseVisualStyleBackColor = true;
        createSysLinkButton.Click += createSysLink_Click;
        // 
        // sysLinkTextBox
        // 
        sysLinkTextBox.BackColor = System.Drawing.SystemColors.Window;
        sysLinkTextBox.Location = new System.Drawing.Point(12, 54);
        sysLinkTextBox.Multiline = true;
        sysLinkTextBox.Name = "sysLinkTextBox";
        sysLinkTextBox.ReadOnly = true;
        sysLinkTextBox.Size = new System.Drawing.Size(659, 23);
        sysLinkTextBox.TabIndex = 3;
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { SettingsMenu });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(800, 24);
        menuStrip1.TabIndex = 4;
        menuStrip1.Text = "menuStrip1";
        // 
        // SettingsMenu
        // 
        SettingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { UAssetGUIMenuItem, toolStripMenuItem2 });
        SettingsMenu.Name = "SettingsMenu";
        SettingsMenu.Size = new System.Drawing.Size(61, 20);
        SettingsMenu.Text = "Settings";
        // 
        // UAssetGUIMenuItem
        // 
        UAssetGUIMenuItem.Name = "UAssetGUIMenuItem";
        UAssetGUIMenuItem.Size = new System.Drawing.Size(180, 22);
        UAssetGUIMenuItem.Text = "UAssetGUI";
        UAssetGUIMenuItem.Click += UAssetGUIMenuItem_Click;
        // 
        // toolStripMenuItem2
        // 
        toolStripMenuItem2.Name = "toolStripMenuItem2";
        toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
        toolStripMenuItem2.Text = "toolStripMenuItem2";
        // 
        // StartUAssetGuiButton
        // 
        StartUAssetGuiButton.Location = new System.Drawing.Point(677, 415);
        StartUAssetGuiButton.Name = "StartUAssetGuiButton";
        StartUAssetGuiButton.Size = new System.Drawing.Size(111, 23);
        StartUAssetGuiButton.TabIndex = 5;
        StartUAssetGuiButton.Text = "Start UAssetGUI";
        StartUAssetGuiButton.UseVisualStyleBackColor = true;
        StartUAssetGuiButton.Click += StartUAssetGuiButton_Click;
        // 
        // MainUI
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(StartUAssetGuiButton);
        Controls.Add(sysLinkTextBox);
        Controls.Add(createSysLinkButton);
        Controls.Add(modFolderLocation);
        Controls.Add(browseModFolder);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Text = "Code Vein 2 Modding Framework Tool";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button StartUAssetGuiButton;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

    private System.Windows.Forms.ToolStripMenuItem UAssetGUIMenuItem;

    private System.Windows.Forms.ToolStripMenuItem SettingsMenu;

    private System.Windows.Forms.MenuStrip menuStrip1;

    private System.Windows.Forms.Button createSysLinkButton;
    private System.Windows.Forms.TextBox sysLinkTextBox;

    private System.Windows.Forms.Button browseModFolder;
    private System.Windows.Forms.TextBox modFolderLocation;

    #endregion
}