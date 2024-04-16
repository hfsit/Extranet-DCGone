<%@ Page Title="" Language="C#" MasterPageFile="~/CMSTemplates/HFSExtranet/KenticoMaster.master" AutoEventWireup="true" CodeFile="HousingLocationPageTemplate.aspx.cs" Inherits="HFSExtranet_HousingLocationPageTemplate" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MasterHead" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MasterBody" Runat="Server">
    <cms:CMSPagePlaceholder ID="plcZones" runat="server">
        <LayoutTemplate>
            <cms:CMSWebPartZone ZoneID="ZonePageTitle" runat="server" />
            <div class="container">
              <div class="row">
                <div class="order-1 order-md-2 col-12 col-md-4 col-lg-3">
                  <div class="text-uppercase py-2 border-bottom"><b>Residence Halls</b></div>
                  <div id="ResHallsList">
                    <cms:CMSWebPartZone ID="ZoneHousingLocationResHallsList2" runat="server" />
                  </div>
                  <div class="text-uppercase py-2 border-bottom"><b>Apartments</b></div>
                  <div ID="ApartmentsList">
                    <cms:CMSWebPartZone ID="ZoneHousingLocationApartmentsList" runat="server" />
                  </div>
                  <div class="text-uppercase py-2 border-bottom"><b>Family Housing</b></div>
                  <div ID="FamilyApartmentsList">
                    <cms:CMSWebPartZone ID="ZoneHousingLocationFamilyApartmentsList" runat="server" />
                  </div>
                  <div class="d-none d-md-block mt-5">
                      <cms:CMSWebPartZone ID="ZoneHousingLocationSidebar" runat="server" />
                  </div>
                  
                </div>
                <div class="order-2 order-md-1 col-12 col-md-8 col-lg-9 mt-5 mt-md-0">
                  <cms:CMSWebPartZone ID="ZoneHousingLocationSlideshow" runat="server" />
                  <cms:CMSWebPartZone ID="ZoneHousingLocationTransformation" runat="server" />
                  <div class="d-md-none mt-5">
                    <cms:CMSWebPartZone ID="ZoneHousingLocationSidebarMobileOverflow" runat="server" />
                  </div>
                </div>
              </div>
            </div>
            <cms:CMSWebPartZone ID="ZoneHousingLocationApply" runat="server" />
        </LayoutTemplate>
    </cms:CMSPagePlaceholder>
</asp:Content>

