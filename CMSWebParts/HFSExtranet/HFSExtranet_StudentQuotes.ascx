<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HFSExtranet_StudentQuotes.ascx.cs" Inherits="CMSWebParts_HFSExtranet_HFSExtranet_StudentQuotes" %>

<div class="container">
    <div class="row justify-content-center my-2">
        <div class="align-items-center col-12 col-lg-9">
            <div class="d-flex align-items-center col-12 col-lg-12">
                <div class="owl-carousel owl-theme" id="owl-carousel">
                    <div class="item">
                        <div class="inner">
                            <p class="lead text-center mb-1">&quot;<asp:literal id="litQuote1Content" runat="server" />&quot;</p>
                            <p class="text-center text-uppercase small">
                                <strong>
                                    <asp:literal id="litQuote1Name" runat="server" />
                                </strong>
                                <span class="font-weight-light">,&nbsp;<asp:literal id="litQuote1Caption" runat="server" /></span>
                            </p>
                        </div>
                    </div>

                    <div class="item">
                        <div class="inner">
                            <p class="lead text-center mb-1">&quot;<asp:literal id="litQuote2Content" runat="server" />&quot;</p>
                            <p class="text-center text-uppercase small">
                                <strong>
                                    <asp:literal id="litQuote2Name" runat="server" />
                                </strong>
                                <span class="font-weight-light">,&nbsp;<asp:literal id="litQuote2Caption" runat="server" /></span>
                            </p>
                        </div>
                    </div>

                    <div class="item">
                        <div class="inner">
                            <p class="lead text-center mb-1">&quot;<asp:literal id="litQuote3Content" runat="server" />&quot;</p>
                            <p class="text-center text-uppercase small">
                                <strong>
                                    <asp:literal id="litQuote3Name" runat="server" />
                                </strong>
                                <span class="font-weight-light">,&nbsp;<asp:literal id="litQuote3Caption" runat="server" /></span>
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<script src="https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/owl.carousel.min.js"></script>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/assets/owl.carousel.css" />
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/OwlCarousel2/2.3.4/assets/owl.theme.default.css" />

<style>
.owl-carousel .owl-nav button:focus {
outline: none;
}
.owl-carousel .owl-nav button:focus span {
color: black;
}
    .ImageCaption {
        margin-top: -60px;
        text-align: center;
        width: 100%;
        color: #fff;
        padding-bottom: 20px;
        padding-top: 20px;
        background-color: rgba(0, 0, 0, .7);
    }

    .owl-carousel .item {
        height: 10rem;
        text-align: center;
        padding: 1rem;
        display: flex;
        align-items: center;
        justify-content: center;
    }

    .item .inner {
        display: inline-block;
    }

    .owl-carousel .owl-nav button.owl-prev, .owl-carousel .owl-nav button.owl-prev, .owl-carousel button.owl-dot.owl-nav {
        position: absolute;
        left: 20px;
        top: 50%;
        /*background-color: var(--base-color) !important;*/
        display: block;
        padding: 0 .3em !important;
        font-size: 3em;
        margin: 0;
        /*cursor: pointer;*/
        color: black;
        transform: translate(-50%, -50%);
    }

    .owl-nav span:hover {
        color: #000;
        background: none;
    }

    .owl-nav span {
        color: #85754d;
    }

    .owl-carousel .owl-nav button.owl-next, .owl-carousel .owl-nav button.owl-next, .owl-carousel button.owl-dot.owl-nav {
        position: absolute;
        right: -23px;
        top: 50%;
        /*background-color: var(--base-color) !important;*/
        display: block;
        padding: 0 .3em !important;
        font-size: 3em;
        margin: 0;
        /*cursor: pointer;*/
        color: black;
        transform: translate(-50%, -50%);
    }

    .carousel-inner {
        margin: auto;
        /*width: max-content*/
    }

    .owl-theme .owl-nav [class*=owl-]:hover {
        background: none !important;
    }
</style>

<script>  
    $(document).keydown(function (e) {
        if (e.keyCode == 37) {
            // Left arrow key
            $("#owl-carousel").trigger('prev.owl.carousel');
        } else if (e.keyCode == 39) {
            // Right arrow key
            $("#owl-carousel").trigger('next.owl.carousel');
        }
    });

    $(document).ready(function () {
        var owl = $('.owl-carousel');
        owl.owlCarousel({
            loop: true,
            margin: 10,
            nav: true,
            items: 1,
        });
    });
</script>

<!--
<div class="carousel slide" data-ride="carousel" id="carouselQuotes">
    <div class="carousel-inner">
        <div class="carousel-item active">
            <p class="lead text-center mb-1">&quot;<asp:Literal ID="litQuote1Content" />&quot;</p>
            <p class="text-center text-uppercase small"><strong><asp:Literal ID="litQuote1Name" /></strong><span class="font-weight-light">,&nbsp;<asp:Literal ID="litQuote1Caption" /></span></p>
        </div>
        <div class="carousel-item">
            <p class="lead text-center mb-1">&quot;<asp:Literal ID="litQuote2Content" />&quot;</p>
            <p class="text-center text-uppercase small"><strong><asp:Literal ID="litQuote2Name" /></strong><span class="font-weight-light">,&nbsp;<asp:Literal ID="litQuote2Caption" /></span></p>
        </div>
        <div class="carousel-item">
            <p class="lead text-center mb-1">&quot;<asp:Literal ID="litQuote3Content" />&quot;</p>
            <p class="text-center text-uppercase small"><strong><asp:Literal ID="litQuote3Name" /></strong><span class="font-weight-light">,&nbsp;<asp:Literal ID="litQuote3Caption" /></span></p>
        </div>
    </div>

    <ol class="carousel-indicators">
        <li class="active" data-slide-to="0" data-target="#carouselQuotes">&nbsp;</li>
        <li data-slide-to="1" data-target="#carouselQuotes">&nbsp;</li>
        <li data-slide-to="2" data-target="#carouselQuotes">&nbsp;</li>
    </ol>
</div>
-->

