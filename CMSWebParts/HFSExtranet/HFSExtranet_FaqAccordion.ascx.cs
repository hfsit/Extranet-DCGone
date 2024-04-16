using System;
using System.Data;
using System.Collections;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

using CMS.PortalEngine.Web.UI;
using CMS.Helpers;

public partial class CMSWebParts_HFSExtranet_HFSExtranet_FaqAccordion : CMSAbstractWebPart
{
    public override void OnContentLoaded()
    {
        base.OnContentLoaded();

        if(ValidationHelper.GetBoolean(this.GetValue("AccordionNew"), false)) {
            pnlAccordion.CssClass += " accordion-new";
        }

        litAccordionTitle.Text = ValidationHelper.GetString(this.GetValue("AccordionTitle"), "");
        pnlAccordionDetails.Controls.Add(new LiteralControl(HTMLHelper.ResolveUrls(ValidationHelper.GetString(GetValue("AccordionDetails"), ""), null)));
    }
}



