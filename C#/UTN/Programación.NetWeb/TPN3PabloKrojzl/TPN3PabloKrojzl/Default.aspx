<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPN3PabloKrojzl._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  
   
    <div class="container">
        <div class="nombre" style="height: 51px; margin-bottom: 0px">
             &nbsp;<asp:Label Text="Ingrese su nombre" runat="server" />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <br />
    <asp:TextBox runat="server" ID="txtnombre"/>
             <br />
             <br />
        </div>

        <div class="seleccionar" style="height: 55px">
             <asp:Label Text="Seleccione su producto" runat="server" />
             <br />
    <asp:DropDownList runat="server" ID="ddlProductos">
        <asp:ListItem Text="Silla" />
        <asp:ListItem Text="Mesa" />
        <asp:ListItem Text="Mesa de luz" />
        <asp:ListItem Text="Sommier" />
        <asp:ListItem Text="Lámpara" />
    </asp:DropDownList>
             <br />
             <br />
        </div>

        <div class="carrito" style="height: 191px">
             <asp:Label Text="Carrito de compras" runat="server" />
             <br />
    <asp:ListBox runat="server" ID="lbProductosSeleccionados" Height="102px" Width="151px">
    </asp:ListBox>
             <br />
             <br />
    <asp:Button Text="Agregar al carrito" runat="server" ID="btnAgregar" OnClick="btnAgregar_Click" Width="143px" />
             <br />
             <br />
             <br />
            </div>
   
        <asp:Button Text="Comprar" runat="server" Id="btnComprar" OnClick="btnComprar_Click"/>
        <br />
        <br />
        <asp:Label ID="lblCompraRealizada" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
    </div>
    

</asp:Content>
