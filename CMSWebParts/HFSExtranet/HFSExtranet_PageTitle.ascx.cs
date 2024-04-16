using CMS.DocumentEngine;
using CMS.Helpers;
using CMS.PortalEngine;
using CMS.PortalEngine.Web.UI;
using System.Collections.Generic;

public partial class HFSExtranet_PageTitle : CMSAbstractWebPart
{

    public string PageSection { get; set; }

    public string PageTitle { get; set; }

    public override void OnContentLoaded()
    {
        base.OnContentLoaded();

        // Get the page title and section as they'd be displayed according to the Kentico content tree.

        string contentPageSection = string.Empty;
        string contentPageTitle = string.Empty;

        // Make a list of the parent nodes up to the root of the content tree. In the future these can be used to create breadcrumb hyperlinks inside
        // of this page title widget, but ComMar has decided against this for now for visibility purposes.

        // These will follow the pattern:
        // - (Current page)
        // - (Parent of current page)
        // - ...
        // - Housing & Food Services (nonexistent page at the top of the content tree)
        // - "(Root)"

        List<TreeNode> Breadcrumb = new List<TreeNode>();
        TreeNode ThisDocument = CurrentDocument;

        while (ThisDocument != null)
        {
            Breadcrumb.Add(ThisDocument);
            ThisDocument = ThisDocument.Parent;
        } 

        if (Breadcrumb.Count == 2) // "Top level pages" in the content tree
        {
            contentPageSection = "Housing & Food Services";

            switch (CurrentDocument.GetDocumentName())
            {
                // Certain pages have special subtitles that existed before these overrides were in place; technically these could be removed once
                // the widget override value is applied to each of these pages.
                case "Live":
                    contentPageTitle = "Your Husky Home";
                    break;
                case "Eat":
                    contentPageTitle = "Dining on campus";
                    break;
                case "Experience":
                    contentPageTitle = "Residential Life";
                    break;
                case "Explore":
                    contentPageTitle = "What Living on Campus Is All About";
                    break;
                default:
                    contentPageTitle = CurrentDocument.GetDocumentName();
                    break;
            }
        }
        // For anything underneath top level pages, use the document's name and the top level page title that the document lives under.
        else if (Breadcrumb.Count >= 3) 
        {
            contentPageSection = Breadcrumb[Breadcrumb.Count - 2].GetDocumentName();
            contentPageTitle = CurrentDocument.GetDocumentName();
        }

        // Priorities for page title widget display:
        // 
        // 1. HTML tag properties (e.g. <... PageTitle="blah" />) for app pages
        // 2. Overrides set in widget properties in Kentico
        // 3. Use content tree defaults

        // Returning a null default value from the ValidationHelper.GetString() default property doesn't work. So we have to assign null to the
        // string directly from an empty result in order for null-coalescing to work later.
        string overridePageSection = ValidationHelper.GetString(this.GetValue("PageSection"), "");
        string overridePageTitle = ValidationHelper.GetString(this.GetValue("PageTitle"), "");
        if (string.IsNullOrEmpty(overridePageSection)) overridePageSection = null;
        if (string.IsNullOrEmpty(overridePageTitle)) overridePageTitle = null;
        
        // Pick the highest priority value that's set.
        litPageSection.Text = PageSection ?? overridePageSection ?? contentPageSection;
        litPageTitle.Text = PageTitle ?? overridePageTitle ?? contentPageTitle;

    }
}
