<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HFSExtranet_EmergentContent.ascx.cs"
    Inherits="CMSWebParts_HFSExtranet_HFSExtranet_EmergentContent" %>

<div class="container">
    <div class="row justify-content-center my-0">
        <div class="col-12 col-lg-9 my-2">
            <div id="emergent-content" class="carousel slide d-flex align-items-center" data-ride="carousel" title="Emergent Content">
                <div>
                    <a href="#emergent-content" role="button" aria-label="Previous" data-slide="prev" class="text-dark" style="font-size: 200%"><span class="fa fa-angle-left" aria-hidden="true"></span></a>
                </div>
                <div class="carousel-inner text-center mx-5 small  d-flex align-items-center">
                    <div class="carousel-item active">
                        <asp:Literal ID="litEmergentContent1" runat="server"></asp:Literal>
                    </div>
                    <div class="carousel-item" id="pnlEmergentContent2" runat="server">
                        <asp:Literal ID="litEmergentContent2" runat="server"></asp:Literal>
                    </div>
                    <div class="carousel-item" id="pnlEmergentContent3" runat="server">
                        <asp:Literal ID="litEmergentContent3" runat="server"></asp:Literal>
                    </div>
                </div>
                <div>
                    <a href="#emergent-content" role="button" aria-label="Next" data-slide="next" class="text-dark" style="font-size: 200%"><span class="fa fa-angle-right" aria-hidden="true"></span></a>
                </div>
            </div>
        </div>
    </div>
</div>
