using System;
using System.Data;
using System.Collections;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

using CMS.PortalEngine.Web.UI;
using CMS.Helpers;

public partial class CMSWebParts_HFSExtranet_HFSExtranet_Card14 : CMSAbstractWebPart
{
    public override void OnContentLoaded()
    {
        base.OnContentLoaded();

        string BackgroundColor = GetValue("BackgroundColor").ToString();
        pnlCard.CssClass += (" " + BackgroundColor);

        bool Centered = ValidationHelper.GetBoolean(this.GetValue("Centered"), false);
        if (Centered) pnlCard.CssClass += (" " + "text-center");

        string HeaderImageAspectRatio = GetValue("HeaderImageAspectRatio").ToString();
        pnlCardHeader.CssClass += (" " + HeaderImageAspectRatio);

        string HeaderImage = GetValue("HeaderImage").ToString();
        if (!String.IsNullOrEmpty(HeaderImage)) {
            imgCardHeader.ImageUrl = HeaderImage;

            string HeaderImageAltText = ValidationHelper.GetString(this.GetValue("HeaderImageAltText"), "");
            if (!String.IsNullOrEmpty(HeaderImageAltText)) {
                imgCardHeader.AlternateText = HeaderImageAltText;
            }
            else {
                imgCardHeader.Attributes["aria-hidden"] = "true";
            }
        }
        else { pnlCardHeader.Visible = false; }



        string HeadingLevel = ValidationHelper.GetString(this.GetValue("HeadingLevel"), "");
        string Title = ValidationHelper.GetString(this.GetValue("Title"), "");

        if (!String.IsNullOrEmpty(Title)) {
            if (HeadingLevel == "h3" || HeadingLevel == "h4") {
                HtmlGenericControl TitleControl = new HtmlGenericControl(HeadingLevel);
                TitleControl.Attributes["class"] = "card-title";
                TitleControl.InnerText = Title;
                pnlCardBody.Controls.Add(TitleControl);
            }
        }

        string Content = GetValue("Content").ToString();
        pnlCardBody.Controls.Add(new LiteralControl(Content));

        string FooterButtonText = GetValue("FooterButtonText").ToString();
        if (!String.IsNullOrEmpty(FooterButtonText)) {
            hplCardFooterButton.Text = FooterButtonText;
            
            string FooterButtonStyle = GetValue("FooterButtonStyle").ToString();
            hplCardFooterButton.CssClass += (" " + FooterButtonStyle);

            string FooterButtonHyperlink = GetValue("FooterButtonHyperlink").ToString();
            hplCardFooterButton.NavigateUrl = FooterButtonHyperlink;

            bool FooterButtonOpenInNewWindow = ValidationHelper.GetBoolean(this.GetValue("FooterButtonOpenInNewWindow"), false);
            if (FooterButtonOpenInNewWindow) hplCardFooterButton.Target = "_blank";

        }
        else {
            pnlCardFooter.Visible = false;
        }

















    }
}



