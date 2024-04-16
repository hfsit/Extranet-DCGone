using System;
using System.Data;
using System.Collections;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

using CMS.PortalEngine.Web.UI;
using CMS.Helpers;

public partial class CMSWebParts_HFSExtranet_HFSExtranet_Questions : CMSAbstractWebPart
{
    public override void OnContentLoaded()
    {
        base.OnContentLoaded();

        pnlQuestionsContent.CssClass += (" " + GetValue("BackgroundColor").ToString());
        pnlQuestionsContent.Controls.Add(new LiteralControl(GetValue("Content").ToString()));
    }
}



