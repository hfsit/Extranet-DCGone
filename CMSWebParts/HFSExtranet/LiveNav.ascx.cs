using System;
using System.Data;
using System.Collections;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

using CMS.Base.Web.UI;
using CMS.Helpers;
using CMS.PortalEngine.Web.UI;

public partial class CMSWebParts_HFSExtranet_LiveNav : CMSAbstractWebPart
{
    #region "Properties"

    /// <summary>
    /// Gets or sets the text to be displayed.
    /// </summary>


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


    /// <summary>
    /// Specifies as which HTML tag the content text will be rendered.
    /// </summary>
    public string Tag
    {
        get
        {
            return ValidationHelper.GetString(this.GetValue("Tag"), "");
        }
        set
        {
            this.SetValue("Tag", value);
        }
    }

    #endregion


    /// <summary>
    /// Content loaded event handler.
    /// </summary>
    public override void OnContentLoaded()
    {
        base.OnContentLoaded();
        SetupControl();
    }


    /// <summary>
    /// Initializes the control properties.
    /// </summary>
    protected void SetupControl()
    {
        if (StopProcessing)
        {
            // Do not process
        }
        else
        {

        }
    }


    /// <summary>
    /// Reloads the control data.
    /// </summary>
    public override void ReloadData()
    {
        base.ReloadData();

        SetupControl();
    }
}