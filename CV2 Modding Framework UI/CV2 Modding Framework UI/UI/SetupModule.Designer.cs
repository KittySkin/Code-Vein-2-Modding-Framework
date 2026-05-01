using System.ComponentModel;

namespace CV2_Modding_Framework_UI.UI;

partial class SetupModule
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupModule));
        createOrUpdateSymLinkButton = new System.Windows.Forms.Button();
        retocPathTextBox = new System.Windows.Forms.TextBox();
        selectDdsToolsLocationButton = new System.Windows.Forms.Button();
        selectEncryptionToolButton = new System.Windows.Forms.Button();
        selectLocresToolButton = new System.Windows.Forms.Button();
        selectRetocLocationButton = new System.Windows.Forms.Button();
        selectFModelLocationButton = new System.Windows.Forms.Button();
        selectUAssetGuiLocationButton = new System.Windows.Forms.Button();
        browseSymLinkDestinationButton = new System.Windows.Forms.Button();
        browseVanillaPacksButton = new System.Windows.Forms.Button();
        selectActiveWorkspaceButton = new System.Windows.Forms.Button();
        locresToolPathTextBox = new System.Windows.Forms.TextBox();
        ddsToolsPathTextBox = new System.Windows.Forms.TextBox();
        fModelPathTextBox = new System.Windows.Forms.TextBox();
        uAssetGuiPathTextBox = new System.Windows.Forms.TextBox();
        encryptionToolPathTextBox = new System.Windows.Forms.TextBox();
        symLinkLocationTextBox = new System.Windows.Forms.TextBox();
        vanillaPaksLocationTextBox = new System.Windows.Forms.TextBox();
        activeWorkspaceTextBox = new System.Windows.Forms.TextBox();
        closeSetupModuleButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // createOrUpdateSymLinkButton
        // 
        createOrUpdateSymLinkButton.Location = new System.Drawing.Point(12, 99);
        createOrUpdateSymLinkButton.Name = "createOrUpdateSymLinkButton";
        createOrUpdateSymLinkButton.Size = new System.Drawing.Size(776, 23);
        createOrUpdateSymLinkButton.TabIndex = 19;
        createOrUpdateSymLinkButton.Text = "Create or Update SymLink";
        createOrUpdateSymLinkButton.UseVisualStyleBackColor = true;
        createOrUpdateSymLinkButton.Click += createOrUpdateSymLinkButton_Click;
        // 
        // retocPathTextBox
        // 
        retocPathTextBox.BackColor = System.Drawing.SystemColors.Window;
        retocPathTextBox.Location = new System.Drawing.Point(12, 186);
        retocPathTextBox.Name = "retocPathTextBox";
        retocPathTextBox.ReadOnly = true;
        retocPathTextBox.Size = new System.Drawing.Size(565, 23);
        retocPathTextBox.TabIndex = 37;
        retocPathTextBox.Text = "Select retoc.exe file...";
        // 
        // selectDdsToolsLocationButton
        // 
        selectDdsToolsLocationButton.Location = new System.Drawing.Point(583, 215);
        selectDdsToolsLocationButton.Name = "selectDdsToolsLocationButton";
        selectDdsToolsLocationButton.Size = new System.Drawing.Size(205, 23);
        selectDdsToolsLocationButton.TabIndex = 36;
        selectDdsToolsLocationButton.Text = "Select DDS Tools Location";
        selectDdsToolsLocationButton.UseVisualStyleBackColor = true;
        selectDdsToolsLocationButton.Click += selectDdsToolsLocationButton_Click;
        // 
        // selectEncryptionToolButton
        // 
        selectEncryptionToolButton.Location = new System.Drawing.Point(583, 272);
        selectEncryptionToolButton.Name = "selectEncryptionToolButton";
        selectEncryptionToolButton.Size = new System.Drawing.Size(205, 23);
        selectEncryptionToolButton.TabIndex = 35;
        selectEncryptionToolButton.Text = "Select Encryption Tool Location";
        selectEncryptionToolButton.UseVisualStyleBackColor = true;
        selectEncryptionToolButton.Click += selectEncryptionToolButton_Click;
        // 
        // selectLocresToolButton
        // 
        selectLocresToolButton.Location = new System.Drawing.Point(583, 244);
        selectLocresToolButton.Name = "selectLocresToolButton";
        selectLocresToolButton.Size = new System.Drawing.Size(205, 23);
        selectLocresToolButton.TabIndex = 34;
        selectLocresToolButton.Text = "Select Locres Tool Location";
        selectLocresToolButton.UseVisualStyleBackColor = true;
        selectLocresToolButton.Click += selectLocresToolButton_Click;
        // 
        // selectRetocLocationButton
        // 
        selectRetocLocationButton.Location = new System.Drawing.Point(583, 186);
        selectRetocLocationButton.Name = "selectRetocLocationButton";
        selectRetocLocationButton.Size = new System.Drawing.Size(205, 23);
        selectRetocLocationButton.TabIndex = 33;
        selectRetocLocationButton.Text = "Select retoc Location";
        selectRetocLocationButton.UseVisualStyleBackColor = true;
        selectRetocLocationButton.Click += selectRetocLocationButton_Click;
        // 
        // selectFModelLocationButton
        // 
        selectFModelLocationButton.Location = new System.Drawing.Point(583, 157);
        selectFModelLocationButton.Name = "selectFModelLocationButton";
        selectFModelLocationButton.Size = new System.Drawing.Size(205, 23);
        selectFModelLocationButton.TabIndex = 32;
        selectFModelLocationButton.Text = "Select FModel Location";
        selectFModelLocationButton.UseVisualStyleBackColor = true;
        selectFModelLocationButton.Click += selectFModelLocationButton_Click;
        // 
        // selectUAssetGuiLocationButton
        // 
        selectUAssetGuiLocationButton.Location = new System.Drawing.Point(583, 128);
        selectUAssetGuiLocationButton.Name = "selectUAssetGuiLocationButton";
        selectUAssetGuiLocationButton.Size = new System.Drawing.Size(205, 23);
        selectUAssetGuiLocationButton.TabIndex = 31;
        selectUAssetGuiLocationButton.Text = "Select UAssetGUI Location";
        selectUAssetGuiLocationButton.UseVisualStyleBackColor = true;
        selectUAssetGuiLocationButton.Click += selectUAssetGuiLocationButton_Click;
        // 
        // browseSymLinkDestinationButton
        // 
        browseSymLinkDestinationButton.Location = new System.Drawing.Point(583, 70);
        browseSymLinkDestinationButton.Name = "browseSymLinkDestinationButton";
        browseSymLinkDestinationButton.Size = new System.Drawing.Size(205, 23);
        browseSymLinkDestinationButton.TabIndex = 30;
        browseSymLinkDestinationButton.Text = "Browse SymLink Destination";
        browseSymLinkDestinationButton.UseVisualStyleBackColor = true;
        browseSymLinkDestinationButton.Click += browseSymLinkDestinationButton_Click;
        // 
        // browseVanillaPacksButton
        // 
        browseVanillaPacksButton.Location = new System.Drawing.Point(583, 41);
        browseVanillaPacksButton.Name = "browseVanillaPacksButton";
        browseVanillaPacksButton.Size = new System.Drawing.Size(205, 23);
        browseVanillaPacksButton.TabIndex = 29;
        browseVanillaPacksButton.Text = "Browse Vanilla Paks";
        browseVanillaPacksButton.UseVisualStyleBackColor = true;
        browseVanillaPacksButton.Click += browseVanillaPacksButton_Click;
        // 
        // selectActiveWorkspaceButton
        // 
        selectActiveWorkspaceButton.Location = new System.Drawing.Point(583, 12);
        selectActiveWorkspaceButton.Name = "selectActiveWorkspaceButton";
        selectActiveWorkspaceButton.Size = new System.Drawing.Size(205, 23);
        selectActiveWorkspaceButton.TabIndex = 28;
        selectActiveWorkspaceButton.Text = "Select Active Workspace";
        selectActiveWorkspaceButton.UseVisualStyleBackColor = true;
        selectActiveWorkspaceButton.Click += selectActiveWorkspaceButton_Click;
        // 
        // locresToolPathTextBox
        // 
        locresToolPathTextBox.BackColor = System.Drawing.SystemColors.Window;
        locresToolPathTextBox.Location = new System.Drawing.Point(12, 244);
        locresToolPathTextBox.Name = "locresToolPathTextBox";
        locresToolPathTextBox.ReadOnly = true;
        locresToolPathTextBox.Size = new System.Drawing.Size(565, 23);
        locresToolPathTextBox.TabIndex = 27;
        locresToolPathTextBox.Text = "Not supported yet...";
        // 
        // ddsToolsPathTextBox
        // 
        ddsToolsPathTextBox.BackColor = System.Drawing.SystemColors.Window;
        ddsToolsPathTextBox.Location = new System.Drawing.Point(12, 215);
        ddsToolsPathTextBox.Name = "ddsToolsPathTextBox";
        ddsToolsPathTextBox.ReadOnly = true;
        ddsToolsPathTextBox.Size = new System.Drawing.Size(565, 23);
        ddsToolsPathTextBox.TabIndex = 26;
        ddsToolsPathTextBox.Text = "Select DDS Tools GUI.exe file...";
        // 
        // fModelPathTextBox
        // 
        fModelPathTextBox.BackColor = System.Drawing.SystemColors.Window;
        fModelPathTextBox.Location = new System.Drawing.Point(12, 157);
        fModelPathTextBox.Name = "fModelPathTextBox";
        fModelPathTextBox.ReadOnly = true;
        fModelPathTextBox.Size = new System.Drawing.Size(565, 23);
        fModelPathTextBox.TabIndex = 25;
        fModelPathTextBox.Text = "Select the FModel.exe file...";
        // 
        // uAssetGuiPathTextBox
        // 
        uAssetGuiPathTextBox.BackColor = System.Drawing.SystemColors.Window;
        uAssetGuiPathTextBox.Location = new System.Drawing.Point(12, 128);
        uAssetGuiPathTextBox.Name = "uAssetGuiPathTextBox";
        uAssetGuiPathTextBox.ReadOnly = true;
        uAssetGuiPathTextBox.Size = new System.Drawing.Size(565, 23);
        uAssetGuiPathTextBox.TabIndex = 24;
        uAssetGuiPathTextBox.Text = "Select the UAssetGUI.exe file...";
        // 
        // encryptionToolPathTextBox
        // 
        encryptionToolPathTextBox.BackColor = System.Drawing.SystemColors.Window;
        encryptionToolPathTextBox.Location = new System.Drawing.Point(12, 273);
        encryptionToolPathTextBox.Name = "encryptionToolPathTextBox";
        encryptionToolPathTextBox.ReadOnly = true;
        encryptionToolPathTextBox.Size = new System.Drawing.Size(565, 23);
        encryptionToolPathTextBox.TabIndex = 23;
        encryptionToolPathTextBox.Text = "Not supported yet...";
        // 
        // symLinkLocationTextBox
        // 
        symLinkLocationTextBox.BackColor = System.Drawing.SystemColors.Window;
        symLinkLocationTextBox.Location = new System.Drawing.Point(12, 70);
        symLinkLocationTextBox.Name = "symLinkLocationTextBox";
        symLinkLocationTextBox.ReadOnly = true;
        symLinkLocationTextBox.Size = new System.Drawing.Size(565, 23);
        symLinkLocationTextBox.TabIndex = 22;
        symLinkLocationTextBox.Text = "Select the destination folder for the SymLinks to be created...";
        // 
        // vanillaPaksLocationTextBox
        // 
        vanillaPaksLocationTextBox.BackColor = System.Drawing.SystemColors.Window;
        vanillaPaksLocationTextBox.Location = new System.Drawing.Point(12, 41);
        vanillaPaksLocationTextBox.Multiline = true;
        vanillaPaksLocationTextBox.Name = "vanillaPaksLocationTextBox";
        vanillaPaksLocationTextBox.ReadOnly = true;
        vanillaPaksLocationTextBox.Size = new System.Drawing.Size(565, 23);
        vanillaPaksLocationTextBox.TabIndex = 21;
        vanillaPaksLocationTextBox.Text = "Select the vanilla gamefiles from the Paks folder...";
        // 
        // activeWorkspaceTextBox
        // 
        activeWorkspaceTextBox.BackColor = System.Drawing.SystemColors.Window;
        activeWorkspaceTextBox.Location = new System.Drawing.Point(12, 12);
        activeWorkspaceTextBox.Name = "activeWorkspaceTextBox";
        activeWorkspaceTextBox.ReadOnly = true;
        activeWorkspaceTextBox.Size = new System.Drawing.Size(565, 23);
        activeWorkspaceTextBox.TabIndex = 20;
        activeWorkspaceTextBox.Text = "Select your modding workspace here...";
        // 
        // closeSetupModuleButton
        // 
        closeSetupModuleButton.Location = new System.Drawing.Point(255, 335);
        closeSetupModuleButton.Name = "closeSetupModuleButton";
        closeSetupModuleButton.Size = new System.Drawing.Size(275, 66);
        closeSetupModuleButton.TabIndex = 38;
        closeSetupModuleButton.Text = "Close Setup Module";
        closeSetupModuleButton.UseVisualStyleBackColor = true;
        closeSetupModuleButton.Click += closeSetupModuleButton_Click;
        // 
        // SetupModule
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(closeSetupModuleButton);
        Controls.Add(retocPathTextBox);
        Controls.Add(selectDdsToolsLocationButton);
        Controls.Add(selectEncryptionToolButton);
        Controls.Add(selectLocresToolButton);
        Controls.Add(selectRetocLocationButton);
        Controls.Add(selectFModelLocationButton);
        Controls.Add(selectUAssetGuiLocationButton);
        Controls.Add(browseSymLinkDestinationButton);
        Controls.Add(browseVanillaPacksButton);
        Controls.Add(selectActiveWorkspaceButton);
        Controls.Add(locresToolPathTextBox);
        Controls.Add(ddsToolsPathTextBox);
        Controls.Add(fModelPathTextBox);
        Controls.Add(uAssetGuiPathTextBox);
        Controls.Add(encryptionToolPathTextBox);
        Controls.Add(symLinkLocationTextBox);
        Controls.Add(vanillaPaksLocationTextBox);
        Controls.Add(activeWorkspaceTextBox);
        Controls.Add(createOrUpdateSymLinkButton);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Location = new System.Drawing.Point(15, 15);
        MaximizeBox = false;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button closeSetupModuleButton;

    private System.Windows.Forms.Button createOrUpdateSymLinkButton;

    private System.Windows.Forms.Button selectDdsToolsLocationButton;
    private System.Windows.Forms.TextBox retocPathTextBox;

    private System.Windows.Forms.Button selectActiveWorkspaceButton;
    private System.Windows.Forms.Button browseVanillaPacksButton;
    private System.Windows.Forms.Button browseSymLinkDestinationButton;
    private System.Windows.Forms.Button selectUAssetGuiLocationButton;
    private System.Windows.Forms.Button selectFModelLocationButton;
    private System.Windows.Forms.Button selectRetocLocationButton;
    private System.Windows.Forms.Button selectLocresToolButton;
    private System.Windows.Forms.Button selectEncryptionToolButton;

    private System.Windows.Forms.TextBox activeWorkspaceTextBox;
    private System.Windows.Forms.TextBox vanillaPaksLocationTextBox;
    private System.Windows.Forms.TextBox symLinkLocationTextBox;
    private System.Windows.Forms.TextBox encryptionToolPathTextBox;
    private System.Windows.Forms.TextBox uAssetGuiPathTextBox;
    private System.Windows.Forms.TextBox fModelPathTextBox;
    private System.Windows.Forms.TextBox ddsToolsPathTextBox;
    private System.Windows.Forms.TextBox locresToolPathTextBox;

    #endregion
}