using CMS.Helpers;
using CMS.PortalEngine;
using CMS.PortalEngine.Web.UI;

public partial class HFSExtranet_RowTwoColumnsSidebar : CMSAbstractLayoutWebPart
{
    protected override void PrepareLayout()
    {
        StartLayout();
        Append("<div class=\"container\"><div class=\"row\"><div class=\"col-12 col-lg-3\">");
        AddZone(this.ID + "_Column1", "Column 1");
        Append("</div><div class=\"col-12 col-lg-9\">");
        AddZone(this.ID + "_Column2", "Column 2");
        Append("</div></div></div>");
        FinishLayout();
    }
}
