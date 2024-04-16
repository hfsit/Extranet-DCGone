<%@ Control Language="C#" AutoEventWireup="true" CodeFile="~/CMSWebParts/HFSExtranet/HFSExtranet_Button.ascx.cs" Inherits="HFSExtranet_Button" %>
<%@ Register src="~/CMSModules/PortalEngine/Controls/Editable/EditableText.ascx" tagname="EditableText" tagprefix="cms" %>

    <a ID="ButtonLink" class="button" runat="server">
        <div class="button-text"><asp:Literal ID="ltlButtonText" runat="server" /></div>
        <div class="button-slash"></div>
        <div class="button-chevron-container">
            <div class="button-chevron">
                <span class="fa fa-angle-right" aria-hidden="true"></span>
            </div>
        </div>
    </a>