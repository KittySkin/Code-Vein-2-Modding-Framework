using System.Diagnostics;
using CV2_Modding_Framework_UI.Utils;

namespace CV2_Modding_Framework_UI.UI;

public partial class LocresEncryptionTool : Form
{
    private readonly FileSystem pFileSystem;

    public LocresEncryptionTool(FileSystem fileSystem)
    {
        pFileSystem = fileSystem;
        InitializeComponent();
        operationModeComboBox.SelectedIndex = 0;
    }

    private void browseButton_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = @"Locres files|*.locres";
        openFileDialog.FilterIndex = 1;
        openFileDialog.RestoreDirectory = true;
        openFileDialog.Multiselect = false;

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            selectedFileTextBox.Text = openFileDialog.FileName;
        }
    }

    private void processFileButton_Click(object sender, EventArgs e)
    {
        string operationMode = operationModeComboBox.Text.ToLower();
        string fileName = Path.GetFileNameWithoutExtension(selectedFileTextBox.Text);
        string? filePath = Path.GetDirectoryName(selectedFileTextBox.Text);
        if (String.IsNullOrEmpty(filePath))
            return;
        string newFilePath = Path.Join(filePath, $"{fileName}{operationMode}ed.locres");
        ProcessStartInfo processStartInfo = new ProcessStartInfo
        {
            FileName = pFileSystem.Cv2LocresToolPath,
            Arguments = $"{operationMode} {selectedFileTextBox.Text} {newFilePath}",
            CreateNoWindow = true,
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
        };
        Process.Start(processStartInfo);
    }
}