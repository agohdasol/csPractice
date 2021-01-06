<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FrmCachingWebUserControl.ascx.cs" Inherits="Ch11.FrmCachingWebUserControl" %>
<%@ OutputCache Duration="5" VaryByParam="None" %>

현재시간 :
<asp:Label ID="LblTimeWebUserControl" runat="server" Text="Label"></asp:Label>