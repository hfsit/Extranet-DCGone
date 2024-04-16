﻿using CMS.Helpers;
using CMS.PortalEngine;
using CMS.PortalEngine.Web.UI;

public partial class HFSExtranet_RowOneColumnLeft : CMSAbstractLayoutWebPart
{
    protected override void PrepareLayout()
    {
        StartLayout();
        Append("<div class=\"container\"><div class=\"row\"><div class=\"col-12 col-lg-9\">");
        AddZone(this.ID + "_Column1", "Column 1");
        Append("</div></div></div>");
        FinishLayout();
    }
}
