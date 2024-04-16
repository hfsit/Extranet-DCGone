<%@ Control Language="C#" AutoEventWireup="true" Inherits="CMSWebParts_HFSExtranet_HFSExtranet_Card14"  CodeFile="~/CMSWebParts/HFSExtranet/HFSExtranet_Card14.ascx.cs" %>

<asp:Panel ID="pnlCard" runat="server"
    CssClass="card border-0">
    <asp:Panel ID="pnlCardHeader" runat="server"
        CssClass="card-img-top embed-responsive">
        <asp:Image ID="imgCardHeader" runat="server" CssClass="embed-responsive-item"></asp:Image>
    </asp:Panel>
    <asp:Panel ID="pnlCardBody" runat="server"
        CssClass="card-body">
    </asp:Panel>
    <asp:Panel ID="pnlCardFooter" runat="server"
        CssClass="card-footer bg-transparent pt-0 pb-4 border-top-0">
        <asp:Hyperlink ID="hplCardFooterButton" runat="server"
            CssClass="btn btn-nav"></asp:Hyperlink>
    </asp:Panel>
</asp:Panel>