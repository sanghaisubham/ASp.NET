<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Store" />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="height: 26px" Text="Fetch" />
&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
&nbsp;
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Logout" />
&nbsp;
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="111px" TextMode="MultiLine" Width="187px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    </form>
</body>
</html>
