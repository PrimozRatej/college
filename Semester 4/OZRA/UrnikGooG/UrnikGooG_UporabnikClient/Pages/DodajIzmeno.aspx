<%@ Page Language="C#" Title="Dodaj izmeno" AutoEventWireup="true" MasterPageFile="~/Site.Master"  CodeBehind="DodajIzmeno.aspx.cs" Inherits="UrnikGooG_UporabnikClient.Pages.DodajIzmeno"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
   
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    <asp:Label ID="Label1" runat="server" Text="Začetek: "></asp:Label><asp:DropDownList ID="DropDownList_ZačetekUre" runat="server"></asp:DropDownList>:<asp:DropDownList ID="DropDownList_ZačetekMinute" runat="server"></asp:DropDownList><br />
    <asp:Label ID="Label2" runat="server" Text="Konec: "></asp:Label><asp:DropDownList ID="DropDownList_KonecUre" runat="server"></asp:DropDownList>:<asp:DropDownList ID="DropDownList_KonecMinute" runat="server"></asp:DropDownList>
    <br />
    <br />
     <asp:Label ID="LabelUrnik" runat="server" Text="Urnik: "></asp:Label><asp:DropDownList ID="DropDownList_Urnik" runat="server"></asp:DropDownList>
    <br />
    <br />
    <br />
   <asp:Button ID="Button_DodajIzmeno" runat="server" OnClick="Button_DodajIzmeno_Click" Text="Dodaj" />
   
    </asp:Content>
