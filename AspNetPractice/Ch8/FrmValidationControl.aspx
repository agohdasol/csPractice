<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmValidationControl.aspx.cs" Inherits="Ch8.FrmValidationControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>유효성검사 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>ASP.NET 4.5 이상에서 유효성 검사 컨트롤 사용</h1>
            <ol>
                <li>PM> Install-Package jQuery</li>
                <li>PM> Install-Package AspNet.ScriptManager.jQuery</li>
                <li>Global.asax - Application_Start(): <br />
                    System.Web.UI.ValidationSettings.UnobtrusiveValidationMode=
                    System.Web.UI.UnobtrusiveValidationMode.WebForms;
                </li>
            </ol>
            <br />
            <br />
            <h3>입력 확인 유효성검사</h3>
            아이디 :
            <asp:TextBox ID="TxtUserId" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="ValUserId" runat="server" ControlToValidate="TxtUserId"
                ErrorMessage="아이디를 입력하세요" Display="None"></asp:RequiredFieldValidator>
            (필수)<br />
            암호 :
            <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="ValPassword" runat="server" ControlToValidate="TxtPassword"
                ErrorMessage="비밀번호를 입력하세요" Display="None"></asp:RequiredFieldValidator>
            (필수)<br />
            암호 확인 :
            <asp:TextBox ID="TxtPasswordChk" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="ValPasswordChk" runat="server" ControlToValidate="TxtPasswordChk"
                ErrorMessage="비밀번호 확인" Display="None"></asp:RequiredFieldValidator>
            (필수)<br />
            <asp:CompareValidator ID="VarPasswordChk" runat="server"
                ControlToValidate="TxtPasswordChk" ControlToCompare="TxtPassword"
                SetFocusOnError="true" ErrorMessage="암호를 다시 확인해주세요"></asp:CompareValidator>
            <asp:LinkButton ID="BtnLogin" runat="server" OnClick="BtnLogin_Click">로그인</asp:LinkButton>

            <br />
            <h3>범위 확인</h3>
            나이 :
            <asp:TextBox ID="TxtAge" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="ValAge" runat="server"
                ControlToValidate="TxtAge" ErrorMessage="나이는 1~150 사이의 정수입니다"
                MinimumValue="1" MaximumValue="150" Type="Integer"
                Display="None" SetFocusOnError="true"></asp:RangeValidator>
            <br />
            학점 :
            <asp:TextBox ID="TxtScore" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="ValScore" runat="server"
                ControlToValidate="TxtScore" ErrorMessage="학점은 A부터 F까지입니다"
                MinimumValue="A" MaximumValue="F" Type="String"
                ></asp:RangeValidator>
            <hr />
            <asp:LinkButton ID="BtnCheck" runat="server">체크</asp:LinkButton>
            <br />
            <br />
            <hr />
            <h3>정규식 확인</h3>
            이메일 :
            <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="ValEmail" runat="server"
                ErrorMessage="이메일을 확인하세요" ControlToValidate="TxtEmail"
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
            </asp:RegularExpressionValidator>
            <br />
            홈페이지 :
            <asp:TextBox ID="TxtHomePage" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="ValHomePage" runat="server"
                ErrorMessage="홈페이지를 확인하세요" ControlToValidate="TxtHomePage"
                ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?">
            </asp:RegularExpressionValidator>
            <hr />
            <asp:LinkButton ID="BtnOK" runat="server">확인</asp:LinkButton>
            <br />
            <asp:ValidationSummary ID="ValSummary" runat="server"
                ShowMessageBox="true" ShowSummary="true" DisplayMode="BulletList" />
        </div>
    </form>
</body>
</html>
