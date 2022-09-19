<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="V_ClienteEliminar.aspx.cs" Inherits="CapaPresentacion.V_ClienteEliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <fieldset>
            <legend class="text-center header" style="width:300px; padding-top:10px; color:#5DADE2; ">Eliminacion de Cliente</legend>
            <div class="form-inline">
                <asp:TextBox ID="INFORMACION_BUSCADA" CssClass="form-control mr-sm-2 " runat="server" placeholder="ingrese la identificacion del cliente" Width="500px" ></asp:TextBox>
                <asp:Button ID="ELIMINAR_CLIENTE" runat="server" CssClass="btn btn-outline-success my-2 my-sm-0" Text="Buscar" OnClick="ELIMINAR_CLIENTE_Click"    />
            </div>
        </fieldset>
        <br /><div class="form-inline">
            <asp:Label ID="LABEL_TABLA_CONSULTA_CLIENTE" runat="server" CssClass="mr-sm-2" Text="Label"></asp:Label></div>
    </div>
</asp:Content>
