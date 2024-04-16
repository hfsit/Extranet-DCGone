<%@ Control Language="C#" AutoEventWireup="true" CodeFile="~/CMSWebParts/HFSExtranet/HFSExtranet_Card.ascx.cs"
    Inherits="HFSExtranet_Card" %>
<%@ Register Src="~/CMSModules/PortalEngine/Controls/Editable/EditableImage.ascx"
    TagName="EditableImage" TagPrefix="cms" %>

<article class="card h-100 background-gray-light border-0">
    <asp:Panel ID="CardTop" runat="server" CssClass="card-image-top embed-responsive embed-responsive-16by9">
        <div class="embed-responsive-item">
            <cms:EditableImage ID="eiCardImage" runat="server" />
        </div>
    </asp:Panel>


    <div class="card-body">
        <h1 class="h4 card-title mb-2">
            <asp:Literal ID="ltlCardTitle" runat="server" /></h1>
        <div class="card-text">
            <asp:Literal ID="ltlCardText" runat="server" /></div>
    </div>

    <div class="card-footer bg-transparent pt-0 pb-4 border-top-0">
        <a id="CardLink" class="btn btn-nav btn-primary" runat="server">
            <asp:Literal ID="ltlButtonText" runat="server" />
        </a>
    </div>
</article>
