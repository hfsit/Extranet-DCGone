using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using CMS.Base.Web.UI;
using CMS.Helpers;
using CMS.PortalEngine;
using CMS.PortalEngine.Web.UI;

public partial class HFSExtranet_Slideshow : CMSAbstractWebPart
{
    #region "Public properties"

    public string Caption1
    {
        get
        {
            return HTMLHelper.ResolveUrls(ValidationHelper.GetString(GetValue("Caption1"), ""), null);

        }
        set
        {
            this.SetValue("Caption1", value);
        }
    }


    public string Image1
    {
        get
        {
            return HTMLHelper.ResolveUrls(ValidationHelper.GetString(GetValue("Image1"), ""), null);
        }
        set
        {
            this.SetValue("Image1", value);
        }
    }


    public string Caption2
    {
        get
        {
            return HTMLHelper.ResolveUrls(ValidationHelper.GetString(GetValue("Caption2"), ""), null);
        }
        set
        {
            this.SetValue("Caption2", value);
        }
    }


    public string Image2
    {
        get
        {
            return HTMLHelper.ResolveUrls(ValidationHelper.GetString(GetValue("Image2"), ""), null);
        }
        set
        {
            this.SetValue("Image2", value);
        }
    }


    public string Caption3
    {
        get
        {
            return HTMLHelper.ResolveUrls(ValidationHelper.GetString(GetValue("Caption3"), ""), null);
        }
        set
        {
            this.SetValue("Caption3", value);
        }
    }


    public string Image3
    {
        get
        {
            return HTMLHelper.ResolveUrls(ValidationHelper.GetString(GetValue("Image3"), ""), null);
        }
        set
        {
            this.SetValue("Image3", value);
        }
    }

    public string Caption4
    {
        get
        {
            return HTMLHelper.ResolveUrls(ValidationHelper.GetString(GetValue("Caption4"), ""), null);
        }
        set
        {
            this.SetValue("Caption4", value);
        }
    }


    public string Image4
    {
        get
        {
            return HTMLHelper.ResolveUrls(ValidationHelper.GetString(GetValue("Image4"), ""), null);
        }
        set
        {
            this.SetValue("Image4", value);
        }
    }


    public string Caption5
    {
        get
        {
            return HTMLHelper.ResolveUrls(ValidationHelper.GetString(GetValue("Caption5"), ""), null);
        }
        set
        {
            this.SetValue("Caption5", value);
        }
    }


    public string Image5
    {
        get
        {
            return HTMLHelper.ResolveUrls(ValidationHelper.GetString(GetValue("Image5"), ""), null);
        }
        set
        {
            this.SetValue("Image5", value);
        }
    }


    public string Caption6
    {
        get
        {            
            return HTMLHelper.ResolveUrls(ValidationHelper.GetString(GetValue("Caption6"), ""), null);
        }
        set
        {
            this.SetValue("Caption6", value);
        }
    }


    public string Image6
    {
        get
        {
            return HTMLHelper.ResolveUrls(ValidationHelper.GetString(GetValue("Image6"), ""), null);
        }
        set
        {
            this.SetValue("Image6", value);
        }
    }

    public string Caption7
    {
        get
        {            
            return HTMLHelper.ResolveUrls(ValidationHelper.GetString(GetValue("Caption7"), ""), null);
        }
        set
        {
            this.SetValue("Caption7", value);
        }
    }


    public string Image7
    {
        get
        {
            return HTMLHelper.ResolveUrls(ValidationHelper.GetString(GetValue("Image7"), ""), null);
        }
        set
        {
            this.SetValue("Image7", value);
        }
    }


    public string Caption8
    {
        get
        {
            return HTMLHelper.ResolveUrls(ValidationHelper.GetString(GetValue("Caption8"), ""), null);
        }
        set
        {
            this.SetValue("Caption8", value);
        }
    }


