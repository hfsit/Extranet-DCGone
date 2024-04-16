<%@ Control Language="C#" AutoEventWireup="true" CodeFile="~/CMSWebParts/HFSExtranet/HFSExtranet_PageTitle.ascx.cs" Inherits="HFSExtranet_PageTitle" %>

<style>
    .preheader {
        text-transform: uppercase;
        font-weight: 600;
        color: #4b2e83;
        line-height: initial;
        margin-bottom: initial;
        font-size: initial;
        font-family: unset; // initial sets this to the browser default on some browsers
    }
</style>

<div class="container">
    <div class="row justify-content-center">
        <div class="col-12">
            <h2 class="preheader"><asp:Literal ID="litPageSection" runat="server" /></h2>
            <h1 class="m-0"><asp:Literal ID="litPageTitle" runat="server" /></h1>
        </div>
    </div>
</div>
