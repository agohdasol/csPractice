<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInfo.aspx.cs" Inherits="DevUser.UserInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>회원관리 - 회원정보보기</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <h1>회원관리</h1>
          <h2>회원정보보기</h2>
          UID : <asp:Label ID="LblID" runat="server"></asp:Label><br />
          아이디 : <asp:TextBox ID="TxtUserID" runat="server"></asp:TextBox><br />
          암호 : <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password"></asp:TextBox><br />
          <asp:Button ID="BtnModify" runat="server" Text="정보 수정" OnClick="BtnModify_Click" />
        </div>
    </form>
</body>
</html>
