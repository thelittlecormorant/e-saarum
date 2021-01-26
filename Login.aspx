<%@ Page Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Default4" Title="Untitled Page" %>

<%-- Add content controls here --%>
<asp:Content ContentPlaceHolderID="styles" runat="server">
    <style type="text/css">
.wrapper .loginctrl
{
	
	margin-left:60px;
}

</style>

</asp:Content>

<asp:Content ContentPlaceHolderID="contentplaceholder5" runat="server">
    <div align="center" class="loginctrl">

    <asp:Login ID="Login1" runat="server" Height="177px" Width="294px">
    </asp:Login>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />

</div>

</asp:Content>