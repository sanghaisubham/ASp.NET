<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Events.aspx.cs" Inherits="WebApplication2.Events" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:DropDownList ID="DropDownList1" runat="server" autopostback="true" onselectedindexchanged="DropDown1_SelectedIndexChanged">
            <asp:ListItem>UHG</asp:ListItem>
            <asp:ListItem>Amazon</asp:ListItem>
            <asp:ListItem>Google</asp:ListItem>
            <asp:ListItem>Microsoft</asp:ListItem>
            <asp:ListItem>Apple</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        
        <p>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
