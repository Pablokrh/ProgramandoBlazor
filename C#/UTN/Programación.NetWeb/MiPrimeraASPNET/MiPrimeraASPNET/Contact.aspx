<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="MiPrimeraASPNET.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>

    <div class="container-pablo">
        <asp:Label Text="Texto del gran pablo" runat="server" />
        <br />
        <label> Pablo funca?</label>
        <br />
        <table>
            <tr>
                <tn>Colores</tn>
                <td>azul</td>
                <td>rojo</td>
                <td>amarillo</td>
            </tr>
            <tr>
                <tn>Días</tn>
                <td>lunes</td>
                <td>miercoles</td>
                <td>viernes</td>
            </tr>
            
        </table>
        <br />
            <asp:DropDownList runat="server">
                <asp:ListItem Text="Corneta" />
                <asp:ListItem Text="Elpro-fe" />
            </asp:DropDownList>
        <asp:Button Text="Asesinar" runat="server"  ID="btnAsesinar" OnClick="btnAsesinar_Click"  />
        <asp:Label Text="Si asesinás aparecerá aquí el precio" ID="lblPrecio" runat="server" />
    
    </div>
</asp:Content>
