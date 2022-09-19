<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="V_MaquinariaRegistrar.aspx.cs" Inherits="CapaPresentacion.Articulos.V_ArticuloRegistrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container">
    <label for="nombre">Nombre Maquina:</label>
   
       <asp:TextBox ID="NombreA" CssClass="form-control" runat="server"></asp:TextBox>
  </div>
 

 
    <div class="container">
    <label for="NumeroArticulo">Numero de Maquina:</label>
    
        <asp:TextBox ID="NumeroArticulo" CssClass="form-control" runat="server"></asp:TextBox>
  </div>
  <div class="container">
    <label for="Cantidad">Cantidad Maquinas:</label>
    
      <asp:TextBox ID="CantidadA" CssClass="form-control" runat="server"></asp:TextBox>
  </div>
    <div class="container">
    <label for="Precio">Precio por unidad:</label>
   
        <asp:TextBox ID="precio" CssClass="form-control" runat="server"></asp:TextBox>
  </div>
  <div class="container">
    
    <label for="PrecioT">Precio total:</label>
      <asp:TextBox ID="PrecioT" CssClass="form-control" runat="server"></asp:TextBox>
  </div>

    <div class="container">
       <label for="Metodo">Metodo De Pago:</label>
        <asp:CheckBox ID="Master" runat="server" Text="MasterCard" />
        <asp:CheckBox ID="Visa" runat="server" Text="Visa" />
        </div>

    <div class="container">
        <label for="Calendario"> Fecha Ultima Modificacion:</label>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        </div>
     <div class="container">
    <label for="pwd">Estado:</label>
   
      <asp:CheckBox ID="CheckBox1" runat="server" Text="Activo" />
      <asp:CheckBox ID="CheckBox2" runat="server" Text="Inactivo" />

  </div>
</asp:Content>
