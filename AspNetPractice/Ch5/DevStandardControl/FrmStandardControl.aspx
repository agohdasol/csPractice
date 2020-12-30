<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmStandardControl.aspx.cs" Inherits="DevStandardControl.FrmStandardControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>표준 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>1. 순수 HTML 사용해서 버튼 만들기</h1>
            <input type="button" value="버튼1" id="btnInput" />
            <h2>2. runat 속성을 추가해서 서버 컨트롤 버튼 만들기</h2>
            <input type="button" value="버튼2" runat="server" id="btnHtml" />
            <h2>3. ASP.NET 표준 컨트롤 버튼 만들기</h2>
            <asp:Button Text="버튼3" runat="server" ID="BtnServer" />
            <br />
            현재시간 :
            <asp:Label ID="LblDateTime" runat="server" BackColor="#FFFFC0"
                BorderColor="Red" BorderStyle="Solid" BorderWidth="1px"
                ForeColor="Blue" />
            <br />
            <h2>SingleLine</h2>
            이름 : 
            <asp:TextBox ID="TxtSingleLine" runat="server" CssClass="myTextAlign" />
            <h2>MultiLine</h2>
            소개 : 
            <asp:TextBox ID="TxtMultiLine" runat="server" TextMode="MultiLine" />
            <br />
            <h2>Password</h2>
            암호 : 
            <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password" />
            <hr />
            <asp:Button ID="BtnOK" runat="server" OnClick="BtnOK_Click" Text="확인" />
            <br />
            <br />
            <asp:TextBox ID="TxtNum" runat="server" />
            <asp:Button ID="BtnUp" runat="server" OnClick="BtnUp_Click" Text="증가" />
            <asp:Button ID="BtnDown" runat="server" OnClick="BtnDown_Click" Text="감소" />
            <br />
            <br />
            <asp:LinkButton ID="LnkDotNetKorea" runat="server" OnClick="LnkDotNetKorea_Click">
                닷넷코리아로 이동
            </asp:LinkButton>
            <br />
            <asp:ImageButton ID="ImgWrite" runat="server" AlternateText="글쓰기"
                OnClick="ImgWrite_Click" ToolTip="글쓰기" />
            <asp:ImageButton ID="ImgList" runat="server" AlternateText="리스트"
                OnClick="ImgList_Click" ToolTip="리스트" />
            <br />
            <br />
            버튼 컨트롤 :
            <asp:Button ID="BtnButton" runat="server" Text="버튼" OnClick="BtnCommand_Click" />
            <br />
            <asp:LinkButton ID="BtnLink" runat="server" OnClick="BtnCommand_Click">링크버튼</asp:LinkButton>
            <br />
            <asp:ImageButton ID="BtnImage" runat="server" AlternateText="이미지버튼"
                ToolTip="툴팁" OnClick="BtnImage_Click" />
            <br />
            <asp:Label ID="LblDisplay" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
