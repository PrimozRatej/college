<%@ Page Language="C#" Title="Moje prosti dnevi" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ProstiDan.aspx.cs"Inherits="UrnikGooG_UporabnikClient.Pages.ProstiDan"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h3>Prosti dnevi</h3>
    <asp:GridView ID="GridView_ProstiDan" runat="server" Visible="true"></asp:GridView>
   
    </asp:Content>
