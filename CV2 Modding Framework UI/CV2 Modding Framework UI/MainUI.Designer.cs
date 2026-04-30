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
        workspaceBrowseButton = new System.Windows.Forms.Button();
        workspaceLocation = new System.Windows.Forms.TextBox();
        createSysLinkButton = new System.Windows.Forms.Button();
        sysLinkTextBox = new System.Windows.Forms.TextBox();
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        SettingsMenu = new System.Windows.Forms.ToolStripMenuItem();
        UAssetGUIMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        FModelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        retocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        unpackGameFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        StartUAssetGuiButton = new System.Windows.Forms.Button();
        buttonBrowseSymLinkDestination = new System.Windows.Forms.Button();
        textBoxSymLinkDestination = new System.Windows.Forms.TextBox();
        StartFModelButton = new System.Windows.Forms.Button();
        buttonCreateSymLink = new System.Windows.Forms.Button();
        modSelectionComboBox = new System.Windows.Forms.ComboBox();
        packageModButton = new System.Windows.Forms.Button();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // workspaceBrowseButton
        // 
        workspaceBrowseButton.Location = new System.Drawing.Point(583, 25);
        workspaceBrowseButton.Name = "workspaceBrowseButton";
        workspaceBrowseButton.Size = new System.Drawing.Size(205, 23);
        workspaceBrowseButton.TabIndex = 0;
        workspaceBrowseButton.Text = "Select Active Workspace";
        workspaceBrowseButton.UseVisualStyleBackColor = true;
        workspaceBrowseButton.Click += browseWorkspaceLocation_Click;
        // 
        // workspaceLocation
        // 
        workspaceLocation.BackColor = System.Drawing.SystemColors.Window;
        workspaceLocation.Location = new System.Drawing.Point(12, 25);
        workspaceLocation.Name = "workspaceLocation";
        workspaceLocation.ReadOnly = true;
        workspaceLocation.Size = new System.Drawing.Size(565, 23);
        workspaceLocation.TabIndex = 1;
        workspaceLocation.Text = "Select your modding workplace location...";
        // 
        // createSysLinkButton
        // 
        createSysLinkButton.Location = new System.Drawing.Point(583, 54);
        createSysLinkButton.Name = "createSysLinkButton";
        createSysLinkButton.Size = new System.Drawing.Size(205, 23);
        createSysLinkButton.TabIndex = 2;
        createSysLinkButton.Text = "Browse Vanilla Paks";
        createSysLinkButton.UseVisualStyleBackColor = true;
        createSysLinkButton.Click += createSysLink_Click;
        // 
        // sysLinkTextBox
        // 
        sysLinkTextBox.AcceptsReturn = true;
        sysLinkTextBox.BackColor = System.Drawing.SystemColors.Window;
        sysLinkTextBox.Location = new System.Drawing.Point(12, 52);
        sysLinkTextBox.Multiline = true;
        sysLinkTextBox.Name = "sysLinkTextBox";
        sysLinkTextBox.ReadOnly = true;
        sysLinkTextBox.Size = new System.Drawing.Size(565, 23);
        sysLinkTextBox.TabIndex = 3;
        sysLinkTextBox.Text = "Select all the vanilla game files contained in the pak folder...";
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { SettingsMenu, utilitiesToolStripMenuItem });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(800, 24);
        menuStrip1.TabIndex = 4;
        menuStrip1.Text = "menuStrip1";
        // 
        // SettingsMenu
        // 
        SettingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { UAssetGUIMenuItem, FModelMenuItem, retocToolStripMenuItem });
        SettingsMenu.Name = "SettingsMenu";
        SettingsMenu.Size = new System.Drawing.Size(61, 20);
        SettingsMenu.Text = "Settings";
        // 
        // UAssetGUIMenuItem
        // 
        UAssetGUIMenuItem.Name = "UAssetGUIMenuItem";
        UAssetGUIMenuItem.Size = new System.Drawing.Size(129, 22);
        UAssetGUIMenuItem.Text = "UAssetGUI";
        UAssetGUIMenuItem.Click += UAssetGUIMenuItem_Click;
        // 
        // FModelMenuItem
        // 
        FModelMenuItem.Name = "FModelMenuItem";
        FModelMenuItem.Size = new System.Drawing.Size(129, 22);
        FModelMenuItem.Text = "FModel";
        FModelMenuItem.Click += FModelMenuItem_Click;
        // 
        // retocToolStripMenuItem
        // 
        retocToolStripMenuItem.Name = "retocToolStripMenuItem";
        retocToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
        retocToolStripMenuItem.Text = "Retoc";
        retocToolStripMenuItem.Click += RetocToolStripMenuItemClick;
        // 
        // utilitiesToolStripMenuItem
        // 
        utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { unpackGameFilesToolStripMenuItem });
        utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
        utilitiesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
        utilitiesToolStripMenuItem.Text = "Utilities";
        // 
        // unpackGameFilesToolStripMenuItem
        // 
        unpackGameFilesToolStripMenuItem.Name = "unpackGameFilesToolStripMenuItem";
        unpackGameFilesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        unpackGameFilesToolStripMenuItem.Text = "Unpack Game Files";
        unpackGameFilesToolStripMenuItem.Click += unpackGameFilesToolStripMenuItem_Click;
        // 
        // StartUAssetGuiButton
        // 
        StartUAssetGuiButton.Location = new System.Drawing.Point(668, 415);
        StartUAssetGuiButton.Name = "StartUAssetGuiButton";
        StartUAssetGuiButton.Size = new System.Drawing.Size(120, 23);
        StartUAssetGuiButton.TabIndex = 5;
        StartUAssetGuiButton.Text = "Start UAssetGUI";
        StartUAssetGuiButton.UseVisualStyleBackColor = true;
        StartUAssetGuiButton.Click += StartUAssetGuiButton_Click;
        // 
        // buttonBrowseSymLinkDestination
        // 
        buttonBrowseSymLinkDestination.Location = new System.Drawing.Point(583, 80);
        buttonBrowseSymLinkDestination.Name = "buttonBrowseSymLinkDestination";
        buttonBrowseSymLinkDestination.Size = new System.Drawing.Size(205, 23);
        buttonBrowseSymLinkDestination.TabIndex = 6;
        buttonBrowseSymLinkDestination.Text = "Browse SymLink Destination";
        buttonBrowseSymLinkDestination.UseVisualStyleBackColor = true;
        buttonBrowseSymLinkDestination.Click += buttonBrowseSymLinkDestination_Click;
        // 
        // textBoxSymLinkDestination
        // 
        textBoxSymLinkDestination.BackColor = System.Drawing.SystemColors.Window;
        textBoxSymLinkDestination.Location = new System.Drawing.Point(12, 81);
        textBoxSymLinkDestination.Name = "textBoxSymLinkDestination";
        textBoxSymLinkDestination.ReadOnly = true;
        textBoxSymLinkDestination.Size = new System.Drawing.Size(565, 23);
        textBoxSymLinkDestination.TabIndex = 7;
        textBoxSymLinkDestination.Text = "Select the destination folder for the vanilla files SymLink creation...";
        // 
        // StartFModelButton
        // 
        StartFModelButton.Location = new System.Drawing.Point(542, 415);
        StartFModelButton.Name = "StartFModelButton";
        StartFModelButton.Size = new System.Drawing.Size(120, 23);
        StartFModelButton.TabIndex = 8;
        StartFModelButton.Text = "Start FModel";
        StartFModelButton.UseVisualStyleBackColor = true;
        StartFModelButton.Click += StartFModelButton_Click;
        // 
        // buttonCreateSymLink
        // 
        buttonCreateSymLink.Location = new System.Drawing.Point(12, 110);
        buttonCreateSymLink.Name = "buttonCreateSymLink";
        buttonCreateSymLink.Size = new System.Drawing.Size(776, 23);
        buttonCreateSymLink.TabIndex = 9;
        buttonCreateSymLink.Text = "Create or Update SymLink";
        buttonCreateSymLink.UseVisualStyleBackColor = true;
        buttonCreateSymLink.Click += buttonCreateSymLink_Click;
        // 
        // modSelectionComboBox
        // 
        modSelectionComboBox.FormattingEnabled = true;
        modSelectionComboBox.Location = new System.Drawing.Point(15, 139);
        modSelectionComboBox.Name = "modSelectionComboBox";
        modSelectionComboBox.Size = new System.Drawing.Size(562, 23);
        modSelectionComboBox.TabIndex = 10;
        modSelectionComboBox.SelectedIndexChanged += modSelectionComboBox_SelectedIndexChanged;
        // 
        // packageModButton
        // 
        packageModButton.Location = new System.Drawing.Point(583, 138);
        packageModButton.Name = "packageModButton";
        packageModButton.Size = new System.Drawing.Size(205, 23);
        packageModButton.TabIndex = 11;
        packageModButton.Text = "Package Mod";
        packageModButton.UseVisualStyleBackColor = true;
        packageModButton.Click += packageModButton_Click;
        // 
        // MainUi
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(packageModButton);
        Controls.Add(modSelectionComboBox);
        Controls.Add(buttonCreateSymLink);
        Controls.Add(StartFModelButton);
        Controls.Add(textBoxSymLinkDestination);
        Controls.Add(buttonBrowseSymLinkDestination);
        Controls.Add(StartUAssetGuiButton);
        Controls.Add(sysLinkTextBox);
        Controls.Add(createSysLinkButton);
        Controls.Add(workspaceLocation);
        Controls.Add(workspaceBrowseButton);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Text = "Code Vein 2 Modding Framework Tool";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem unpackGameFilesToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem retocToolStripMenuItem;

    private System.Windows.Forms.ComboBox modSelectionComboBox;
    private System.Windows.Forms.Button packageModButton;

    private System.Windows.Forms.Button buttonCreateSymLink;

    private System.Windows.Forms.Button StartFModelButton;

    private System.Windows.Forms.TextBox textBoxSymLinkDestination;

    private System.Windows.Forms.Button buttonBrowseSymLinkDestination;

    private System.Windows.Forms.Button StartUAssetGuiButton;

    private System.Windows.Forms.ToolStripMenuItem FModelMenuItem;

    private System.Windows.Forms.ToolStripMenuItem UAssetGUIMenuItem;

    private System.Windows.Forms.ToolStripMenuItem SettingsMenu;

    private System.Windows.Forms.MenuStrip menuStrip1;

    private System.Windows.Forms.Button createSysLinkButton;
    private System.Windows.Forms.TextBox sysLinkTextBox;

    private System.Windows.Forms.Button workspaceBrowseButton;
    private System.Windows.Forms.TextBox workspaceLocation;

    #endregion
}