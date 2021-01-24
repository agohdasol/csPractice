<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BoardWrite.aspx.cs"
  Inherits="MemoEngine.DotNetNote.BoardWrite" ValidateRequest="false" %>

<%@ Register Src="~/DotNetNote/Controls/BoardEditorFormControl.ascx" TagPrefix="ucl" TagName="BoardEditerFormControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <ucl:BoardEditorFormControl runat="server" id="CtlBoardEditorFormControl"></ucl:BoardEditorFormControl>
</asp:Content>