    public string Image8
    {
        get
        {
            return HTMLHelper.ResolveUrls(ValidationHelper.GetString(GetValue("Image8"), ""), null);
        }
        set
        {
            this.SetValue("Image8", value);
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
            string image1 = EncodeText ? HTMLHelper.HTMLEncode(Image1) : Image1;
            string image2 = EncodeText ? HTMLHelper.HTMLEncode(Image2) : Image2;
            string image3 = EncodeText ? HTMLHelper.HTMLEncode(Image3) : Image3;
            string image4 = EncodeText ? HTMLHelper.HTMLEncode(Image4) : Image4;
            string image5 = EncodeText ? HTMLHelper.HTMLEncode(Image5) : Image5;
            string image6 = EncodeText ? HTMLHelper.HTMLEncode(Image6) : Image6;
            string image7 = EncodeText ? HTMLHelper.HTMLEncode(Image7) : Image7;
            string image8 = EncodeText ? HTMLHelper.HTMLEncode(Image8) : Image8;

            string caption1 = EncodeText ? HTMLHelper.HTMLEncode(Caption1) : Caption1;            
            string caption2 = EncodeText ? HTMLHelper.HTMLEncode(Caption2) : Caption2;
            string caption3 = EncodeText ? HTMLHelper.HTMLEncode(Caption3) : Caption3;
            string caption4 = EncodeText ? HTMLHelper.HTMLEncode(Caption4) : Caption4;
            string caption5 = EncodeText ? HTMLHelper.HTMLEncode(Caption5) : Caption5;            
            string caption6 = EncodeText ? HTMLHelper.HTMLEncode(Caption6) : Caption6;            
            string caption7 = EncodeText ? HTMLHelper.HTMLEncode(Caption7) : Caption7;            
            string caption8 = EncodeText ? HTMLHelper.HTMLEncode(Caption8) : Caption8;


            olDiv.InnerHtml= "<ol class='carousel-indicators'>";
            olDiv.InnerHtml += image1 != "" ? "<li id='liItem1' data-target='#carousel' data-slide-to='0' class='rounded-circle active' visible='true' runat='server'></li>" : string.Empty;
            olDiv.InnerHtml += image2 != "" ? "<li id='liItem2' data-target='#carousel' data-slide-to='1' class='rounded-circle' visible='true' runat='server'></li>" : string.Empty;
            olDiv.InnerHtml += image3 != "" ? "<li id='liItem3' data-target='#carousel' data-slide-to='2' class='rounded-circle' visible='true' runat='server'></li>" : string.Empty;
            olDiv.InnerHtml += image4 != "" ? "<li id='liItem4' data-target='#carousel' data-slide-to='3' class='rounded-circle' visible='true' runat='server'></li>" : string.Empty;
            olDiv.InnerHtml += image5 != "" ? "<li id='liItem5' data-target='#carousel' data-slide-to='4' class='rounded-circle' visible='true' runat='server'></li>" : string.Empty;
            olDiv.InnerHtml += image6 != "" ? "<li id='liItem6' data-target='#carousel' data-slide-to='5' class='rounded-circle' visible='true' runat='server'></li>" : string.Empty;
            olDiv.InnerHtml += image7 != "" ? "<li id='liItem7' data-target='#carousel' data-slide-to='6' class='rounded-circle' visible='true' runat='server'></li>" : string.Empty;
            olDiv.InnerHtml += image8 != "" ? "<li id='liItem8' data-target='#carousel' data-slide-to='7' class='rounded-circle' visible='true' runat='server'></li>" : string.Empty;
            olDiv.InnerHtml += "</ol>";


            CarouselDiv.InnerHtml = "<div class='carousel-inner' role='listbox'>";
            CarouselDiv.InnerHtml += image1 != "" ? "<div class='carousel-item active'>" : string.Empty;
            CarouselDiv.InnerHtml += image1 != "" ? "<img class='carousel-image' src='" + Image1 + "' />" : string.Empty;
            CarouselDiv.InnerHtml += caption1 != "" ? "<div class='carousel-caption d-none d-md-block'>" : string.Empty;
            CarouselDiv.InnerHtml += caption1 != "" ? "<p>" + caption1 + "</p>" : string.Empty;
            CarouselDiv.InnerHtml += caption1 != "" ? "</div>" : string.Empty;
            CarouselDiv.InnerHtml += image1 != "" ? "</div>" : string.Empty;
            CarouselDiv.InnerHtml += image2 != "" ? "<div class='carousel-item'>" : string.Empty;
            CarouselDiv.InnerHtml += image2 != "" ? "<img class='carousel-image' src='" + Image2 + "' />" : string.Empty;
            CarouselDiv.InnerHtml += caption2 != "" ? "<div class='carousel-caption d-none d-md-block'>" : string.Empty;
            CarouselDiv.InnerHtml += caption2 != "" ? "<p>" + caption2 + "</p>" : string.Empty;
            CarouselDiv.InnerHtml += caption2 != "" ? "</div>" : string.Empty;
            CarouselDiv.InnerHtml += image2 != "" ? "</div>" : string.Empty;
            CarouselDiv.InnerHtml += image3 != "" ? "<div class='carousel-item'>" : string.Empty;
            CarouselDiv.InnerHtml += image3 != "" ? "<img class='carousel-image' src='" + Image3 + "' />" : string.Empty;
            CarouselDiv.InnerHtml += caption3 != "" ? "<div class='carousel-caption d-none d-md-block'>" : string.Empty;
            CarouselDiv.InnerHtml += caption3 != "" ? "<p>" + caption3 + "</p>" : string.Empty;
            CarouselDiv.InnerHtml += caption3 != "" ? "</div>" : string.Empty;
            CarouselDiv.InnerHtml += image3 != "" ? "</div>" : string.Empty;
            CarouselDiv.InnerHtml += image4 != "" ? "<div class='carousel-item'>" : string.Empty;
            CarouselDiv.InnerHtml += image4 != "" ? "<img class='carousel-image' src='" + Image4 + "' />" : string.Empty;
            CarouselDiv.InnerHtml += caption4 != "" ? "<div class='carousel-caption d-none d-md-block'>" : string.Empty;
            CarouselDiv.InnerHtml += caption4 != "" ? "<p>" + caption4 + "</p>" : string.Empty;
            CarouselDiv.InnerHtml += caption4 != "" ? "</div>" : string.Empty;
            CarouselDiv.InnerHtml += image4 != "" ? "</div>" : string.Empty;
            CarouselDiv.InnerHtml += image5 != "" ? "<div class='carousel-item'>" : string.Empty;
            CarouselDiv.InnerHtml += image5 != "" ? "<img class='carousel-image' src='" + Image5 + "' />" : string.Empty;
            CarouselDiv.InnerHtml += caption5 != "" ? "<div class='carousel-caption d-none d-md-block'>" : string.Empty;
            CarouselDiv.InnerHtml += caption5 != "" ? "<p>" + caption5 + "</p>" : string.Empty;
            CarouselDiv.InnerHtml += caption5 != "" ? "</div>" : string.Empty;
            CarouselDiv.InnerHtml += image5 != "" ? "</div>" : string.Empty;
            CarouselDiv.InnerHtml += image6 != "" ? "<div class='carousel-item'>" : string.Empty;
            CarouselDiv.InnerHtml += image6 != "" ? "<img class='carousel-image' src='" + Image6 + "' />" : string.Empty;
            CarouselDiv.InnerHtml += caption6 != "" ? "<div class='carousel-caption d-none d-md-block'>" : string.Empty;
            CarouselDiv.InnerHtml += caption6 != "" ? "<p>" + caption6 + "</p>" : string.Empty;
            CarouselDiv.InnerHtml += caption6 != "" ? "</div>" : string.Empty;
            CarouselDiv.InnerHtml += image6 != "" ? "</div>" : string.Empty;
            CarouselDiv.InnerHtml += image7 != "" ? "<div class='carousel-item'>" : string.Empty;
            CarouselDiv.InnerHtml += image7 != "" ? "<img class='carousel-image' src='" + Image7 + "' />" : string.Empty;
            CarouselDiv.InnerHtml += caption7 != "" ? "<div class='carousel-caption d-none d-md-block'>" : string.Empty;
            CarouselDiv.InnerHtml += caption7 != "" ? "<p>" + caption7 + "</p>" : string.Empty;
            CarouselDiv.InnerHtml += caption7 != "" ? "</div>" : string.Empty;
            CarouselDiv.InnerHtml += image7 != "" ? "</div>" : string.Empty;
            CarouselDiv.InnerHtml += image8 != "" ? "<div class='carousel-item'>" : string.Empty;
            CarouselDiv.InnerHtml += image8 != "" ? "<img class='carousel-image' src='" + Image8 + "' />" : string.Empty;
            CarouselDiv.InnerHtml += caption8 != "" ? "<div class='carousel-caption d-none d-md-block'>" : string.Empty;
            CarouselDiv.InnerHtml += caption8 != "" ? "<p>" + caption8 + "</p>" : string.Empty;
            CarouselDiv.InnerHtml += caption8 != "" ? "</div>" : string.Empty;
            CarouselDiv.InnerHtml += image8 != "" ? "</div>" : string.Empty;
            CarouselDiv.InnerHtml +=  "</div>";

            // Resolve controls
            olDiv.EnableViewState = (ResolveDynamicControls && ControlsHelper.ResolveDynamicControls(this));
            CarouselDiv.EnableViewState = (ResolveDynamicControls && ControlsHelper.ResolveDynamicControls(this));      
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

    #endregion
}
