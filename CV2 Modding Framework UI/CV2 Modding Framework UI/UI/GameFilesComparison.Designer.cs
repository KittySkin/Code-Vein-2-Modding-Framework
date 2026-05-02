using System.ComponentModel;

namespace CV2_Modding_Framework_UI.UI;

partial class GameFilesComparison
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameFilesComparison));
        selectOldGameFilesButton = new System.Windows.Forms.Button();
        SelectNewGameFilesButton = new System.Windows.Forms.Button();
        StartComparisonButton = new System.Windows.Forms.Button();
        comparisonResultRichTextBox = new System.Windows.Forms.RichTextBox();
        SuspendLayout();
        // 
        // selectOldGameFilesButton
        // 
        selectOldGameFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        selectOldGameFilesButton.Location = new System.Drawing.Point(12, 12);
        selectOldGameFilesButton.Name = "selectOldGameFilesButton";
        selectOldGameFilesButton.Size = new System.Drawing.Size(864, 23);
        selectOldGameFilesButton.TabIndex = 0;
        selectOldGameFilesButton.Text = "Select Old Game Files";
        selectOldGameFilesButton.UseVisualStyleBackColor = true;
        selectOldGameFilesButton.Click += selectOldGameFilesButton_Click;
        // 
        // SelectNewGameFilesButton
        // 
        SelectNewGameFilesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        SelectNewGameFilesButton.Location = new System.Drawing.Point(12, 41);
        SelectNewGameFilesButton.Name = "SelectNewGameFilesButton";
        SelectNewGameFilesButton.Size = new System.Drawing.Size(864, 23);
        SelectNewGameFilesButton.TabIndex = 1;
        SelectNewGameFilesButton.Text = "Select New Game Files";
        SelectNewGameFilesButton.UseVisualStyleBackColor = true;
        SelectNewGameFilesButton.Click += SelectNewGameFilesButton_Click;
        // 
        // StartComparisonButton
        // 
        StartComparisonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        StartComparisonButton.Location = new System.Drawing.Point(12, 70);
        StartComparisonButton.Name = "StartComparisonButton";
        StartComparisonButton.Size = new System.Drawing.Size(864, 23);
        StartComparisonButton.TabIndex = 2;
        StartComparisonButton.Text = "Start Comparison";
        StartComparisonButton.UseVisualStyleBackColor = true;
        StartComparisonButton.Click += StartComparisonButton_Click;
        // 
        // comparisonResultRichTextBox
        // 
        comparisonResultRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        comparisonResultRichTextBox.Location = new System.Drawing.Point(12, 99);
        comparisonResultRichTextBox.Name = "comparisonResultRichTextBox";
        comparisonResultRichTextBox.Size = new System.Drawing.Size(864, 364);
        comparisonResultRichTextBox.TabIndex = 3;
        comparisonResultRichTextBox.Text = "";
        // 
        // GameFilesComparison
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(888, 475);
        Controls.Add(comparisonResultRichTextBox);
        Controls.Add(StartComparisonButton);
        Controls.Add(SelectNewGameFilesButton);
        Controls.Add(selectOldGameFilesButton);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Text = "Game Files Comparison";
        ResumeLayout(false);
    }

    private System.Windows.Forms.RichTextBox comparisonResultRichTextBox;

    private System.Windows.Forms.Button selectOldGameFilesButton;
    private System.Windows.Forms.Button SelectNewGameFilesButton;
    private System.Windows.Forms.Button StartComparisonButton;

    #endregion
}