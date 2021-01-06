<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmStateShow.aspx.cs" Inherits="Ch11.FrmStateShow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>저장된 상태보기</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>서버에 저장</h3>
            Application 개체: <asp:TextBox ID="TxtApplication" runat="server" /><br />
            Session 개체: <asp:TextBox ID="TxtSession" runat="server" /><br />
            Cache 개체: <asp:TextBox ID="TxtCache" runat="server" /><br />
            <h3>클라이언트에 저장</h3>
            Cookies 개체: <asp:TextBox ID="TxtCookies" runat="server" /><br />
            ViewState 개체: <asp:TextBox ID="TxtViewState" runat="server" /><br />
        </div>
    </form>
</body>
</html>
