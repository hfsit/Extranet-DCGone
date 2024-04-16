<%@ Control Language="C#" AutoEventWireup="true" Inherits="CMSWebParts_HFSExtranet_HFSExtranet_LandingPageHero"  CodeFile="~/CMSWebParts/HFSExtranet/HFSExtranet_LandingPageHero.ascx.cs" %>

<style>
    .lphero--content-container {
        margin: 1.5rem 0;
    }

    @media (min-width: 768px) {
        .lphero--container {
            position: relative;
            display: block;
            width: 100%;
            padding: 0;
            overflow: hidden;
        }

        .lphero--container::before {
            display: block;
            content: "";
            padding-top: 75%;
        }

        .lphero--image {
            position: absolute;
            top: 0px;
            bottom: 0px;
            left: 0px;
            width: 100%;
            height: 100%;
            object-fit: cover;
        }

        .lphero--content-container {
            position: absolute;
            margin: 0;
            top: 0;
            right: 0;
            width: 480px;
            max-width: 100%;
            max-height: 100%;
            padding: 1.5rem;
        }

        .lphero--content {
            width: 100%;
            height: 100%;
            background-color: rgba(255,255,255,0.85);
            padding: 1.5rem;
        }

        @media (min-width: 1200px) {
            .lphero--container::before {
                padding-top: 50%;
            }
        }
    }

</style>

<div class="container">
    <div class="row">
        <div class="col-12">
            <div class="lphero--container">
                <asp:Image ID="imgLandingPageHeroImage" runat="server"
                    CssClass="lphero--image"></asp:Image>
                <div class="lphero--content-container">
                    <asp:Panel ID="pnlLPHeroContent" runat="server"
                        CssClass="lphero--content">
                        <asp:Hyperlink ID="hplLPHeroButton" runat="server"
                            CssClass="btn btn-primary btn-nav mt-2"></asp:Hyperlink>
                    </asp:Panel>
                </div>
            </div>
        </div>
    </div>
</div>