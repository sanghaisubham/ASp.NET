<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cache_Substitution.aspx.cs" Inherits="WebApplication2.Cache_Substitution" %>
<%@ OutputCache Duration="20" VaryByParam="None" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Caching Substitution</title>
</head>
<body>
    <form id="form1" runat="server">
        Cache datestamp:<br />
        <%=DateTime.Now.ToString() %><br /><br />
        Fresh datestamp:<br />
        <asp:Substitution runat="server" id="UnCachedArea" MethodName="GetFreshDateTime" />

        <div>
        </div>
    </form>
</body>
</html>
