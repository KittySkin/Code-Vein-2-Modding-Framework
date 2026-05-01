using System.ComponentModel;

namespace CV2_Modding_Framework_UI.UI;

partial class AddNewModUi
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewModUi));
        modNameTextBox = new System.Windows.Forms.TextBox();
        confirmButton = new System.Windows.Forms.Button();
        defaultStartingContentTreeView = new System.Windows.Forms.TreeView();
        label1 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // modNameTextBox
        // 
        modNameTextBox.Location = new System.Drawing.Point(12, 12);
        modNameTextBox.Name = "modNameTextBox";
        modNameTextBox.Size = new System.Drawing.Size(776, 23);
        modNameTextBox.TabIndex = 0;
        modNameTextBox.Text = "Type your mod name here...";
        // 
        // confirmButton
        // 
        confirmButton.Location = new System.Drawing.Point(12, 415);
        confirmButton.Name = "confirmButton";
        confirmButton.Size = new System.Drawing.Size(776, 23);
        confirmButton.TabIndex = 1;
        confirmButton.Text = "Create Mod!";
        confirmButton.UseVisualStyleBackColor = true;
        confirmButton.Click += confirmButton_Click;
        // 
        // defaultStartingContentTreeView
        // 
        defaultStartingContentTreeView.CheckBoxes = true;
        defaultStartingContentTreeView.Location = new System.Drawing.Point(12, 64);
        defaultStartingContentTreeView.Name = "defaultStartingContentTreeView";
        defaultStartingContentTreeView.Size = new System.Drawing.Size(776, 345);
        defaultStartingContentTreeView.TabIndex = 2;
        defaultStartingContentTreeView.AfterCheck += defaultStartingContentTreeView_AfterCheck;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(12, 38);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(776, 23);
        label1.TabIndex = 3;
        label1.Text = "Select default mod folder structure content";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // AddNewModUi
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label1);
        Controls.Add(defaultStartingContentTreeView);
        Controls.Add(confirmButton);
        Controls.Add(modNameTextBox);
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Text = "Add New Mod Dialog";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox modNameTextBox;
    private System.Windows.Forms.Button confirmButton;
    private System.Windows.Forms.TreeView defaultStartingContentTreeView;

    #endregion
}