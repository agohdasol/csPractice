<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmSqlConnection.aspx.cs" Inherits="DevADONET.FrmSqlConnection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>SqlConnection 클래스</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <asp:Button ID="BtnSqlConnection" runat="server"
            Text="SQL Server에 연결하기" OnClick="BtnSqlConnection_Click" />
          <hr />
          <asp:Label ID="LblDisplay" runat="server"></asp:Label>
          <br />
          <hr />
          <asp:Button ID="BtnSqlCommand" runat="server" Text="입력 예시문 실행" OnClick="BtnSqlCommand_Click" />
          <br />
          <hr />
          <asp:Literal ID="TblOutput" runat="server"></asp:Literal>
          <br />
          <hr />
          <asp:GridView ID="CtlMemoLists" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
