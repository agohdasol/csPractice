<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ch15.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>그리드뷰 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <asp:GridView ID="CtlMemoList" DataSourceID="SqlMemoList" runat="server" AutoGenerateColumns="False" DataKeyNames="Num">
            <Columns>
              <asp:BoundField DataField="Num" HeaderText="번호" ReadOnly="True" InsertVisible="False" SortExpression="Num"></asp:BoundField>
              <asp:BoundField DataField="Name" HeaderText="작성자" SortExpression="Name"></asp:BoundField>
              <asp:BoundField DataField="Email" HeaderText="이메일" SortExpression="Email"></asp:BoundField>
              <asp:BoundField DataField="Title" HeaderText="메모" SortExpression="Title"></asp:BoundField>
              <asp:BoundField DataField="PostDate" HeaderText="작성일" SortExpression="PostDate"></asp:BoundField>
              <asp:BoundField DataField="PostIP" HeaderText="작성IP" SortExpression="PostIP"></asp:BoundField>
            </Columns>
          </asp:GridView>
          <asp:SqlDataSource ID="SqlMemoList" runat="server" ConnectionString='<%$ ConnectionStrings:DevADONETConnectionString %>' SelectCommand="SELECT * FROM [Memos] ORDER BY [Num] DESC"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
