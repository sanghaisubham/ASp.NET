<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validation1.aspx.cs" Inherits="WebApplication2.Validation1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" />
        </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Must Provide A Name" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>--Select a Country--</asp:ListItem>
            <asp:ListItem>India</asp:ListItem>
            <asp:ListItem>Japan</asp:ListItem>
            <asp:ListItem>China</asp:ListItem>
            <asp:ListItem>USA</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Must Select a Country" ForeColor="Red" InitialValue="--Select a Country--"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Out of range" MaximumValue="1/31/2018" MinimumValue="1/1/2018" Type="Date"></asp:RangeValidator>
        <br />
        <br />
        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox4" ErrorMessage="Does Not match" ForeColor="Red"></asp:CompareValidator>
        <br />
        <br />
        <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="InValid" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </form>
</body>
</html>
