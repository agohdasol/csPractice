<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BoardEditorFormControl.ascx.cs" Inherits="MemoEngine.DotNetNote.Controls.BoardEditorFormControl" %>
<style>
  .BoardWriteFormTableLeftStyle{
    width:100px;text-align:right;
  }
</style>
<h2 style="text-align:center;">게시판</h2>
<asp:Label ID="LblTitleDecription" runat="server" ForeColor="#ff0000"></asp:Label>
<hr />
<table style="width:600px; border-collapse:collapse; padding:5px; margin-left:auto;margin-right:auto;">
  <% if (!String.IsNullOrEmpty(Request.QueryString["Id"]) && FormType == DotNetNote.Models.BoardWriteFormType.Modify) { %>
  <tr>
    <td class="BoardWriteFormTableLeftStyle">
      <span style="color:#ff0000;">*</span>번 호
    </td>
    <td style="width:500px;">
      <% =Request.QueryString["Id"]; %>
    </td>
  </tr>
  <% } %>
  <tr>
    <td class="BoardWriteFormTableLeftStyle">
      <span style="color:#ff0000;">*</span>이&nbsp;름
    </td>
    <td style="width:500px;">
      <asp:TextBox ID="TxtName" runat="server" MaxLength="10" Width="150px" CssClass="form-control"></asp:TextBox>
      <asp:RequiredFieldValidator ID="ValName" runat="server" ErrorMessage="* 이름을 작성해 주세요."
        ControlToValidate="TxtName" Display="None" SetFocusOnError="true"></asp:RequiredFieldValidator>
    </td>
  </tr>
  <tr>
    <td style="text-align:right;">E-mail</td>
    <td>
      <asp:TextBox ID="TxtEmail" runat="server" MaxLength="80" Width="200px" CssClass="form-control"
        style="display:inline-block;"></asp:TextBox>
      <span style="color:#aaaaaa;font-style:italic">(Optional)</span>
      <asp:RegularExpressionValidator ID="ValEmail" runat="server" ErrorMessage="* 메일 형식이 올바르지 않습니다."
        ControlToValidate="TxtEmail" Display="None" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        SetFocusOnError="true"></asp:RegularExpressionValidator>
    </td>
  </tr>
  <tr>
    <td style="text-align:right;">Homepage</td>
    <td>
      <asp:TextBox ID="TxtHomepage" runat="server" CssClass="form-control" style="display:inline-block;"
        MaxLength="80" Width="300px"></asp:TextBox>
      <span style="color:#aaaaaa;font-style:italic;">(Optional)</span>
      <asp:RegularExpressionValidator ID="ValHomepage" runat="server" ErrorMessage="* 홈페이지를 정확히 작성해주세요."
        ControlToValidate="TxtHomepage" Display="None"
        ValidationExpression="http://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?"
        SetFocusOnError="true"></asp:RegularExpressionValidator>
    </td>
  </tr>
  <tr>
    <td style="text-align:right;">
      <span style="color:#ff0000;">*</span>제 목
    </td>
    <td>
      <asp:TextBox ID="TxtTitle" runat="server" CssClass="form-control" Width="400px"></asp:TextBox>
      <asp:RequiredFieldValidator ID="ValTitle" runat="server" ErrorMessage="* 제목을 기입해 주세요."
        ControlToValidate="TxtTitle" Display="None" SetFocusOnError="true"></asp:RequiredFieldValidator>
    </td>
  </tr>
  <tr>
    <td style="text-align:right;">
      <span style="color:#ff0000;">*</span>내 용
    </td>
    <td>
      <asp:TextBox ID="TxtContent" TextMode="MultiLine" runat="server" Height="150px" Width="480px"
        CssClass="form-control" style="display:inline-block;"></asp:TextBox>
      <asp:RequiredFieldValidator ID="ValContent" runat="server" ErrorMessage="* 내용을 기입해 주세요."
        ControlToValidate="TxtContent" Display="None" SetFocusOnError="true"></asp:RequiredFieldValidator>
    </td>
  </tr>
  <tr>
    <td style="text-align:right;">파일첨부</td>
    <td>
      <asp:CheckBox ID="ChkUpload" runat="server" CssClass="check-inline" Text="이 체크박스를 선택하면 업로드 화면이 나타납니다."
        AutoPostBack="true" OnCheckedChanged="ChkUpload_CheckedChanged" />
      <span style="color:#aaaaaa;font-style:italic">(Optional)</span>
      <br />
      <asp:Panel ID="PnlFile" runat="server" Width="480px" Visible="false" Height="25px">
        <input id="TxtFileName" style="width:290px; height:19px;" type="file" name="TxtFileName" runat="server" />
        <asp:Label ID="LblFileNamePrevious" Text="" runat="server" Visible="false"></asp:Label>
      </asp:Panel>
    </td>
  </tr>
  <tr>
    <td style="text-align:right;">
      <span style="color:#ff0000;">*</span>인코딩
    </td>
    <td>
      <asp:RadioButtonList ID="RdoEncoding" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
        <asp:ListItem Value="Text" Selected="True">Text</asp:ListItem>
        <asp:ListItem Value="HTML">HTML</asp:ListItem>
        <asp:ListItem Value="Mixed">Mixed</asp:ListItem>
      </asp:RadioButtonList>
    </td>
  </tr>
  <tr>
    <td style="text-align:right;">
      <span style="color:#ff0000;">*</span>비밀번호
    </td>
    <td>
      <asp:TextBox ID="TxtPassword" runat="server" CssClass="form-control" style="display:inline-block;"
        MaxLength="20" Width="150px" TextMode="Password" EnableViewState="false"></asp:TextBox>
      <span style="color:#aaaaaa;">(수정/삭제 시 필요)</span>
      <asp:RequiredFieldValidator ID="ValPassword" runat="server" ErrorMessage="* 비밀번호를 기입해 주세요."
        ControlToValidate="TxtPassword" Display="None" SetFocusOnError="true"></asp:RequiredFieldValidator>
    </td>
  </tr>
  <%
    if (!Page.User.Identity.IsAuthenticated)
    {
      %>
  <tr>
    <td style="text-align:right;">
      <span style="color:#ff0000;">*</span>보안코드
    </td>
    <td>
      <asp:TextBox ID="TxtImageText" runat="server" CssClass="form-control" style="display:inline-block;"
        EnableViewState="false" MaxLength="20" Width="150px"></asp:TextBox>
      <span style="color:#aaaaaa;">
        (아래에 제시되는 보안코드를 입력하십시오.)
      </span>
      <br />
      <asp:Image ID="ImgSecurityImageText" runat="server" ImageUrl="~/DotNetNote/ImageText.aspx" />
      <asp:Label ID="LblError" runat="server" ForeColor="Red"></asp:Label>
    </td>
  </tr>
  <%
    }
    %>
  <tr>
    <td colspan="2" style="text-align:center;">
      <asp:Button ID="BtnWrite" runat="server" Text="저장" CssClass="btn btn-primary" OnClick="BtnWrite_Click" />
      <a href="BoardList.aspx" class="btn btn-default">리스트</a>
      <br />
      <asp:ValidationSummary ID="ValSummary" runat="server" ShowSummary="false" ShowMessageBox="true"
        DisplayMode="List" />
      <br />
    </td>
  </tr>
</table>