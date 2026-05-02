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
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        SettingsMenu = new System.Windows.Forms.ToolStripMenuItem();
        launchSetupModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        unpackGameFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        modsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        addNewModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        deleteActiveModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        StartUAssetGuiButton = new System.Windows.Forms.Button();
        StartFModelButton = new System.Windows.Forms.Button();
        modSelectionComboBox = new System.Windows.Forms.ComboBox();
        packageModButton = new System.Windows.Forms.Button();
        statusIndicationStrip = new System.Windows.Forms.StatusStrip();
        statusTextStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        currentToolStatusStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        currentWorkspaceToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        currentWorkspaceIndicatorStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        StartDDSToolsButton = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        modDescriptionRichTextbox = new System.Windows.Forms.RichTextBox();
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        StartUeLocresEditorButton = new System.Windows.Forms.Button();
        checkGameFilesForDifferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        menuStrip1.SuspendLayout();
        statusIndicationStrip.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
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
        SettingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { launchSetupModuleToolStripMenuItem });
        SettingsMenu.Name = "SettingsMenu";
        SettingsMenu.Size = new System.Drawing.Size(61, 20);
        SettingsMenu.Text = "Settings";
        // 
        // launchSetupModuleToolStripMenuItem
        // 
        launchSetupModuleToolStripMenuItem.Name = "launchSetupModuleToolStripMenuItem";
        launchSetupModuleToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
        launchSetupModuleToolStripMenuItem.Text = "Launch Setup Module";
        launchSetupModuleToolStripMenuItem.Click += launchSetupModuleToolStripMenuItem_Click;
        // 
        // utilitiesToolStripMenuItem
        // 
        utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { unpackGameFilesToolStripMenuItem, checkGameFilesForDifferencesToolStripMenuItem });
        utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
        utilitiesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
        utilitiesToolStripMenuItem.Text = "Utilities";
        // 
        // unpackGameFilesToolStripMenuItem
        // 
        unpackGameFilesToolStripMenuItem.Name = "unpackGameFilesToolStripMenuItem";
        unpackGameFilesToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
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
        StartUAssetGuiButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        StartUAssetGuiButton.AutoSize = true;
        StartUAssetGuiButton.Location = new System.Drawing.Point(516, 3);
        StartUAssetGuiButton.Name = "StartUAssetGuiButton";
        StartUAssetGuiButton.Size = new System.Drawing.Size(165, 25);
        StartUAssetGuiButton.TabIndex = 5;
        StartUAssetGuiButton.Text = "UAssetGUI";
        StartUAssetGuiButton.UseVisualStyleBackColor = true;
        StartUAssetGuiButton.Click += StartUAssetGuiButton_Click;
        // 
        // StartFModelButton
        // 
        StartFModelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        StartFModelButton.AutoSize = true;
        StartFModelButton.Location = new System.Drawing.Point(345, 3);
        StartFModelButton.Name = "StartFModelButton";
        StartFModelButton.Size = new System.Drawing.Size(165, 25);
        StartFModelButton.TabIndex = 8;
        StartFModelButton.Text = "FModel";
        StartFModelButton.UseVisualStyleBackColor = true;
        StartFModelButton.Click += StartFModelButton_Click;
        // 
        // modSelectionComboBox
        // 
        modSelectionComboBox.FormattingEnabled = true;
        modSelectionComboBox.Location = new System.Drawing.Point(12, 27);
        modSelectionComboBox.Name = "modSelectionComboBox";
        modSelectionComboBox.Size = new System.Drawing.Size(565, 23);
        modSelectionComboBox.TabIndex = 10;
        modSelectionComboBox.SelectedIndexChanged += modSelectionComboBox_SelectedIndexChanged;
        // 
        // packageModButton
        // 
        packageModButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        packageModButton.Location = new System.Drawing.Point(583, 27);
        packageModButton.Name = "packageModButton";
        packageModButton.Size = new System.Drawing.Size(204, 23);
        packageModButton.TabIndex = 11;
        packageModButton.Text = "Package Mod";
        packageModButton.UseVisualStyleBackColor = true;
        packageModButton.Click += packageModButton_Click;
        // 
        // statusIndicationStrip
        // 
        statusIndicationStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusTextStripStatusLabel, currentToolStatusStripStatusLabel, currentWorkspaceToolStripStatusLabel, currentWorkspaceIndicatorStripStatusLabel });
        statusIndicationStrip.Location = new System.Drawing.Point(0, 789);
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
        // currentWorkspaceToolStripStatusLabel
        // 
        currentWorkspaceToolStripStatusLabel.Name = "currentWorkspaceToolStripStatusLabel";
        currentWorkspaceToolStripStatusLabel.Size = new System.Drawing.Size(470, 17);
        currentWorkspaceToolStripStatusLabel.Spring = true;
        currentWorkspaceToolStripStatusLabel.Text = "Current Workspace:";
        currentWorkspaceToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // currentWorkspaceIndicatorStripStatusLabel
        // 
        currentWorkspaceIndicatorStripStatusLabel.Name = "currentWorkspaceIndicatorStripStatusLabel";
        currentWorkspaceIndicatorStripStatusLabel.Size = new System.Drawing.Size(164, 17);
        currentWorkspaceIndicatorStripStatusLabel.Text = "Currently Selected Workspace";
        // 
        // StartDDSToolsButton
        // 
        StartDDSToolsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        StartDDSToolsButton.AutoSize = true;
        StartDDSToolsButton.Location = new System.Drawing.Point(3, 3);
        StartDDSToolsButton.Name = "StartDDSToolsButton";
        StartDDSToolsButton.Size = new System.Drawing.Size(165, 25);
        StartDDSToolsButton.TabIndex = 13;
        StartDDSToolsButton.Text = "DDS Tools";
        StartDDSToolsButton.UseVisualStyleBackColor = true;
        StartDDSToolsButton.Click += StartDDSToolsButton_Click;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(12, 59);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(86, 23);
        label1.TabIndex = 14;
        label1.Text = "Tool Launcher";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // modDescriptionRichTextbox
        // 
        modDescriptionRichTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        modDescriptionRichTextbox.Location = new System.Drawing.Point(12, 91);
        modDescriptionRichTextbox.Name = "modDescriptionRichTextbox";
        modDescriptionRichTextbox.Size = new System.Drawing.Size(775, 685);
        modDescriptionRichTextbox.TabIndex = 15;
        modDescriptionRichTextbox.Text = "";
        modDescriptionRichTextbox.TextChanged += modDescriptionRichTextbox_TextChanged;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        tableLayoutPanel1.AutoSize = true;
        tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        tableLayoutPanel1.ColumnCount = 4;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
        tableLayoutPanel1.Controls.Add(StartUeLocresEditorButton, 1, 0);
        tableLayoutPanel1.Controls.Add(StartDDSToolsButton, 0, 0);
        tableLayoutPanel1.Controls.Add(StartUAssetGuiButton, 3, 0);
        tableLayoutPanel1.Controls.Add(StartFModelButton, 2, 0);
        tableLayoutPanel1.Location = new System.Drawing.Point(106, 54);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new System.Drawing.Size(684, 31);
        tableLayoutPanel1.TabIndex = 16;
        // 
        // StartUeLocresEditorButton
        // 
        StartUeLocresEditorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        StartUeLocresEditorButton.AutoSize = true;
        StartUeLocresEditorButton.Location = new System.Drawing.Point(174, 3);
        StartUeLocresEditorButton.Name = "StartUeLocresEditorButton";
        StartUeLocresEditorButton.Size = new System.Drawing.Size(165, 25);
        StartUeLocresEditorButton.TabIndex = 17;
        StartUeLocresEditorButton.Text = "UE Locres Editor";
        StartUeLocresEditorButton.UseVisualStyleBackColor = true;
        StartUeLocresEditorButton.Click += StartUeLocresEditorButton_Click;
        // 
        // checkGameFilesForDifferencesToolStripMenuItem
        // 
        checkGameFilesForDifferencesToolStripMenuItem.Name = "checkGameFilesForDifferencesToolStripMenuItem";
        checkGameFilesForDifferencesToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
        checkGameFilesForDifferencesToolStripMenuItem.Text = "Check Game Files for Differences";
        checkGameFilesForDifferencesToolStripMenuItem.Click += checkGameFilesForDifferencesToolStripMenuItem_Click;
        // 
        // MainUi
        // 
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        ClientSize = new System.Drawing.Size(799, 811);
        Controls.Add(modDescriptionRichTextbox);
        Controls.Add(label1);
        Controls.Add(packageModButton);
        Controls.Add(modSelectionComboBox);
        Controls.Add(menuStrip1);
        Controls.Add(statusIndicationStrip);
        Controls.Add(tableLayoutPanel1);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        MainMenuStrip = menuStrip1;
        Text = "Code Vein 2 Modding Framework Tool";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        statusIndicationStrip.ResumeLayout(false);
        statusIndicationStrip.PerformLayout();
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem checkGameFilesForDifferencesToolStripMenuItem;

    private System.Windows.Forms.Button StartUeLocresEditorButton;

    private System.Windows.Forms.ToolStripStatusLabel currentWorkspaceIndicatorStripStatusLabel;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    private System.Windows.Forms.RichTextBox modDescriptionRichTextbox;

    private System.Windows.Forms.ToolStripStatusLabel currentWorkspaceToolStripStatusLabel;

    private System.Windows.Forms.ToolStripMenuItem launchSetupModuleToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem modsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addNewModToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem deleteActiveModToolStripMenuItem;

    private System.Windows.Forms.Button StartDDSToolsButton;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.ToolStripStatusLabel currentToolStatusStripStatusLabel;

    private System.Windows.Forms.ToolStripStatusLabel statusTextStripStatusLabel;

    private System.Windows.Forms.StatusStrip statusIndicationStrip;

    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem unpackGameFilesToolStripMenuItem;

    private System.Windows.Forms.ComboBox modSelectionComboBox;
    private System.Windows.Forms.Button packageModButton;

    private System.Windows.Forms.Button StartFModelButton;

    private System.Windows.Forms.Button StartUAssetGuiButton;

    private System.Windows.Forms.ToolStripMenuItem SettingsMenu;

    private System.Windows.Forms.MenuStrip menuStrip1;

    #endregion
}