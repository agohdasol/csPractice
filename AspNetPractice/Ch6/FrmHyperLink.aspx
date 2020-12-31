<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmHyperLink.aspx.cs" Inherits="Ch6.FrmHyperLink" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>하이퍼링크 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="LnkDotNetKorea" runat="server" NavigateUrl="http://www.dotnetkorea.com/">
                닷넷코리아(<u>D</u>)
            </asp:HyperLink>
            <br />
            <asp:Image ID="ImgChange" runat="server" ImageUrl="~/images/1.jpg" AlternateText="대체텍스트" Width="100px" Height="100px" />
            <hr />
            <asp:Button Text="이미지 순환" runat="server" ID="BtnChange" OnClick="BtnChange_Click" />
        </div>
    </form>
</body>
</html>
