using System.ComponentModel;

namespace CV2_Modding_Framework_UI.UI;

partial class About
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
        aboutLabel = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // aboutLabel
        // 
        aboutLabel.AutoSize = true;
        aboutLabel.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
        aboutLabel.Location = new System.Drawing.Point(12, 9);
        aboutLabel.Name = "aboutLabel";
        aboutLabel.Size = new System.Drawing.Size(125, 15);
        aboutLabel.TabIndex = 0;
        aboutLabel.Text = "aboutLabelDefaultText";
        aboutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        aboutLabel.Click += aboutLabel_Click;
        // 
        // About
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        AutoSize = true;
        AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(aboutLabel);
        Text = "About";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label aboutLabel;

    #endregion
}