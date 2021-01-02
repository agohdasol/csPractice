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
            <br />
            <img src="images/img_imagemap.jpg" alt="이미지맵 테스트용 이미지" />
            <hr />
            <asp:ImageMap ID="MapImage" runat="server" ImageUrl="~/images/img_imagemap.jpg">
                <asp:RectangleHotSpot NavigateUrl="http://naver.com" Top="0" Left="0" Bottom="20" Right="120" />
                <asp:RectangleHotSpot NavigateUrl="http://daum.net" Top="20" Left="0" Bottom="40" Right="120" />
            </asp:ImageMap>
            <asp:Table ID="Table1" runat="server" BorderWidth="1px">
                <asp:TableRow>
                    <asp:TableCell>
                        1행 1열 테이블
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <hr />
            <asp:Table ID="CtlMyTable" runat="server"></asp:Table>
            <br />
            <br />
            <asp:BulletedList ID="LstFavorite" runat="server" BulletStyle="Numbered" DisplayMode="LinkButton"
                OnClick="LstFavorite_Click">
                <asp:ListItem>Windows Server</asp:ListItem>
                <asp:ListItem Text="SQL Server" Value="시퀄서버"></asp:ListItem>
                <asp:ListItem Value="비주얼스튜디오">Visual Studio</asp:ListItem>
            </asp:BulletedList>
        </div>
    </form>
</body>
</html>
