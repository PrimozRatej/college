<%@ Page Language="C#" Title="Moje izmene" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Izmene.aspx.cs" Inherits="UrnikGooG_UporabnikClient.Pages.Izmene"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h3>Izmene</h3>
    <asp:GridView ID="GridView_izmena" runat="server" Visible="true"></asp:GridView>
   
    <br />
    <asp:HyperLink ID="HyperLink_DodajIzmeno" runat="server" NavigateUrl="~/Pages/DodajIzmeno.aspx">Dodaj Izmeno</asp:HyperLink>
   
    </asp:Content>
