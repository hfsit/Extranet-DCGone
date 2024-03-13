using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CMS.UIControls;

public partial class CMSTemplates_HFSExtranet_KenticoMaster : TemplateMasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected override void CreateChildControls()
    {
        base.CreateChildControls();
        PageManager = CMSPortalManager;
    }

    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);
    }
}
