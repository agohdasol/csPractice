<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmObjectDataSource.aspx.cs" Inherits="Ch15.FrmObjectDataSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <asp:GridView ID="CtlMemoList" runat="server" DataSourceID="OdsMemoList"></asp:GridView>
          <asp:ObjectDataSource ID="OdsMemoList" runat="server"
            SelectMethod="GetMemos"
            TypeName="Ch15.FrmObjectDataSourceClass"></asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
