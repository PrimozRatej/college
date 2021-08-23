<%@ Page Language="C#" Title="Moj kolendar" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Kolendar.aspx.cs" Inherits="UrnikGooG_UporabnikClient.Pages.Kolendar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your callendar.</h3>
    <asp:GridView ID="GridView_urniki" runat="server" Visible="true"></asp:GridView>
   
    </asp:Content>
