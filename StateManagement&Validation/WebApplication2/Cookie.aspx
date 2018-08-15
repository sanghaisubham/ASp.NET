<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookie.aspx.cs" Inherits="WebApplication2.Cookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cookies</title>
</head>
<body runat="server" id="BodyTag">
    <form id="form1" runat="server">
    <asp:DropDownList runat="server" id="ColorSelector" autopostback="true" onselectedindexchanged="ColorSelector_IndexChanged">
        <asp:ListItem value="White" selected="True">Select color...</asp:ListItem>
        <asp:ListItem value="Red">Red</asp:ListItem>
        <asp:ListItem value="Green">Green</asp:ListItem>
        <asp:ListItem value="Blue">Blue</asp:ListItem>
    </asp:DropDownList>
    </form>
</body>
</html>
