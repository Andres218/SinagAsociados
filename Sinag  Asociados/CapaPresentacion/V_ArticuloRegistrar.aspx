<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="V_ArticuloRegistrar.aspx.cs" Inherits="CapaPresentacion.Articulos.V_ArticuloRegistrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container">
    <label for="nombre">Nombre Articulo:</label>
   
       <asp:TextBox ID="NombreA" CssClass="form-control" runat="server"></asp:TextBox>
  </div>
 

 
    <div class="container">
    <label for="NumeroArticulo">Numero de Articulo:</label>
    
        <asp:TextBox ID="NumeroArticulo" CssClass="form-control" runat="server"></asp:TextBox>
  </div>
  <div class="container">
    <label for="Cantidad">Cantidad Articulos:</label>
    
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
</asp:Content>
