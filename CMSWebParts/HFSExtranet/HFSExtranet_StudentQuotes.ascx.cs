using CMS.PortalEngine.Web.UI;

public partial class CMSWebParts_HFSExtranet_HFSExtranet_StudentQuotes : CMSAbstractWebPart
{
    public override void OnContentLoaded()
    {
        base.OnContentLoaded();

        litQuote1Content.Text = (string)GetValue("Quote1Content");
        litQuote1Name.Text = (string)GetValue("Quote1Name");
        litQuote1Caption.Text = (string)GetValue("Quote1Caption");

        litQuote2Content.Text = (string)GetValue("Quote2Content");
        litQuote2Name.Text = (string)GetValue("Quote2Name");
        litQuote2Caption.Text = (string)GetValue("Quote2Caption");

        litQuote3Content.Text = (string)GetValue("Quote3Content");
        litQuote3Name.Text = (string)GetValue("Quote3Name");
        litQuote3Caption.Text = (string)GetValue("Quote3Caption");
    }
}