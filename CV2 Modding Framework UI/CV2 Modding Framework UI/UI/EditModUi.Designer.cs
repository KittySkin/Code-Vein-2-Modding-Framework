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
        label1 = new System.Windows.Forms.Label();
        descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
        label2 = new System.Windows.Forms.Label();
        versionTextBox = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        nexusLinkTextBox = new System.Windows.Forms.TextBox();
        currentlyModdedFilesTreeView = new System.Windows.Forms.TreeView();
        label4 = new System.Windows.Forms.Label();
        updateModButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(12, 9);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(618, 23);
        label1.TabIndex = 0;
        label1.Text = "Description";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // descriptionRichTextBox
        // 
        descriptionRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        descriptionRichTextBox.Location = new System.Drawing.Point(12, 35);
        descriptionRichTextBox.Name = "descriptionRichTextBox";
        descriptionRichTextBox.Size = new System.Drawing.Size(618, 110);
        descriptionRichTextBox.TabIndex = 1;
        descriptionRichTextBox.Text = "";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        label2.Location = new System.Drawing.Point(12, 151);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(73, 23);
        label2.TabIndex = 2;
        label2.Text = "Version";
        label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // versionTextBox
        // 
        versionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        versionTextBox.Location = new System.Drawing.Point(91, 151);
        versionTextBox.Name = "versionTextBox";
        versionTextBox.Size = new System.Drawing.Size(539, 23);
        versionTextBox.TabIndex = 3;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        label3.Location = new System.Drawing.Point(12, 180);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(73, 23);
        label3.TabIndex = 4;
        label3.Text = "Nexus Link";
        label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // nexusLinkTextBox
        // 
        nexusLinkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        nexusLinkTextBox.Location = new System.Drawing.Point(91, 180);
        nexusLinkTextBox.Name = "nexusLinkTextBox";
        nexusLinkTextBox.Size = new System.Drawing.Size(539, 23);
        nexusLinkTextBox.TabIndex = 5;
        // 
        // currentlyModdedFilesTreeView
        // 
        currentlyModdedFilesTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        currentlyModdedFilesTreeView.Location = new System.Drawing.Point(12, 232);
        currentlyModdedFilesTreeView.Name = "currentlyModdedFilesTreeView";
        currentlyModdedFilesTreeView.Size = new System.Drawing.Size(618, 159);
        currentlyModdedFilesTreeView.TabIndex = 6;
        // 
        // label4
        // 
        label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        label4.Location = new System.Drawing.Point(12, 206);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(618, 23);
        label4.TabIndex = 7;
        label4.Text = "Currently Modded Files";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // updateModButton
        // 
        updateModButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        updateModButton.Location = new System.Drawing.Point(12, 397);
        updateModButton.Name = "updateModButton";
        updateModButton.Size = new System.Drawing.Size(618, 41);
        updateModButton.TabIndex = 8;
        updateModButton.Text = "Update Mod";
        updateModButton.UseVisualStyleBackColor = true;
        updateModButton.Click += updateModButton_Click;
        // 
        // EditModUi
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(642, 450);
        Controls.Add(updateModButton);
        Controls.Add(label4);
        Controls.Add(currentlyModdedFilesTreeView);
        Controls.Add(nexusLinkTextBox);
        Controls.Add(label3);
        Controls.Add(versionTextBox);
        Controls.Add(label2);
        Controls.Add(descriptionRichTextBox);
        Controls.Add(label1);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Text = "Edit Mod UI";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button updateModButton;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.TreeView currentlyModdedFilesTreeView;

    private System.Windows.Forms.TextBox nexusLinkTextBox;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox versionTextBox;

    private System.Windows.Forms.RichTextBox descriptionRichTextBox;

    private System.Windows.Forms.Label label1;

    #endregion
}