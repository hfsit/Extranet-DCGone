<%@ Page Title="" Language="C#" MasterPageFile="~/CMSTemplates/HFSExtranet/KenticoMaster.master" AutoEventWireup="true" CodeFile="ConferenceGuestRoomPageTemplate.aspx.cs" Inherits="HFSExtranet_ConferenceGuestRoomPageTemplate" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MasterHead" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MasterBody" Runat="Server">
    <cms:CMSPagePlaceholder ID="plcZones" runat="server">
        <LayoutTemplate>
            <cms:CMSWebPartZone ZoneID="ZonePageTitle" runat="server" />
            <div class="container">
              <div class="row">
                <div class="order-1 order-md-2 col-12 col-md-4 col-lg-3">
                  <div class="text-uppercase pt-1 pb-1" style="border-bottom: 1px solid #eee"><b>West Campus</b></div>
                  <div ID="WestCampusList">
                    <cms:CMSWebPartZone ID="ZoneConferenceGuestRoomWestCampusList" runat="server" />
                  </div>
                  <div class="text-uppercase pt-1 pb-1" style="border-bottom: 1px solid #eee"><b>North Campus</b></div>
                  <div ID="WestCampusList">
                    <cms:CMSWebPartZone ID="ZoneConferenceGuestRoomNorthCampusList" runat="server" />
                  </div>
                  <div class="d-none d-md-block mt-5">
                      <cms:CMSWebPartZone ID="ZoneConferenceGuestRoomSidebar" runat="server" />
                  </div>
                  
                </div>
                <div class="order-2 order-md-1 col-12 col-md-8 col-lg-9 mt-5 mt-md-0">
                  <cms:CMSWebPartZone ID="ZoneConferenceGuestRoomSlideshow" runat="server" />
                  <cms:CMSWebPartZone ID="ZoneConferenceGuestRoomTransformation" runat="server" />
                  <div class="d-md-none mt-5">
                    <cms:CMSWebPartZone ID="ZoneConferenceGuestRoomSidebarMobileOverflow" runat="server" />
                  </div>
                </div>
              </div>
            </div>
        </LayoutTemplate>
    </cms:CMSPagePlaceholder>
</asp:Content>

