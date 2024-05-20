using System;
using System.Data;
using System.Collections;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

using CMS.PortalEngine.Web.UI;
using CMS.Helpers;

public partial class CMSWebParts_HFSExtranet_HFSExtranet_LandingPageHero : CMSAbstractWebPart
{
    public override void OnContentLoaded()
    {
        base.OnContentLoaded();

        imgLandingPageHeroImage.ImageUrl = GetValue("Image").ToString();

        string ImageAltText = ValidationHelper.GetString(this.GetValue("ImageAltText"), "");
        if (!String.IsNullOrEmpty(ImageAltText)) {
            imgLandingPageHeroImage.AlternateText = ImageAltText;
        }
        else {
            imgLandingPageHeroImage.Attributes["aria-hidden"] = "true";
        }
        pnlLPHeroContent.Controls.AddAt(0, new LiteralControl(GetValue("Content").ToString()));

        hplLPHeroButton.Text = GetValue("ButtonText").ToString();
        hplLPHeroButton.NavigateUrl = GetValue("ButtonHyperlink").ToString();
        bool OpenLinkInNewWindow = ValidationHelper.GetBoolean(this.GetValue("OpenLinkInNewWindow"), false);
            if (OpenLinkInNewWindow) hplLPHeroButton.Target = "_blank";
            
    }
}



