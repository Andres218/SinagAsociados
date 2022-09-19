<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="V_CronogramaRegistrar.aspx.cs" Inherits="CapaPresentacion.Cronogramas.V_CronogramaRegistrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container">
    <label for="Id_F">Identificacion facturacion:</label>
   
       <asp:TextBox ID="Id_F" CssClass="form-control" runat="server"></asp:TextBox>
  </div>
      <div class="container">
    <label for="Id_S">Identificacion servicio:</label>
   
       <asp:TextBox ID="Id_S" CssClass="form-control" runat="server"></asp:TextBox>
  </div>
    <div class="container">
    <label for="Id_E">Identificacion empleado:</label>
   
       <asp:TextBox ID="Id_E" CssClass="form-control" runat="server"></asp:TextBox>
  </div>
    <div class="container">
    <label for="Id_C">Identificacion cliente:</label>
   
       <asp:TextBox ID="Id_C" CssClass="form-control" runat="server"></asp:TextBox>
  </div>
  
    
  <div class="container">
    <label for="NumeroDeFacturacion">Numero de facturacion:</label>
    
      <asp:TextBox ID="NumeroDeFacturacion" CssClass="form-control" runat="server"></asp:TextBox>
  </div>
    <div class="container">
    <label for="NombreDeFacturacion">Nombre de facturacion:</label>
    
      <asp:TextBox ID="NombreDeFacturacion" CssClass="form-control" runat="server"></asp:TextBox>
  </div>
        <div class="container">
 <label for="FechaEntrega">Fecha de entrega:</label>
            <asp:Calendar ID="FechaEntrega" runat="server"></asp:Calendar>
            </div>

    <div class="container">
        <label for="Cantidad_articulos_despachados">Cantidad de articulos despachados:</label>
        <br />
        <asp:TextBox ID="C_A_D" runat="server"></asp:TextBox>
        </div>
    
    <div class="container">
        <label for="UltimaM">Ultima modificacion:</label>

        <asp:Calendar ID="UltimaM" runat="server"></asp:Calendar>
        </div>
    <div class="container">
        <label for="ValorT">Valor total:</label>
        <br />
        <asp:TextBox ID="Valor_T" runat="server"></asp:TextBox>
        </div>
    <div class="container">
        <label for="FechaSolicitud">Fecha de solicitud:</label>

        <asp:Calendar ID="FechaSolicitud" runat="server"></asp:Calendar>
        </div>
    <div class="container">
        <label for="MetodoPago">Metodo de pago:</label>
        <br />
        <asp:RadioButton ID="T_C" runat="server" Text="TARJETA DE CREDITO" />
&nbsp;<asp:RadioButton ID="EF" runat="server" Text="EFECTIVO" />
        </div>
    <div class="container">
    <label for="EstadoF">Estado de factura:</label>
    
       <asp:CheckBox ID="Activo" runat="server" Text="Activo" />
      <asp:CheckBox ID="Inactivo" runat="server" Text="Inactivo" />
  </div>
</asp:Content>
