using System;
using System.Data;
using System.Collections;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

using CMS.PortalEngine.Web.UI;
using CMS.Helpers;

public partial class CMSWebParts_HFSExtranet_HFSExtranet_PhotoGallery : CMSAbstractWebPart
{
    public override void OnContentLoaded()
    {
        base.OnContentLoaded();

        img1.ImageUrl = GetValue("Image1").ToString();
        img2.ImageUrl = GetValue("Image2").ToString();
        img3.ImageUrl = GetValue("Image3").ToString();
        img4.ImageUrl = GetValue("Image4").ToString();

        img1.Attributes["aria-hidden"] = "true";
        img2.Attributes["aria-hidden"] = "true";
        img3.Attributes["aria-hidden"] = "true";
        img4.Attributes["aria-hidden"] = "true";
    }
}



