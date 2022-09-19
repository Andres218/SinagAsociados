<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="V_CronogramaRegistrar.aspx.cs" Inherits="CapaPresentacion.Cronogramas.V_CronogramaRegistrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


      <div class="container">
    <label for="nombreC">Nombre Cliente:</label>
   
       <asp:TextBox ID="NombreC" CssClass="form-control" runat="server"></asp:TextBox>
  </div>
  
    <div class="container">
    <label for="NombreP">Nombre de pedido:</label>
    
        <asp:TextBox ID="NombreP" CssClass="form-control" runat="server"></asp:TextBox>
  </div>
  <div class="container">
    <label for="NumeroP">Numero de pedido:</label>
    
      <asp:TextBox ID="NumeroP" CssClass="form-control" runat="server"></asp:TextBox>
  </div>
        <div class="container">
 <label for="FechaDespacho">Fecha de despacho:</label>
            <asp:Calendar ID="CalendarioD" runat="server"></asp:Calendar>
            </div>

    <div class="container">
        <label for="FechaSolicitud">Fecha de solicitud:</label>

        <asp:Calendar ID="CalendarS" runat="server"></asp:Calendar>
        </div>
</asp:Content>
