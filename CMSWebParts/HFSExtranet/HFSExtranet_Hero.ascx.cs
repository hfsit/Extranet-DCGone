using System;
using System.Data;
using System.Collections;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

using CMS.PortalEngine.Web.UI;
using CMS.Helpers;

public partial class CMSWebParts_HFSExtranet_HFSExtranet_Hero : CMSAbstractWebPart
{
    public override void OnContentLoaded()
    {
        base.OnContentLoaded();

        pnlHeroContainer.CssClass += (" " + GetValue("AspectRatio").ToString());
        imgHero.ImageUrl = GetValue("Image").ToString();

        string ImageAltText = ValidationHelper.GetString(this.GetValue("ImageAltText"), "");
        if (!String.IsNullOrEmpty(ImageAltText)) {
            imgHero.AlternateText = ImageAltText;
        }
        else {
            imgHero.Attributes["aria-hidden"] = "true";
        }

    }
}



