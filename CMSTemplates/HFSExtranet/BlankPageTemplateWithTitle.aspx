<%@ Page Title="" Language="C#" MasterPageFile="~/CMSTemplates/HFSExtranet/KenticoMaster.master" AutoEventWireup="true" CodeFile="BlankPageTemplateWithTitle.aspx.cs" Inherits="HFSExtranet_BlankPageTemplateWithTitle" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MasterHead" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MasterBody" Runat="Server">
    <cms:CMSPagePlaceholder ID="plcZones" runat="server">
        <LayoutTemplate>
            <div class="container">
                <div class="row mt-3 mb-3 justify-content-center">
                    <div class="col-12 col-lg-9">
                        <div class="page-title">
                            <div class="page-title-header">
                                <div>
                                    <h1><%= CurrentPage.NodeAliasPath %></h1>
                                </div>
                            </div>
                            <div class="boundless-slash purple"></div>
                            <div class="page-title-content">
                                <div>
                                    <h3><%= CurrentPage.NodeName %></h3>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <cms:CMSWebPartZone ID="zoneMain" runat="server" WidgetZoneType="Editor" />
        </LayoutTemplate>
    </cms:CMSPagePlaceholder>  
</asp:Content>

