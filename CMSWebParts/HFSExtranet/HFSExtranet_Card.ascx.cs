using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Xml;

using CMS.DocumentEngine.Web.UI;
using CMS.Base.Web.UI;
using CMS.Helpers;
using CMS.PortalEngine.Web.UI;
using CMS.PortalEngine;
using CMS.Base;
using CMS.DocumentEngine;
//using CMS.UIControls;

public partial class HFSExtranet_Card : CMSAbstractEditableWebPart, IDialogControl
{

    #region "Public properties"


    /// <summary>
    /// Configuration of the dialog for inserting Images.
    /// </summary>
    public DialogConfiguration DialogConfig
    {
        get
        {
            return eiCardImage.DialogConfig;
        }
        set
        {
            eiCardImage.DialogConfig = value;
        }
    }


    /// <summary>
    /// Gets the url of the page which ensures editing of the web part's editable content in the On-Site editing mode.
    /// </summary>
    public override string EditPageUrl
    {
        get
        {
            return eiCardImage.EditPageUrl;
        }
    }


    /// <summary>
    /// Gets the width of the edit dialog in the On-Site editing mode.
    /// </summary>
    public override string EditDialogWidth
    {
        get
        {
            return eiCardImage.EditDialogWidth;
        }
    }


    /// <summary>
    /// Gets or sets the text to be displayed.
    /// </summary>
    public string CardTitle
    {
        get
        {
            return HTMLHelper.ResolveUrls(ValidationHelper.GetString(GetValue("CardTitle"), ltlCardTitle.Text), null);
        }
        set
        {
            SetValue("CardTitle", value);
            ltlCardTitle.Text = EncodeText ? HTMLHelper.HTMLEncode(value) : value;
            ltlCardTitle.EnableViewState = (ResolveDynamicControls && ControlsHelper.ResolveDynamicControls(this));
        }
    }


    public string CardText
    {
        get
        {
            return HTMLHelper.ResolveUrls(ValidationHelper.GetString(GetValue("CardText"), ltlCardText.Text), null);
        }
        set
        {
            SetValue("CardText", value);
            ltlCardText.Text = EncodeText ? HTMLHelper.HTMLEncode(value) : value;
            ltlCardText.EnableViewState = (ResolveDynamicControls && ControlsHelper.ResolveDynamicControls(this));
        }
    }


    public string ButtonText
    {
        get
        {
            return HTMLHelper.ResolveUrls(ValidationHelper.GetString(GetValue("ButtonText"), ltlButtonText.Text), null);
        }
        set
        {
            SetValue("ButtonText", value);
            ltlButtonText.Text = EncodeText ? HTMLHelper.HTMLEncode(value) : value;
            ltlButtonText.EnableViewState = (ResolveDynamicControls && ControlsHelper.ResolveDynamicControls(this));
        }
    }


    public string CardURL
    {
        get
        {
            return ValidationHelper.GetString(this.GetValue("CardURL"), "");
        }
        set
        {
            this.SetValue("CardURL", value);
        }
    }

    #endregion

    #region "Methods"
    public override void OnContentLoaded()
    {
        base.OnContentLoaded();
        SetupControl();
    }

    protected void SetupControl()
    {
        this.Visible = true;

        // Do not hide for roles in edit or preview mode
        switch (ViewMode)
        {
            case ViewModeEnum.Edit:
            case ViewModeEnum.EditLive:
            case ViewModeEnum.EditDisabled:
            case ViewModeEnum.Design:
            case ViewModeEnum.DesignDisabled:
            case ViewModeEnum.EditNotCurrent:
            case ViewModeEnum.Preview:
                DisplayToRoles = "";
                break;
        }

        eiCardImage.StopProcessing = StopProcessing;

        if (!StopProcessing)
        {
            eiCardImage.ContentID = this.WebPartID;
            eiCardImage.DataControl = this as ISimpleDataContainer;
            eiCardImage.PageManager = PageManager;
            eiCardImage.PagePlaceholder = PagePlaceholder;
            eiCardImage.SetupControl();

            string cardtitle = EncodeText ? HTMLHelper.HTMLEncode(CardTitle) : CardTitle;
            string cardtext = EncodeText ? HTMLHelper.HTMLEncode(CardText) : CardText;
            string buttontext = EncodeText ? HTMLHelper.HTMLEncode(ButtonText) : ButtonText;

            // Encode the text
            ltlCardTitle.Text = cardtitle;
            ltlCardText.Text = cardtext;
            ltlButtonText.Text = buttontext;
            CardLink.HRef = CardURL;

            // Resolve controls
            ltlCardTitle.EnableViewState = (ResolveDynamicControls && ControlsHelper.ResolveDynamicControls(this));
            ltlCardText.EnableViewState = (ResolveDynamicControls && ControlsHelper.ResolveDynamicControls(this));
            ltlButtonText.EnableViewState = (ResolveDynamicControls && ControlsHelper.ResolveDynamicControls(this));
        }
    }


    /// <summary>
    /// Overridden CreateChildControls method.
    /// </summary>
    protected override void CreateChildControls()
    {
        SetupControl();
        base.CreateChildControls();
    }


    /// <summary>
    /// Loads the control content.
    /// </summary>
    /// <param name="content">Content to load</param>
    /// <param name="forceReload">If true, the content is forced to reload</param>
    public override void LoadContent(string content, bool forceReload)
    {
        if (!StopProcessing)
        {
            eiCardImage.LoadContent(content, forceReload);

            if (!string.IsNullOrEmpty(eiCardImage.DefaultImage))
            {
                // Default image defined => content is not empty
                EmptyContent = false;
                CardTop.Visible = false;
            }
        }
    }


    /// <summary>
    /// Gets the current control content.
    /// </summary>
    public override string GetContent()
    {
        if (!StopProcessing)
        {
            EnsureChildControls();

            return eiCardImage.GetContent();
        }
        return null;
    }


    /// <summary>
    /// Reloads the control data.
    /// </summary>
    public override void ReloadData()
    {
        base.ReloadData();
        SetupControl();
    }


    /// <summary>
    /// OnPreRender event
    /// </summary>
    protected override void OnPreRender(EventArgs e)
    {
        if (!ViewMode.IsEditLive())
        {
            // Use the control visibility
            CardTop.Visible = eiCardImage.Visible;
        }

        base.OnPreRender(e);
    }


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


    #endregion

}


