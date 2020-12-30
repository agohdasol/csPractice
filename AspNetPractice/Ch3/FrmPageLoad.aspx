<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmPageLoad.aspx.cs" Inherits="Ch3.FrmPageLoad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Page 클래스</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="BtnPostBack" runat="server" Text="다시 게시" OnClick="BtnPostBack_Click" />
            <asp:Button ID="BtnNewLoad" runat="server" Text="다시 로드" OnClick="BtnNewLoad_Click" />
        </div>
    </form>
</body>
</html>
