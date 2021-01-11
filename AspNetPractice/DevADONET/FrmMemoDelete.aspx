<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmMemoDelete.aspx.cs" Inherits="DevADONET.FrmMemoDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>삭제 패턴</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <h3>글 삭제</h3>
          <asp:Label ID="LblNum" runat="server"></asp:Label>번 글을 삭제하시겠습니까?
          <asp:Button ID="BtnDelete" runat="server" Text="삭제"
            OnClientClick="return confirm('정말로 삭제하시겠습니까?');"
            OnClick="BtnDelete_Click" />
          <asp:HyperLink ID="LnkList" runat="server"
            NavigateUrl="~/FrmMemoList.aspx">리스트</asp:HyperLink>
        </div>
    </form>
</body>
</html>
