<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="V_Empleado_Eliminar.aspx.cs" Inherits="CapaPresentacion.V_Empleado_Eliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <fieldset>
            <legend class="text-center header" style="width:300px; padding-top:10px; color:#5DADE2; ">Elimnacion de Empleado</legend>
            <div class="form-inline">
                <asp:TextBox ID="INFORMACION_BUSCADA" CssClass="form-control mr-sm-2 " runat="server" placeholder="ingrese la identificacion del empleado" Width="500px" ></asp:TextBox>
                <asp:Button ID="ELIMINAR_EMPLEADO" runat="server" CssClass="btn btn-outline-success my-2 my-sm-0" Text="Eliminar" OnClick="ELIMINAR_EMPLEADO_Click" />
            </div>
        </fieldset>
        <br /><div class="form-inline">
            <asp:Label ID="LABEL_TABLA_CONSULTA_EMPLEADO" runat="server" CssClass="mr-sm-2" Text="Label"></asp:Label></div>
    </div>
</asp:Content>
