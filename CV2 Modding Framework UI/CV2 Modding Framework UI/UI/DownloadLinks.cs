namespace CV2_Modding_Framework_UI.UI;

public partial class DownloadLinks : Form
{
    public DownloadLinks()
    {
        InitializeComponent();
    }

    #region Click Actions
    private void uAssetGuiLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Utils.UrlUtils.OpenLink(Utils.Constants.UassetGuiDownloadUrl);
    }
    private void fModelLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Utils.UrlUtils.OpenLink(Utils.Constants.FmodelDownloadUrl);
    }
    private void retocLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Utils.UrlUtils.OpenLink(Utils.Constants.RetocDownloadUrl);
    }
    private void ddsToolsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Utils.UrlUtils.OpenLink(Utils.Constants.DdsToolsDownloadUrl);
    }
    private void unrealLocresEditorLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Utils.UrlUtils.OpenLink(Utils.Constants.UnrealLocresEditorDownloadUrl);
    }
    private void codeVein2LocresToolLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Utils.UrlUtils.OpenLink(Utils.Constants.CodeVein2LocresToolDownloadUrl);
    }
    #endregion
}