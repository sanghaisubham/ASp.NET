<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Caching.aspx.cs" Inherits="WebApplication2.Caching" %>

<%@ OutputCache Duration="10" VaryByParam="p" %>

<%--<%@ OutputCache Duration="10" varybyparam="none" VaryByControl="DropDownList1"%>--%>




<%--Now time is only refreshed every 10 sec.Duration parameter tells the page
how many seconds to cache the content.
Each Time page is requested, ASP.NET checks if page is in cache , and if it is whether
or not it has expired .It's served from cache if it isn't expired,if it is,the page
isremoved from the cache and page is generated from scratch and then placed in cache--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Caching</title>
</head>
<body>
    <form id="form1" runat="server">
        <%= DateTime.Now.ToString() %><br />
        <a href="?p=1">1</a><br />
        <a href="?p=2">2</a><br />
        <a href="?p=3">3</a><br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" style="margin-top: 0px">
            <asp:ListItem>Red</asp:ListItem>
            <asp:ListItem>Green</asp:ListItem>
            <asp:ListItem>Blue</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
<%--Here Now, each link has its own timestamp,based on when we first accessed the page--%>
        <div>
        </div>
    </form>
</body>
</html>
