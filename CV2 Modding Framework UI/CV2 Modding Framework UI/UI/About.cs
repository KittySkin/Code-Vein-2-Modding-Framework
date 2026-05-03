namespace CV2_Modding_Framework_UI.UI;

public partial class About : Form
{
    public About()
    {
        InitializeComponent();
        Utils.AboutInfo aboutInfo = new();
        aboutLabel.Text = aboutInfo.GetAboutText();
    }

    private void aboutLabel_Click(object sender, EventArgs e)
    {
        Utils.UrlUtils.OpenLink(Utils.AboutInfo.AppUrl);
    }
}