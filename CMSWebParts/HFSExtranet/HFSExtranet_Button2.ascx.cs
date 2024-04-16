using System;
using System.Collections.Generic;

using CMS.Base.Web.UI;
using CMS.Helpers;
using CMS.PortalEngine;
using CMS.PortalEngine.Web.UI;


public partial class HFSExtranet_Button2 : CMSAbstractWebPart
{
    public override void OnContentLoaded()
    {
        string ButtonCssClass = "btn";
        if (bool.Parse(GetValue("AddNavChevron").ToString())) ButtonCssClass += " btn-nav";
        if (bool.Parse(GetValue("DisplayBlock").ToString())) ButtonCssClass += " btn-block";
        ButtonCssClass += " " + GetValue("ButtonColor");
        aButton.Attributes["class"] = ButtonCssClass;

        aButton.InnerText = GetValue("ButtonText").ToString();

        aButton.Attributes["href"] = GetValue("ButtonURL").ToString();

        if (bool.Parse(GetValue("OpenInNewTab").ToString())) aButton.Attributes["target"] = "_blank";

        base.OnContentLoaded();
    }
}
