using CMS.Helpers;
using CMS.PortalEngine;
using CMS.PortalEngine.Web.UI;

public partial class HFSExtranet_RowTwoColumns : CMSAbstractLayoutWebPart
{
    protected override void PrepareLayout()
    {
        StartLayout();
        Append("<div class=\"container\"><div class=\"row\"><div class=\"col-12 col-md-6\">");
        AddZone(this.ID + "_Column1", "Column 1");
        Append("</div><div class=\"col-12 col-md-6\">");
        AddZone(this.ID + "_Column2", "Column 2");
        Append("</div></div></div>");
        FinishLayout();
    }
}
