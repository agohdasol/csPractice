<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmMaximWrite.aspx.cs" Inherits="Ch14.Repositories.FrmMaximWrite" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>입력</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          이름 : <asp:TextBox ID="TxtName" runat="server"></asp:TextBox><br />
          명언 : <asp:TextBox ID="TxtContent" runat="server"></asp:TextBox><br />
          <asp:Button ID="BtnWrite" runat="server" Text="저장" OnClick="BtnWrite_Click" /><br />
          <asp:Label ID="LblDisplay" runat="server"></asp:Label>
          <hr />
          <asp:HyperLink ID="LnkList" runat="server" NavigateUrl="~/FrmMaximList.aspx">리스트</asp:HyperLink>

        </div>
    </form>
</body>
</html>
