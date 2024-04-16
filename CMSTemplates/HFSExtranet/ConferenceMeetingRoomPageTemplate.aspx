<%@ Page Title="" Language="C#" MasterPageFile="~/CMSTemplates/HFSExtranet/KenticoMaster.master" AutoEventWireup="true" CodeFile="ConferenceMeetingRoomPageTemplate.aspx.cs" Inherits="HFSExtranet_ConferenceMeetingRoomPageTemplate" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MasterHead" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MasterBody" Runat="Server">
    <cms:CMSPagePlaceholder ID="plcZones" runat="server">
        <LayoutTemplate>
            <cms:CMSWebPartZone ZoneID="ZonePageTitle" runat="server" />
            <div class="container">
              <div class="row">
                <div class="order-1 order-md-2 col-12 col-md-4 col-lg-3">
                  <cms:CMSWebPartZone style="border-top:1px solid #eee" ID="ZoneConferenceMeetingRoomList" runat="server" />
                  <div class="d-none d-md-block mt-5">
                      <cms:CMSWebPartZone ID="ZoneConferenceMeetingRoomSidebar" runat="server" />
                  </div>
                  
                </div>
                <div class="order-2 order-md-1 col-12 col-md-8 col-lg-9 mt-5 mt-md-0">
                  <cms:CMSWebPartZone ID="ZoneConferenceMeetingRoomSlideshow" runat="server" />
                  <cms:CMSWebPartZone ID="ZoneConferenceMeetingRoomTransformation" runat="server" />
                  <div class="d-md-none mt-5">
                    <cms:CMSWebPartZone ID="ZoneConferenceMeetingRoomSidebarMobileOverflow" runat="server" />
                  </div>
                </div>
              </div>
            </div>
        </LayoutTemplate>
    </cms:CMSPagePlaceholder>
</asp:Content>

