<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomValidatorExample.aspx.cs" Inherits="WebApplication2.CustomValidatorExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function ageValidator(s, e) {
            var age = parseInt(e.Value);
            if (age < 20 || age > 60)
                e.IsValid = false;
        }
        </script>
</head>
<body>
    <form id="form1" runat="server">
        
        
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Server Side Error" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
        <br />
        <br />
        <br />
        <div>
            <br />
            <br />
        </div>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:CustomValidator ID="CustomValidator2" runat="server" ClientValidationFunction="ageValidator" ControlToValidate="TextBox2" ErrorMessage="Client Side Error"></asp:CustomValidator>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
    </form>
</body>
</html>
