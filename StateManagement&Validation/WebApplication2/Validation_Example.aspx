<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validation_Example.aspx.cs" Inherits="WebApplication2.Validation_Example" %>

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
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Required Field" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox1" ControlToValidate="TextBox2" ErrorMessage="CompareValidator" ForeColor="#FF3300" Operator="GreaterThan"></asp:CompareValidator>
        <br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox3" Enabled="False" ErrorMessage="RangeValidator" ForeColor="#00CCFF" MaximumValue="31-02-2003" MinimumValue="31-01-2003" Type="Date"></asp:RangeValidator>
        <br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="RegularExpressionValidator" ForeColor="#990000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" />
    </form>
</body>
</html>
