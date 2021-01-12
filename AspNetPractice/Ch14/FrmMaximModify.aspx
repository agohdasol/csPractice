<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmMaximModify.aspx.cs" Inherits="Ch14.FrmMaximModify" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>수정</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          번호 : <asp:Label ID="LblId" runat="server"></asp:Label><br />
          이름 : <asp:TextBox ID="TxtName" runat="server"></asp:TextBox><br />
          명언 : <asp:TextBox ID="TxtContent" runat="server"></asp:TextBox><br />
          <asp:Button ID="BtnModify" runat="server" Text="수정" OnClick="BtnModify_Click" /><br />
          <asp:Label ID="LblDisplay" runat="server"></asp:Label>
          <hr />
          <asp:HyperLink ID="LnkList" runat="server" NavigateUrl="~/FrmMaximList.aspx">리스트</asp:HyperLink>
        </div>
    </form>
</body>
</html>
