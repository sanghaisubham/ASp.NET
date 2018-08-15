<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListBox.aspx.cs" Inherits="WebApplication2.ListBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-top: 14px" Width="174px"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
        <asp:ListBox ID="ListBox2" runat="server" AutoPostBack="True" Height="102px" OnSelectedIndexChanged="ListBox2_SelectedIndexChanged" Width="103px">
            <asp:ListItem>RED</asp:ListItem>
            <asp:ListItem>GREEN</asp:ListItem>
            <asp:ListItem>BLUE</asp:ListItem>
        </asp:ListBox>
        <p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
&nbsp;<asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Insert" Width="69px" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Delete" Width="55px" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Update" Width="55px" />
&nbsp;
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Select" Width="73px" />
    </form>
</body>
</html>
