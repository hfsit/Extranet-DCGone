<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HFSExtranet_StudentQuotes.ascx.cs" Inherits="CMSWebParts_HFSExtranet_HFSExtranet_StudentQuotes" %>

<div class="carousel slide" data-ride="carousel" id="carouselQuotes">
    <div class="carousel-inner">
        <div class="carousel-item active">
            <p class="lead text-center mb-1">&quot;<asp:Literal ID="litQuote1Content" runat="server" />&quot;</p>
            <p class="text-center text-uppercase small"><strong><asp:Literal ID="litQuote1Name" runat="server" /></strong><span class="font-weight-light">,&nbsp;<asp:Literal ID="litQuote1Caption" runat="server" /></span></p>
        </div>
        <div class="carousel-item">
            <p class="lead text-center mb-1">&quot;<asp:Literal ID="litQuote2Content" runat="server" />&quot;</p>
            <p class="text-center text-uppercase small"><strong><asp:Literal ID="litQuote2Name" runat="server" /></strong><span class="font-weight-light">,&nbsp;<asp:Literal ID="litQuote2Caption" runat="server" /></span></p>
        </div>
        <div class="carousel-item">
            <p class="lead text-center mb-1">&quot;<asp:Literal ID="litQuote3Content" runat="server" />&quot;</p>
            <p class="text-center text-uppercase small"><strong><asp:Literal ID="litQuote3Name" runat="server" /></strong><span class="font-weight-light">,&nbsp;<asp:Literal ID="litQuote3Caption" runat="server" /></span></p>
        </div>
    </div>

    <ol class="carousel-indicators">
        <li class="active" data-slide-to="0" data-target="#carouselQuotes">&nbsp;</li>
        <li data-slide-to="1" data-target="#carouselQuotes">&nbsp;</li>
        <li data-slide-to="2" data-target="#carouselQuotes">&nbsp;</li>
    </ol>
</div>
