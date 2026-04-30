using CV2_Modding_Framework_UI.Utils;
using System.Diagnostics;

namespace CV2_Modding_Framework_UI.UI;

public partial class About : Form
{
    public About()
    {
        InitializeComponent();
        aboutLabel.Text = Constants.GetAboutText();
    }

    private void aboutLabel_Click(object sender, EventArgs e)
    {
        string url = Constants.APP_URL;
        Process.Start(new ProcessStartInfo
        {
            FileName = url,
            UseShellExecute = true
        });
    }
}