<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmStateManagement.aspx.cs" Inherits="Ch11.FrmStateManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>
        <%= System.Web.Configuration.WebConfigurationManager.AppSettings["SITE_NAME"].ToString() %>
    </title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>서버에 저장</h3>
            Application 개체: <asp:TextBox ID="TxtApplication" runat="server" /><br />
            Session 개체: <asp:TextBox ID="TxtSession" runat="server" /><br />
            Cache 개체: <asp:TextBox ID="TxtCache" runat="server" /><br />
            <h3>클라이언트에 저장</h3>
            Cookies 개체: <asp:TextBox ID="TxtCookies" runat="server" /><br />
            ViewState 개체: <asp:TextBox ID="TxtViewState" runat="server" /><br />
            <hr />
            <asp:LinkButton ID="BtnSave" runat="server" OnClick="BtnSave_Click">
                상태 변수에 데이터 저장
            </asp:LinkButton>&nbsp;
            <asp:LinkButton ID="BtnPostBack" runat="server">다시 게시</asp:LinkButton>
            <br />
            <asp:Label ID="LblNow" runat="server"></asp:Label>
            <br />
            <asp:Label ID="LblSITE_NAME" runat="server"></asp:Label>
            <hr />
            <asp:Label ID="LblCOMPANY_NAME" runat="server"></asp:Label>
            <hr />
            <asp:Label ID="LblASPNETBOOKTEST_ConnectionString" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
