<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="V_ServicioRegistrar.aspx.cs" Inherits="CapaPresentacion.V_ServicioRegistrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          <div class="container">
    <label for="Id_S">Codigo Servicio:</label>
    
        <asp:TextBox ID="Id_S" CssClass="form-control" runat="server"></asp:TextBox>
  </div>
     <div class="container">
    <label for="nombre_p">Nombre del pedido:</label>
    
        <asp:TextBox ID="nombre_p" CssClass="form-control" runat="server"></asp:TextBox>
  </div>
 
    <div class="container">
    <label for="numero_p">Numero del pedido:</label>
    
        <asp:TextBox ID="numero_p" CssClass="form-control" runat="server"></asp:TextBox>
  </div>
       
      <div class="container">
    
            <label for="fecha_de_solicitud">Fecha de solicitud:</label>
          <asp:Calendar ID="calendar2" runat="server"></asp:Calendar>
  </div>
    
  <div class="container">
      <div class="container">
    
            <label for="fecha_de_despacho">Fecha de despacho:</label>
          <asp:Calendar ID="calendario_1" runat="server"></asp:Calendar>
  </div>
    

  </div>
     <div class="container">
    <label for="pwd">Estado del pedido:</label>
   
      <asp:CheckBox ID="CheckBox1" runat="server" Text="Activo" />
      <asp:CheckBox ID="CheckBox2" runat="server" Text="Inactivo" />

  </div>
    </form>
</body>
</html>
