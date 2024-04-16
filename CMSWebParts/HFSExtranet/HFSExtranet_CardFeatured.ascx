<%@ Control Language="C#" AutoEventWireup="true" CodeFile="~/CMSWebParts/HFSExtranet/HFSExtranet_CardFeatured.ascx.cs" Inherits="HFSExtranet_CardFeatured" %>

<div class="container">
    <div class="row no-gutters">
        <div class="col-12 col-lg-6 embed-responsive embed-responsive-16by9">
            <asp:Image ID="imgFeaturedCardImage" runat="server"
                CssClass="embed-responsive-item"></asp:Image>
        </div>
        <div class="col-12 col-lg-6">
            <asp:Panel ID="pnlFeaturedCard" runat="server"
                CssClass="card border-0">
                <asp:Panel ID="pnlCardBody" runat="server"
                    CssClass="card-body">
                </asp:Panel>
                <div class="card-footer bg-transparent pt-0 pb-4 border-top-0">
                    <asp:Hyperlink ID="hplFeaturedCardButton" runat="server"
                        CssClass="btn btn-nav btn-primary"></asp:Hyperlink>
                </div>
            </asp:Panel>
        </div>
    </div>
</div>