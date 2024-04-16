<%@ Control Language="C#" AutoEventWireup="true" Inherits="CMSWebParts_HFSExtranet_HFSExtranet_FaqAccordion"  CodeFile="~/CMSWebParts/HFSExtranet/HFSExtranet_FaqAccordion.ascx.cs" %>
<style>

    .accordion {
        margin: 1rem 0;
        padding-left: 1rem;
    }

    .accordion-new {
        border-left: solid gold 0.3rem;
        padding-left: 0.7rem;
    }

    .accordion .accordion-title {
        cursor: pointer;
        padding: 0.5rem 0;
        margin-bottom: 0.2em;
        margin-left: 0.5rem;
    }

    .accordion .accordion-details {
        height: 0;
        overflow: hidden;
        transition-property: height;
        transition-duration: 400ms;
    }

    .accordion-expanded .accordion-details {
        height: unset;
    }

    .accordion .accordion-chevron {
        transition-property: transform;
        transition-duration: 400ms;
        transform: rotate(0deg);
    }

    .accordion-expanded .accordion-chevron {
        transform: rotate(90deg);
    }
</style>
<asp:Panel ID="pnlAccordion" runat="server"
    CssClass="accordion">
    <h3 class="accordion-title h4" onclick="$(this).parent().toggleClass('accordion-expanded');return false;">
        <span class="accordion-chevron fa fa-angle-right" aria-hidden="true"></span>&ensp;<asp:Literal ID="litAccordionTitle" runat="server" />
    </h3>
    <asp:Panel ID="pnlAccordionDetails" runat="server"
            CssClass="accordion-details" />
</asp:Panel>
