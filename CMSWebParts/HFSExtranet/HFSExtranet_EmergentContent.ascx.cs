using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CMS.Helpers;
using CMS.PortalEngine.Web.UI;

public partial class CMSWebParts_HFSExtranet_HFSExtranet_EmergentContent : CMSAbstractWebPart
{
    public override void OnContentLoaded()
    {
        base.OnContentLoaded();

        litEmergentContent1.Text = HTMLHelper.ResolveUrls(ValidationHelper.GetString(GetValue("EmergentContent1"), ""), null);
        litEmergentContent2.Text = HTMLHelper.ResolveUrls(ValidationHelper.GetString(GetValue("EmergentContent2"), ""), null);
        litEmergentContent3.Text = HTMLHelper.ResolveUrls(ValidationHelper.GetString(GetValue("EmergentContent3"), ""), null);

        if (string.IsNullOrEmpty(litEmergentContent2.Text)) pnlEmergentContent2.Visible = false;
        if (string.IsNullOrEmpty(litEmergentContent3.Text)) pnlEmergentContent3.Visible = false;
    }
}