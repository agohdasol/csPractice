<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmCaching.aspx.cs" Inherits="Ch11.FrmCaching" %>
<%@ Register Src="~/FrmCachingWebUserControl.ascx" TagPrefix="uc1" TagName="FrmCachingWebUserControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>캐싱</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            현재시간(웹폼) :
            <asp:Label ID="LblTimeWebForms" runat="server" Text="Label"></asp:Label>
            <hr />
            <uc1:FrmCachingWebUserControl runat="server" id="FrmCachingWebUserControl" />
        </div>
    </form>
</body>
</html>
