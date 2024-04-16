using System;
using System.Data;
using System.Collections;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

using CMS.PortalEngine.Web.UI;
using CMS.Helpers;

public partial class CMSWebParts_HFSExtranet_HFSExtranet_Alert : CMSAbstractWebPart
{
    public override void OnContentLoaded()
    {
        base.OnContentLoaded();
        
        string AlertTitleText = ValidationHelper.GetString(this.GetValue("AlertTitle"), "");
        
        if (!String.IsNullOrEmpty(AlertTitleText))
        {
            HtmlGenericControl AlertTitle = new HtmlGenericControl("h3");
            AlertTitle.InnerText = AlertTitleText;
            pnlAlert.Controls.Add(AlertTitle);
        }
        
        string AlertContentHtml = HTMLHelper.ResolveUrls(
            ValidationHelper.GetString(GetValue("AlertContent"), ""), null);
        
        pnlAlert.Controls.Add(new LiteralControl(AlertContentHtml));

    }
}



