<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmMemoModify.aspx.cs" Inherits="DevADONET.FrmMemoModify" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>수정 패턴</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <h3>데이터 수정</h3>
          번호 : 
          <asp:Label ID="LblNum" runat="server"></asp:Label><br />
          이름 : 
          <asp:TextBox ID="TxtName" runat="server"></asp:TextBox><br />
          이메일 : 
          <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox><br />
          메모 : 
          <asp:TextBox ID="TxtTitle" runat="server"></asp:TextBox><br />
          <asp:Button ID="BtnModify" runat="server" Text="수정" OnClick="BtnModify_Click" />
          <asp:Button ID="BtnList" runat="server" Text="리스트" OnClick="BtnList_Click" />
        </div>
    </form>
</body>
</html>
