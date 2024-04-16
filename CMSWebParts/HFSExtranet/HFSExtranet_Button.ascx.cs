using System;
using System.Collections.Generic;

using CMS.Base.Web.UI;
using CMS.Helpers;
using CMS.PortalEngine;
using CMS.PortalEngine.Web.UI;


public partial class HFSExtranet_Button : CMSAbstractWebPart
{
    #region "Public properties"

    public string ButtonText
    {
        get
        {
            return ValidationHelper.GetString(this.GetValue("ButtonText"), ltlButtonText.Text);
        }
        set
        {
            this.SetValue("ButtonText", value);
            ltlButtonText.Text = EncodeText ? HTMLHelper.HTMLEncode(value) : value;
            ltlButtonText.EnableViewState = (ResolveDynamicControls && ControlsHelper.ResolveDynamicControls(this));
        }
    }


    public string ButtonURL
    {
        get
        {
            return ValidationHelper.GetString(this.GetValue("ButtonURL"), "(Not found)");
        }
        set
        {
            this.SetValue("ButtonURL", value);
        }
    }


    #endregion


    #region "Methods"

    /// <summary>
    /// Enables or disables resolving of inline controls.
    /// </summary>
    public bool ResolveDynamicControls
    {
        get
        {
            return ValidationHelper.GetBoolean(GetValue("ResolveDynamicControls"), true);
        }
        set
        {
            SetValue("ResolveDynamicControls", value);
        }
    }


    /// <summary>
    /// Enables or disables HTML encoding of text.
    /// </summary>
    public bool EncodeText
    {
        get
        {
            return ValidationHelper.GetBoolean(GetValue("EncodeText"), false);
        }
        set
        {
            SetValue("EncodeText", value);
        }
    }


    public override void OnContentLoaded()
    {
        base.OnContentLoaded();
        SetupControl();
    }

    protected void SetupControl()
    {
        if (!StopProcessing)
        {
            string buttontext = EncodeText ? HTMLHelper.HTMLEncode(ButtonText) : ButtonText;            

            // Encode the text
            ltlButtonText.Text = buttontext;

            // Resolve controls
            ltlButtonText.EnableViewState = (ResolveDynamicControls && ControlsHelper.ResolveDynamicControls(this));

            ButtonLink.HRef = ButtonURL;
        }
    }


    public override void ReloadData()
    {
        base.ReloadData();

        SetupControl();
    }

    #endregion
}
