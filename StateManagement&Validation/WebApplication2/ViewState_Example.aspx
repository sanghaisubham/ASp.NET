﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewState_Example.aspx.cs" Inherits="WebApplication2.ViewState_Example" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 26px" Text="Button" />
        <asp:HiddenField ID="HiddenField1" runat="server" />
    </form>
</body>
</html>
