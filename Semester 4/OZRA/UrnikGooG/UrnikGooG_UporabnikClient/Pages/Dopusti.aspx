<%@ Page Language="C#" Title="Moji dopusti" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Dopusti.aspx.cs" Inherits="UrnikGooG_UporabnikClient.Pages.Dopusti"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h3>Dopusti</h3>
    <asp:GridView ID="GridView_dopusti" runat="server" Visible="true"></asp:GridView>
   
    </asp:Content>
