using System.ComponentModel;

namespace CV2_Modding_Framework_UI.UI;

partial class LocresEncryptionTool
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocresEncryptionTool));
        selectedFileTextBox = new System.Windows.Forms.TextBox();
        operationModeComboBox = new System.Windows.Forms.ComboBox();
        browseFileButton = new System.Windows.Forms.Button();
        processFileButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // selectedFileTextBox
        // 
        selectedFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        selectedFileTextBox.Location = new System.Drawing.Point(12, 11);
        selectedFileTextBox.Name = "selectedFileTextBox";
        selectedFileTextBox.Size = new System.Drawing.Size(546, 23);
        selectedFileTextBox.TabIndex = 0;
        selectedFileTextBox.Text = "Select locres file...";
        // 
        // operationModeComboBox
        // 
        operationModeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        operationModeComboBox.FormattingEnabled = true;
        operationModeComboBox.Items.AddRange(new object[] { "Decrypt", "Encrypt" });
        operationModeComboBox.Location = new System.Drawing.Point(12, 42);
        operationModeComboBox.Name = "operationModeComboBox";
        operationModeComboBox.Size = new System.Drawing.Size(662, 23);
        operationModeComboBox.TabIndex = 2;
        // 
        // browseFileButton
        // 
        browseFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        browseFileButton.Location = new System.Drawing.Point(564, 11);
        browseFileButton.Name = "browseFileButton";
        browseFileButton.Size = new System.Drawing.Size(110, 23);
        browseFileButton.TabIndex = 3;
        browseFileButton.Text = "Browse File";
        browseFileButton.UseVisualStyleBackColor = true;
        browseFileButton.Click += browseButton_Click;
        // 
        // processFileButton
        // 
        processFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        processFileButton.Font = new System.Drawing.Font("Segoe UI", 9F);
        processFileButton.Location = new System.Drawing.Point(12, 71);
        processFileButton.Name = "processFileButton";
        processFileButton.Size = new System.Drawing.Size(662, 50);
        processFileButton.TabIndex = 5;
        processFileButton.Text = "Process File";
        processFileButton.UseVisualStyleBackColor = true;
        processFileButton.Click += processFileButton_Click;
        // 
        // LocresEncryptionTool
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(686, 130);
        Controls.Add(processFileButton);
        Controls.Add(browseFileButton);
        Controls.Add(operationModeComboBox);
        Controls.Add(selectedFileTextBox);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        MaximizeBox = false;
        MaximumSize = new System.Drawing.Size(702, 169);
        MinimumSize = new System.Drawing.Size(702, 169);
        Text = "Locres Encryption Tool";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox selectedFileTextBox;
    private System.Windows.Forms.ComboBox operationModeComboBox;
    private System.Windows.Forms.Button browseFileButton;
    private System.Windows.Forms.Button processFileButton;

    #endregion
}