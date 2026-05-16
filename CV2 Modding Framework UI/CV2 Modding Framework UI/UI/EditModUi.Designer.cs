using System.ComponentModel;

namespace CV2_Modding_Framework_UI.UI;

partial class EditModUi
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditModUi));
        descriptionLlabel = new System.Windows.Forms.Label();
        descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
        versionLabel = new System.Windows.Forms.Label();
        versionTextBox = new System.Windows.Forms.TextBox();
        nexusLabel = new System.Windows.Forms.Label();
        nexusLinkTextBox = new System.Windows.Forms.TextBox();
        currentlyModdedFilesTreeView = new System.Windows.Forms.TreeView();
        currentlyModdedFilesLabel = new System.Windows.Forms.Label();
        updateModButton = new System.Windows.Forms.Button();
        modNameTextBox = new System.Windows.Forms.TextBox();
        nameLabel = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // descriptionLlabel
        // 
        descriptionLlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        descriptionLlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        descriptionLlabel.Location = new System.Drawing.Point(12, 49);
        descriptionLlabel.Name = "descriptionLlabel";
        descriptionLlabel.Size = new System.Drawing.Size(618, 23);
        descriptionLlabel.TabIndex = 0;
        descriptionLlabel.Text = "Description";
        descriptionLlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // descriptionRichTextBox
        // 
        descriptionRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        descriptionRichTextBox.Location = new System.Drawing.Point(12, 75);
        descriptionRichTextBox.Name = "descriptionRichTextBox";
        descriptionRichTextBox.Size = new System.Drawing.Size(618, 141);
        descriptionRichTextBox.TabIndex = 1;
        descriptionRichTextBox.Text = "";
        // 
        // versionLabel
        // 
        versionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        versionLabel.Location = new System.Drawing.Point(12, 219);
        versionLabel.Name = "versionLabel";
        versionLabel.Size = new System.Drawing.Size(73, 23);
        versionLabel.TabIndex = 2;
        versionLabel.Text = "Version";
        versionLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // versionTextBox
        // 
        versionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        versionTextBox.Location = new System.Drawing.Point(91, 219);
        versionTextBox.Name = "versionTextBox";
        versionTextBox.Size = new System.Drawing.Size(539, 23);
        versionTextBox.TabIndex = 3;
        // 
        // nexusLabel
        // 
        nexusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        nexusLabel.Location = new System.Drawing.Point(12, 248);
        nexusLabel.Name = "nexusLabel";
        nexusLabel.Size = new System.Drawing.Size(73, 23);
        nexusLabel.TabIndex = 4;
        nexusLabel.Text = "Nexus Link";
        nexusLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // nexusLinkTextBox
        // 
        nexusLinkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        nexusLinkTextBox.Location = new System.Drawing.Point(91, 248);
        nexusLinkTextBox.Name = "nexusLinkTextBox";
        nexusLinkTextBox.Size = new System.Drawing.Size(539, 23);
        nexusLinkTextBox.TabIndex = 5;
        // 
        // currentlyModdedFilesTreeView
        // 
        currentlyModdedFilesTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        currentlyModdedFilesTreeView.Location = new System.Drawing.Point(12, 300);
        currentlyModdedFilesTreeView.Name = "currentlyModdedFilesTreeView";
        currentlyModdedFilesTreeView.Size = new System.Drawing.Size(618, 218);
        currentlyModdedFilesTreeView.TabIndex = 6;
        // 
        // currentlyModdedFilesLabel
        // 
        currentlyModdedFilesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        currentlyModdedFilesLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        currentlyModdedFilesLabel.Location = new System.Drawing.Point(12, 274);
        currentlyModdedFilesLabel.Name = "currentlyModdedFilesLabel";
        currentlyModdedFilesLabel.Size = new System.Drawing.Size(618, 23);
        currentlyModdedFilesLabel.TabIndex = 7;
        currentlyModdedFilesLabel.Text = "Currently Modded Files";
        currentlyModdedFilesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // updateModButton
        // 
        updateModButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        updateModButton.Location = new System.Drawing.Point(12, 524);
        updateModButton.Name = "updateModButton";
        updateModButton.Size = new System.Drawing.Size(618, 41);
        updateModButton.TabIndex = 8;
        updateModButton.Text = "Update Mod";
        updateModButton.UseVisualStyleBackColor = true;
        updateModButton.Click += updateModButton_Click;
        // 
        // modNameTextBox
        // 
        modNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        modNameTextBox.Location = new System.Drawing.Point(91, 12);
        modNameTextBox.Name = "modNameTextBox";
        modNameTextBox.Size = new System.Drawing.Size(539, 23);
        modNameTextBox.TabIndex = 10;
        // 
        // nameLabel
        // 
        nameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        nameLabel.Location = new System.Drawing.Point(12, 12);
        nameLabel.Name = "nameLabel";
        nameLabel.Size = new System.Drawing.Size(73, 23);
        nameLabel.TabIndex = 9;
        nameLabel.Text = "Name";
        nameLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // EditModUi
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(642, 577);
        Controls.Add(modNameTextBox);
        Controls.Add(nameLabel);
        Controls.Add(updateModButton);
        Controls.Add(currentlyModdedFilesLabel);
        Controls.Add(currentlyModdedFilesTreeView);
        Controls.Add(nexusLinkTextBox);
        Controls.Add(nexusLabel);
        Controls.Add(versionTextBox);
        Controls.Add(versionLabel);
        Controls.Add(descriptionRichTextBox);
        Controls.Add(descriptionLlabel);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Text = "Edit Mod UI";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox modNameTextBox;
    private System.Windows.Forms.Label nameLabel;

    private System.Windows.Forms.Button updateModButton;

    private System.Windows.Forms.Label currentlyModdedFilesLabel;

    private System.Windows.Forms.TreeView currentlyModdedFilesTreeView;

    private System.Windows.Forms.TextBox nexusLinkTextBox;

    private System.Windows.Forms.Label nexusLabel;

    private System.Windows.Forms.Label versionLabel;
    private System.Windows.Forms.TextBox versionTextBox;

    private System.Windows.Forms.RichTextBox descriptionRichTextBox;

    private System.Windows.Forms.Label descriptionLlabel;

    #endregion
}