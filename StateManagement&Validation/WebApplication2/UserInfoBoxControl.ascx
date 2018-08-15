<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserInfoBoxControl.ascx.cs" Inherits="WebApplication2.UserInfoBoxControl" %>
<%@ Register TagPrefix="My" TagName="UserInfoBoxControl" Src="~/UserInfoBoxControl.ascx" %>

<My:UserInfoBoxControl runat="server" ID="MyUserInfoBoxControl" UserName="John Doe" UserAge="45" UserCountry="Australia" />


<%--<% %> is used to include C% command--%>


<%--<b>Information about <%= this.UserName %></b>
<br /><br />
<%= this.UserName %> is <%= this.UserAge %> years old and lives in <%= this.UserCountry %>--%>