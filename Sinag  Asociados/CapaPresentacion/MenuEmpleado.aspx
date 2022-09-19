<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MenuEmpleado.aspx.cs" Inherits="CapaPresentacion.Empleados.MenuEmpleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<ul>
    <li><a href="V_EmpleadoRegistrar.aspx">Registrar</a></li>
    <li><a href="V_Empleado_Consultar.aspx">Consultar</a></li>
    <li><a href="V_EmpleadoModificar.aspx">Modificar</a></li>
    <li><a href="V_Empleado_Eliminar.aspx">Eliminar</a></li>
</ul>
</asp:Content>
