<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmSqlDataSource.aspx.cs" Inherits="Ch15.FrmSqlDataSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>SqlDataSource 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <asp:DropDownList ID="LstMemoName" runat="server" DataSourceID="SqlMemoName" DataTextField="Name" DataValueField="Num">
          </asp:DropDownList>
          <asp:SqlDataSource ID="SqlMemoName" runat="server" ConnectionString="<%$ ConnectionStrings:DevADONETConnectionString %>" SelectCommand="SELECT [Num], [Name] FROM [Memos] ORDER BY [Num] DESC"></asp:SqlDataSource>
          <br />
          <br />
          <hr />
          <asp:Repeater ID="CtlMemoList" DataSourceID="SqlMemoList" runat="server">
            <HeaderTemplate>
              <table border="0">
                <tr><td>제목</td></tr>
            </HeaderTemplate>
            <ItemTemplate>
              <tr><td><%# Eval("Title") %></td></tr>
            </ItemTemplate>
            <AlternatingItemTemplate>
              <tr><td style="background-color:yellow;">
                <%# Eval("Title") %>
                  </td></tr>
            </AlternatingItemTemplate>
            <SeparatorTemplate>
              <tr><td style="height:1px;background-color:red;"></td></tr>
            </SeparatorTemplate>
            <FooterTemplate>
              <tr><td>완료</td></tr>
              </table>
            </FooterTemplate>
          </asp:Repeater>
          <asp:SqlDataSource ID="SqlMemoList" runat="server" ConnectionString='<%$ ConnectionStrings:DevADONETConnectionString %>' SelectCommand="SELECT [Num], [Name], [Title] FROM [Memos] ORDER BY [Num] DESC"></asp:SqlDataSource>
          <asp:DataList ID="CtlMemoList2" DataSourceID="SqlMemoList2" RepeatColumns="3" RepeatDirection="Horizontal" runat="server">
            <HeaderTemplate>
              <span>이름</span>
            </HeaderTemplate>
            <HeaderStyle Font-Bold="true" />
            <ItemTemplate>
              <%# Eval("Name") %>
            </ItemTemplate>
            <ItemStyle ForeColor="Green" />
            <AlternatingItemTemplate>
              <%# DataBinder.Eval(Container.DataItem,"Name") %>
            </AlternatingItemTemplate>
            <AlternatingItemStyle ForeColor="Blue" />
          </asp:DataList>
          <asp:SqlDataSource ID="SqlMemoList2" runat="server"
            ConnectionString="<%$ ConnectionStrings:DevADONETConnectionString %>"
            SelectCommand="Select * From Memos Order By Num Desc"></asp:SqlDataSource>
          <br />
          <br />
          <hr />
          <asp:DetailsView ID="CtlMemoView" runat="server" Height="50px" Width="125px"
            DataSourceID="SqlMemoView" AutoGenerateRows="true" DataKeyNames="Num">
            <Fields>
              <asp:BoundField DataField="Num" HeaderText="번호" />
              <asp:TemplateField HeaderText="이름">
                <ItemTemplate>
                  <a href="FrmSqlDataSource.aspx?Num=<%# Eval("Num") %>">
                    <%# Eval("Title") %>
                  </a>
                </ItemTemplate>
              </asp:TemplateField>
            </Fields>
          </asp:DetailsView>
          <asp:SqlDataSource ID="SqlMemoView" runat="server" ConnectionString='<%$ ConnectionStrings:DevADONETConnectionString %>' SelectCommand="SELECT * FROM [Memos] WHERE ([Num] = @Num)">
            <SelectParameters>
              <asp:QueryStringParameter QueryStringField="Num" Name="Num" Type="Int32"></asp:QueryStringParameter>
            </SelectParameters>
          </asp:SqlDataSource>
          <br />
          <hr />
          <asp:FormView ID="CtlMemoFormView" runat="server" DataSourceID="SqlMemoView" DataKeyNames="Num">
            <ItemTemplate>
              작성자 : <%# Eval("Name") %><br />
              메모 : <%# Eval("Title") %><br />
            </ItemTemplate>
          </asp:FormView>
        </div>
    </form>
</body>
</html>
