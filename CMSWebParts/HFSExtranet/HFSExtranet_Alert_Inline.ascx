<%@ Control Language="C#" AutoEventWireup="true" Inherits="CMSWebParts_HFSExtranet_HFSExtranet_Alert"  CodeFile="~/CMSWebParts/HFSExtranet/HFSExtranet_Alert.ascx.cs" %>

<script>
    // Add the alert-link style to all hyperlinks in the alert box
window.addEventListener('DOMContentLoaded', (event) => {
    document.querySelectorAll(".alert a:not(.alert-link)").forEach(function(thisAlert) {
        thisAlert.classList.add("alert-link");
    });
});
</script>

<div class="alert alert-warning" role="alert">
    <asp:Panel ID="pnlAlert" runat="server" />
</div>
