
<%@ Page Language="C#" Title="Moje bolniške" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Bolniške.aspx.cs" Inherits="UrnikGooG_UporabnikClient.Pages.Bolniške"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h3>Bolniške</h3>
    <asp:GridView ID="GridView_bolniske" runat="server" Visible="true"></asp:GridView>
   
    </asp:Content>