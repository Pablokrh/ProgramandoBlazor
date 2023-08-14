<%@ Page Title="Ejercicio N°4" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TP4KrojzlPablo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   
   <div>
       <div>
           <h1>Ejercicio número 4 de Programación .NET Web</h1>
           <br />
       </div>
       <div>    
           <h3>Realice a continuación una suma</h3>
           <br />
       </div>
       <div>
           <asp:TextBox runat="server" ID="txt1" Width="60px"></asp:TextBox>
           <span>+</span>
           <asp:TextBox runat="server" ID="txt2" Width="60px"></asp:TextBox>
           <span>=</span>
           <asp:TextBox runat="server" ID="txtSuma" Width="100px"></asp:TextBox>
           </div>
       <div>
           <br />
           <asp:Button runat="server" ID="btnSuma" Text="Realizar suma" OnClick="btnSuma_Click" />
           <br />
           <br />   
           <br />
           <br />  
           <br />
           <br />
       </div>
       <div>
           <asp:UpdatePanel runat="server" ID="updatePanel1">
               <ContentTemplate>
                   <asp:Label runat="server" ID="lblHora">Oprima el botón para obtener la hora actual</asp:Label>
                   <br />
                   <br />
                   <asp:Button runat="server" ID="btnActualizaHora" OnClick="btnActualizaHora_Click"  Text="Actualizar hora"/>
                </ContentTemplate>                        
              
            </asp:UpdatePanel>

       </div>
       


   </div>


</asp:Content>
