<%@ Page Title="" Language="C#" MasterPageFile="~/CMSTemplates/HFSExtranet/Master.master" AutoEventWireup="true" CodeFile="HFSMain.aspx.cs" Inherits="CMSTemplates_HFSExtranet_HFSMain" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="MasterTitle" Runat="Server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="MasterHead" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MasterBody" Runat="Server">
    <div>
        <cms:CMSPagePlaceholder ID="plcZones" runat="server">
            <LayoutTemplate>
                <cms:CMSWebPartZone ID="zoneMain" runat="server" WidgetZoneType="Editor" />
            </LayoutTemplate>
        </cms:CMSPagePlaceholder>   
    </div>
</asp:Content>

