using System;
using System.Data;
using System.Collections;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using CMS.Helpers;
using CMS.PortalEngine;
using CMS.PortalEngine.Web.UI;

public partial class HFSExtranet_CardFeatured : CMSAbstractWebPart
{
    public override void OnContentLoaded()
    {
        base.OnContentLoaded();
        
        imgFeaturedCardImage.ImageUrl = GetValue("Image").ToString();
        
        pnlFeaturedCard.CssClass += (" " + GetValue("BackgroundColor").ToString());

        string HeadingLevel = GetValue("HeadingLevel").ToString();;
        string Title = ValidationHelper.GetString(this.GetValue("Title"), "");

        if (!String.IsNullOrEmpty(Title)) {
            if (HeadingLevel == "h3" || HeadingLevel == "h4") {
                HtmlGenericControl TitleControl = new HtmlGenericControl(HeadingLevel);
                TitleControl.Attributes["class"] = "card-title";
                TitleControl.InnerText = Title;
                pnlCardBody.Controls.Add(TitleControl);
            }
        }

        string Content = GetValue("Content").ToString();
        pnlCardBody.Controls.Add(new LiteralControl(Content));

        hplFeaturedCardButton.Text = GetValue("ButtonText").ToString();
        hplFeaturedCardButton.NavigateUrl = GetValue("ButtonHyperlink").ToString();
        bool OpenLinkInNewWindow = ValidationHelper.GetBoolean(this.GetValue("OpenLinkInNewWindow"), false);
            if (OpenLinkInNewWindow) hplFeaturedCardButton.Target = "_blank";
    }
}
