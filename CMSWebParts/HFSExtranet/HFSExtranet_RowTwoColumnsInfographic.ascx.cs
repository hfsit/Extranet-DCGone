using CMS.Helpers;
using CMS.PortalEngine;
using CMS.PortalEngine.Web.UI;

public partial class HFSExtranet_RowTwoColumnsInfographic : CMSAbstractLayoutWebPart
{
    protected override void PrepareLayout()
    {
        StartLayout();
        Append("<div class=\"container\"><div class=\"row\"><div class=\"col-lg-7 pl-lg-4\">");
        AddZone(this.ID + "_Column1", "Column 1");
        Append("</div><div class=\"d-none d-lg-block col-lg-5 pr-lg-4\">");
        AddZone(this.ID + "_Column2", "Column 2");
        Append("</div></div></div>");
        FinishLayout();
    }
}
