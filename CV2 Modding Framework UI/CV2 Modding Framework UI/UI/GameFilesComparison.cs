using System.Diagnostics;

namespace CV2_Modding_Framework_UI.UI;

public partial class GameFilesComparison : Form
{
    public GameFilesComparison()
    {
        InitializeComponent();
    }

    private void selectOldGameFilesButton_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        
        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        {
            selectOldGameFilesButton.Text = folderBrowserDialog.SelectedPath;
        }
    }

    private void SelectNewGameFilesButton_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        
        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
        {
            SelectNewGameFilesButton.Text = folderBrowserDialog.SelectedPath;
        }
    }

    private void StartComparisonButton_Click(object sender, EventArgs e)
    {
        if (!Directory.Exists(selectOldGameFilesButton.Text) || !Directory.Exists(SelectNewGameFilesButton.Text))
        {
            MessageBox.Show(@"Please select both old and new game files before starting comparison.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        string scriptPath = Path.Combine(Application.StartupPath, Utils.Constants.HELPER_SCRIPTS_FOLDER, Utils.Constants.COMPARE_GAME_FILES_BATHOD);

        ProcessStartInfo processStartInfo = new ProcessStartInfo
        {
            FileName = "cmd.exe",
            Arguments = $"/c \"\"{scriptPath}\" \"{selectOldGameFilesButton.Text}\" \"{SelectNewGameFilesButton.Text}\"\"",
            UseShellExecute = true,
            CreateNoWindow = false 
        };

        try 
        {
            Process? comparesionProcess = Process.Start(processStartInfo);
            comparesionProcess?.WaitForExit();
            if (comparesionProcess?.ExitCode != 0)
            {
                MessageBox.Show($@"Comparison completed with errors. Exit code: {comparesionProcess?.ExitCode}", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string logPath = Path.Combine(Application.StartupPath, Utils.Constants.HELPER_SCRIPTS_FOLDER, Utils.Constants.DIFF_LOG);
                Thread.Sleep(100);
                comparisonResultRichTextBox.Text = File.ReadAllText(logPath);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($@"Failed to start comparison: {ex.Message}", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}