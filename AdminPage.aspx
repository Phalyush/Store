<%@ Page Title="" Language="C#" MasterPageFile="~/Header.master" AutoEventWireup="true" CodeFile="AdminPage.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:DropDownList ID="SelectPhone" runat="server"></asp:DropDownList> <br />
    <asp:Label ID="modelLbl" runat="server" Text="Модель телефона"></asp:Label>
    <asp:TextBox ID="modelTxtB" runat="server"></asp:TextBox> <br />
    <asp:Label ID="cameraLbl" runat="server" Text="Камера"></asp:Label>
    <asp:TextBox ID="cameraTxtB" runat="server"></asp:TextBox> <br />
    <asp:Label ID="capacityLbl" runat="server" Text="Память"></asp:Label>
    <asp:TextBox ID="capacityTxtb" runat="server"></asp:TextBox> <br />
    <asp:Label ID="cpuLbl" runat="server" Text="Процесор"></asp:Label>
    <asp:TextBox ID="cpuTxtB" runat="server"></asp:TextBox> <br />
    <asp:Label ID="ramLbl" runat="server" Text="Оперативная память"></asp:Label>
    <asp:TextBox ID="ramTxtB" runat="server"></asp:TextBox> <br />
    <asp:Label ID="bigImageLbl" runat="server" Text="Label"></asp:Label>
    <asp:TextBox ID="bigImageTxtb" runat="server"></asp:TextBox> <br />
    <asp:Label ID="smallImageLbl" runat="server" Text="Label"></asp:Label>
    <asp:TextBox ID="smallImageTxtB" runat="server"></asp:TextBox> <br />
    <asp:Label ID="AllingtxtB" runat="server" Text="Label"></asp:Label>
    <asp:TextBox ID="Allingtxt" runat="server"></asp:TextBox> <br />
    <asp:Label ID="priceLbl" runat="server" Text="Цена"></asp:Label>
    <asp:TextBox ID="priceTxtB" runat="server"></asp:TextBox> <br />
    <asp:Label ID="MoreInformationLbl" runat="server" Text="Информация"></asp:Label>
    <asp:TextBox ID="MoreInformationTxtB" runat="server"></asp:TextBox> <br />
    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
    <br />
    <br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
</asp:Content>



