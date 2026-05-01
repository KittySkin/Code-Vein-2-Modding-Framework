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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUi));
        workspaceBrowseButton = new System.Windows.Forms.Button();
        workspaceLocation = new System.Windows.Forms.TextBox();
        createSysLinkButton = new System.Windows.Forms.Button();
        sysLinkTextBox = new System.Windows.Forms.TextBox();
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        SettingsMenu = new System.Windows.Forms.ToolStripMenuItem();
        UAssetGUIMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        FModelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        retocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        DDSToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        unpackGameFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        modsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        addNewModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        deleteActiveModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        StartUAssetGuiButton = new System.Windows.Forms.Button();
        buttonBrowseSymLinkDestination = new System.Windows.Forms.Button();
        textBoxSymLinkDestination = new System.Windows.Forms.TextBox();
        StartFModelButton = new System.Windows.Forms.Button();
        buttonCreateSymLink = new System.Windows.Forms.Button();
        modSelectionComboBox = new System.Windows.Forms.ComboBox();
        packageModButton = new System.Windows.Forms.Button();
        statusIndicationStrip = new System.Windows.Forms.StatusStrip();
        statusTextStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        currentToolStatusStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        StartDDSToolsButton = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        menuStrip1.SuspendLayout();
        statusIndicationStrip.SuspendLayout();
        SuspendLayout();
        // 
        // workspaceBrowseButton
        // 
        workspaceBrowseButton.Location = new System.Drawing.Point(583, 24);
        workspaceBrowseButton.Name = "workspaceBrowseButton";
        workspaceBrowseButton.Size = new System.Drawing.Size(204, 23);
        workspaceBrowseButton.TabIndex = 0;
        workspaceBrowseButton.Text = "Select Active Workspace";
        workspaceBrowseButton.UseVisualStyleBackColor = true;
        workspaceBrowseButton.Click += browseWorkspaceLocation_Click;
        // 
        // workspaceLocation
        // 
        workspaceLocation.BackColor = System.Drawing.SystemColors.Window;
        workspaceLocation.Location = new System.Drawing.Point(12, 23);
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
        createSysLinkButton.Size = new System.Drawing.Size(204, 23);
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
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { SettingsMenu, utilitiesToolStripMenuItem, modsToolStripMenuItem, helpToolStripMenuItem });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(799, 24);
        menuStrip1.TabIndex = 4;
        menuStrip1.Text = "menuStrip1";
        // 
        // SettingsMenu
        // 
        SettingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { UAssetGUIMenuItem, FModelMenuItem, retocToolStripMenuItem, DDSToolsToolStripMenuItem });
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
        // DDSToolsToolStripMenuItem
        // 
        DDSToolsToolStripMenuItem.Name = "DDSToolsToolStripMenuItem";
        DDSToolsToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
        DDSToolsToolStripMenuItem.Text = "DDS Tools";
        DDSToolsToolStripMenuItem.Click += DDSToolsToolStripMenuItem_Click;
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
        unpackGameFilesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
        unpackGameFilesToolStripMenuItem.Text = "Unpack Game Files";
        unpackGameFilesToolStripMenuItem.Click += unpackGameFilesToolStripMenuItem_Click;
        // 
        // modsToolStripMenuItem
        // 
        modsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { addNewModToolStripMenuItem, deleteActiveModToolStripMenuItem });
        modsToolStripMenuItem.Name = "modsToolStripMenuItem";
        modsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
        modsToolStripMenuItem.Text = "Mods";
        // 
        // addNewModToolStripMenuItem
        // 
        addNewModToolStripMenuItem.Name = "addNewModToolStripMenuItem";
        addNewModToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
        addNewModToolStripMenuItem.Text = "Add New Mod";
        addNewModToolStripMenuItem.Click += addNewModToolStripMenuItem_Click;
        // 
        // deleteActiveModToolStripMenuItem
        // 
        deleteActiveModToolStripMenuItem.Name = "deleteActiveModToolStripMenuItem";
        deleteActiveModToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
        deleteActiveModToolStripMenuItem.Text = "Delete Active Mod";
        deleteActiveModToolStripMenuItem.Click += deleteActiveModToolStripMenuItem_Click;
        // 
        // helpToolStripMenuItem
        // 
        helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutToolStripMenuItem });
        helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
        helpToolStripMenuItem.Text = "Help";
        // 
        // aboutToolStripMenuItem
        // 
        aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
        aboutToolStripMenuItem.Text = "About";
        aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
        // 
        // StartUAssetGuiButton
        // 
        StartUAssetGuiButton.Location = new System.Drawing.Point(667, 167);
        StartUAssetGuiButton.Name = "StartUAssetGuiButton";
        StartUAssetGuiButton.Size = new System.Drawing.Size(120, 23);
        StartUAssetGuiButton.TabIndex = 5;
        StartUAssetGuiButton.Text = "UAssetGUI";
        StartUAssetGuiButton.UseVisualStyleBackColor = true;
        StartUAssetGuiButton.Click += StartUAssetGuiButton_Click;
        // 
        // buttonBrowseSymLinkDestination
        // 
        buttonBrowseSymLinkDestination.Location = new System.Drawing.Point(583, 80);
        buttonBrowseSymLinkDestination.Name = "buttonBrowseSymLinkDestination";
        buttonBrowseSymLinkDestination.Size = new System.Drawing.Size(204, 23);
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
        StartFModelButton.Location = new System.Drawing.Point(541, 168);
        StartFModelButton.Name = "StartFModelButton";
        StartFModelButton.Size = new System.Drawing.Size(120, 23);
        StartFModelButton.TabIndex = 8;
        StartFModelButton.Text = "FModel";
        StartFModelButton.UseVisualStyleBackColor = true;
        StartFModelButton.Click += StartFModelButton_Click;
        // 
        // buttonCreateSymLink
        // 
        buttonCreateSymLink.Location = new System.Drawing.Point(12, 110);
        buttonCreateSymLink.Name = "buttonCreateSymLink";
        buttonCreateSymLink.Size = new System.Drawing.Size(775, 23);
        buttonCreateSymLink.TabIndex = 9;
        buttonCreateSymLink.Text = "Create or Update SymLink";
        buttonCreateSymLink.UseVisualStyleBackColor = true;
        buttonCreateSymLink.Click += buttonCreateSymLink_Click;
        // 
        // modSelectionComboBox
        // 
        modSelectionComboBox.FormattingEnabled = true;
        modSelectionComboBox.Location = new System.Drawing.Point(12, 138);
        modSelectionComboBox.Name = "modSelectionComboBox";
        modSelectionComboBox.Size = new System.Drawing.Size(565, 23);
        modSelectionComboBox.TabIndex = 10;
        modSelectionComboBox.SelectedIndexChanged += modSelectionComboBox_SelectedIndexChanged;
        // 
        // packageModButton
        // 
        packageModButton.Location = new System.Drawing.Point(583, 138);
        packageModButton.Name = "packageModButton";
        packageModButton.Size = new System.Drawing.Size(204, 23);
        packageModButton.TabIndex = 11;
        packageModButton.Text = "Package Mod";
        packageModButton.UseVisualStyleBackColor = true;
        packageModButton.Click += packageModButton_Click;
        // 
        // statusIndicationStrip
        // 
        statusIndicationStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusTextStripStatusLabel, currentToolStatusStripStatusLabel });
        statusIndicationStrip.Location = new System.Drawing.Point(0, 196);
        statusIndicationStrip.Name = "statusIndicationStrip";
        statusIndicationStrip.Size = new System.Drawing.Size(799, 22);
        statusIndicationStrip.SizingGrip = false;
        statusIndicationStrip.TabIndex = 12;
        statusIndicationStrip.Text = "statusStrip1";
        // 
        // statusTextStripStatusLabel
        // 
        statusTextStripStatusLabel.Name = "statusTextStripStatusLabel";
        statusTextStripStatusLabel.Size = new System.Drawing.Size(42, 17);
        statusTextStripStatusLabel.Text = "Status:";
        // 
        // currentToolStatusStripStatusLabel
        // 
        currentToolStatusStripStatusLabel.Name = "currentToolStatusStripStatusLabel";
        currentToolStatusStripStatusLabel.Size = new System.Drawing.Size(108, 17);
        currentToolStatusStripStatusLabel.Text = "Current Tool Status";
        // 
        // StartDDSToolsButton
        // 
        StartDDSToolsButton.Location = new System.Drawing.Point(415, 168);
        StartDDSToolsButton.Name = "StartDDSToolsButton";
        StartDDSToolsButton.Size = new System.Drawing.Size(120, 23);
        StartDDSToolsButton.TabIndex = 13;
        StartDDSToolsButton.Text = "DDS Tools";
        StartDDSToolsButton.UseVisualStyleBackColor = true;
        StartDDSToolsButton.Click += StartDDSToolsButton_Click;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(12, 168);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(86, 23);
        label1.TabIndex = 14;
        label1.Text = "Tool Launcher";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // MainUi
        // 
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        ClientSize = new System.Drawing.Size(799, 218);
        Controls.Add(label1);
        Controls.Add(packageModButton);
        Controls.Add(modSelectionComboBox);
        Controls.Add(buttonCreateSymLink);
        Controls.Add(textBoxSymLinkDestination);
        Controls.Add(buttonBrowseSymLinkDestination);
        Controls.Add(sysLinkTextBox);
        Controls.Add(createSysLinkButton);
        Controls.Add(workspaceLocation);
        Controls.Add(workspaceBrowseButton);
        Controls.Add(menuStrip1);
        Controls.Add(StartDDSToolsButton);
        Controls.Add(StartFModelButton);
        Controls.Add(StartUAssetGuiButton);
        Controls.Add(statusIndicationStrip);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        MainMenuStrip = menuStrip1;
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(815, 257);
        MinimumSize = new System.Drawing.Size(815, 257);
        Text = "Code Vein 2 Modding Framework Tool";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        statusIndicationStrip.ResumeLayout(false);
        statusIndicationStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem modsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addNewModToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem deleteActiveModToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem DDSToolsToolStripMenuItem;

    private System.Windows.Forms.Button StartDDSToolsButton;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.ToolStripStatusLabel currentToolStatusStripStatusLabel;

    private System.Windows.Forms.ToolStripStatusLabel statusTextStripStatusLabel;

    private System.Windows.Forms.StatusStrip statusIndicationStrip;

    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

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