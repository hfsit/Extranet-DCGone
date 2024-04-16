<%@ Page Title="" Language="C#" MasterPageFile="~/CMSTemplates/HFSExtranet/KenticoMaster.master" AutoEventWireup="true"
    CodeFile="BlankPageTemplateWithSideNav.aspx.cs" Inherits="HFSExtranet_BlankPageTemplateWithSideNav" %>


    <asp:Content ID="Content2" ContentPlaceHolderID="MasterHead" Runat="Server">
    </asp:Content>
    <asp:Content ID="Content3" ContentPlaceHolderID="MasterBody" Runat="Server">
        <cms:CMSPagePlaceholder ID="plcZones" runat="server">
            <LayoutTemplate>
                <cms:CMSWebPartZone ID="zoneTop" runat="server" />
                <div class="container">
                    <div class="row">
                        <div class="col-12 col-lg-3 p-3">
                            <cms:CMSWebPartZone ID="zoneMenu" runat="server" />
                            <cms:CMSWebPartZone ID="zonePostMenu" runat="server" />
                        </div>
                        <div class="col-12 col-lg-9 p-3">
                            <cms:CMSWebPartZone ID="zoneContent" runat="server" />
                        </div>
                    </div>
                </div>
            </LayoutTemplate>
        </cms:CMSPagePlaceholder>
    </asp:Content>