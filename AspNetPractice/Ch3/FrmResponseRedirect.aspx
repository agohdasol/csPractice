<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmResponseRedirect.aspx.cs" Inherits="Ch3.FrmResponseRedirect" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Response 개체</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="BtnDotNetKorea" runat="server"
                Text="닷넷코리아" OnClick="BtnDotNetKorea_Click" />
            <br />
            <asp:LinkButton ID="BtnDevLec" runat="server"
                OnClick="BtnDevLec_Click">데브렉</asp:LinkButton>
            <br />
            <asp:ImageButton ID="BtnVisualAcademy" runat="server"
                AlternateText="비주얼아카데미" ToolTip="하와소"
                OnClick="BtnVisualAcademy_Click" Style="height: 16px" />
            <br />
        </div>
    </form>
</body>
</html>
