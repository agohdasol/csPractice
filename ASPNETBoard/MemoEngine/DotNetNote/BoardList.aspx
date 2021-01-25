<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BoardList.aspx.cs" Inherits="MemoEngine.DotNetNote.BoardList" %>

<%@ Register Src="~/DotNetNote/Controls/BoardSearchFormSingleControl.ascx"
  TagPrefix="ucl" TagName="BoardSearchFormSingleControl" %>
<%@ Register Src="~/DotNetNote/Controls/AdvancedPagingSingleWithBootstrap.ascx" 
  TagPrefix="ucl" TagName="AdvancedPagingSingleWithBootstrap" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <h2 style="text-align:center;">게시판</h2>
  <span style="color:#ff0000">글 목록 - 완성형 게시판입니다.</span>
  <hr />
  <table style="width:700px; margin-left:auto; margin-right:auto;">
    <tr>
      <td>
        <style>
          table th{
            text-align:center;
          }
        </style>
        <div style="font-style:italic; text-align:right; font-size:8pt;">
          Total Record:
          <asp:Literal ID="LblTotalRecord" runat="server"></asp:Literal>
        </div>
        <asp:GridView ID="CtlBoardList" runat="server" AutoGenerateColumns="false" DataKeyNames="Id"
          CssClass="table table-bordered table-hover table-condensed table-striped table-responsive">
          <Columns>
            <asp:TemplateField HeaderText="번호" HeaderStyle-Width="50px" ItemStyle-HorizontalAlign="Center">
              <ItemTemplate>
                <%--<%# Eval("Id") %>--%>
                <%# RecordCount - ((Container.DataItemIndex)) - (PageIndex * 10) %>
              </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="제목" ItemStyle-HorizontalAlign="Left" HeaderStyle-Width="350px">
              <ItemTemplate>
                <%# Dul.BoardLibrary.FuncStep(Eval("Step")) %>
                <asp:HyperLink ID="LnkTitle" runat="server" NavigateUrl=
                  '<%# "BoardView.aspx?Id=" + Eval("Id") %>'>
                  <%# Dul.StringLibrary.CutStringUnicode(Eval("Title").ToString(),30) %>
                </asp:HyperLink>
                <%# Dul.BoardLibrary.ShowCommentCount(Eval("CommentCount")) %>
                <%# Dul.BoardLibrary.FuncNew(Eval("PostPate")) %>
              </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="파일" HeaderStyle-Width="70px"
              ItemStyle-HorizontalAlign="Center">
              <ItemTemplate>
                <%# Dul.BoardLibrary.FuncFileDownSingle(Convert.ToInt32(Eval("Id")),
                  Eval("FileName").ToString(), Eval("FileSize").ToString()) %>
              </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Name" HeaderText="작성자" HeaderStyle-Width="60px" ItemStyle-HorizontalAlign="Center" />
            <asp:TemplateField HeaderText="작성일" ItemStyle-Width="90px" ItemStyle-HorizontalAlign="Center">
              <ItemTemplate>
                <%# Dul.BoardLibrary.FuncShowTime(Eval("PostDate")) %>
              </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="ReadCount" HeaderText="조회수" ItemStyle-HorizontalAlign="Right"
              HeaderStyle-Width="60px" />
          </Columns>
        </asp:GridView>
      </td>
    </tr>
    <tr>
      <td style="text-align:center;">
        <ucl:AdvancedPagingSingleWithBootstrap runat="server" ID="AdvancedPagingSingleWithBootstrap" />
      </td>
    </tr>
    <tr>
      <td style="text-align:right;">
        <a href="BoardWrite.aspx" class="btn btn-primary">글쓰기</a>
      </td>
    </tr>
  </table>

  <ucl:BoardSearchFormSingleControl runat="server" ID="BoardSearchFormSingleControl" />
</asp:Content>
