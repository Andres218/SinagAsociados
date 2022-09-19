<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="V_ClienteModificar.aspx.cs" Inherits="CapaPresentacion.Clientes.V_ClienteModificar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <fieldset>
            <legend class="text-center header" style="width:300px; padding-top:10px; color:#5DADE2; ">Busqueda de Cliente</legend>
            <div class="form-inline">
                <asp:TextBox ID="INFORMACION_BUSCADA" CssClass="form-control mr-sm-2 " runat="server" placeholder="ingrese la identificacion del cliente" Width="500px" ></asp:TextBox>
                <asp:Button ID="CONSULTAR_CLIENTE" runat="server" CssClass="btn btn-outline-success my-2 my-sm-0" Text="Buscar" OnClick="CONSULTAR_CLIENTE_Click"   />
            </div>
        </fieldset>
        <br /><div class="form-inline">
            <asp:Label ID="LABEL_TABLA_CONSULTA_CLIENTE" runat="server" CssClass="mr-sm-2" Text="Label"></asp:Label></div>
    </div>
    <asp:Panel ID="Formulario_Actualizar_Cliente" CssClass="container" runat="server">
        <div class="row">
            <div class="col-md-12">
                <div class="form-horizontal">
                    <asp:Label ID="TITULO" runat="server" CssClass="text-center h3" Text="Actualizacion del Cliente"></asp:Label>
                    <div class="form-group">
                        <asp:Label ID="Label_NOMBRE" runat="server" Text="Nombre del Cliente"></asp:Label>
                        <asp:TextBox ID="nombre" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label_NUMEROID" runat="server" Text="Numero de Identificacion del Cliente"></asp:Label>
                        <asp:TextBox ID="NumeroID" CssClass="form-control" TextMode="Number" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label_DIRECCION" runat="server" Text="Direccion del Cliente"></asp:Label>
                        <asp:TextBox ID="Direccion" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label_EMAIL" runat="server" Text="Correo Electronico del Cliente"></asp:Label>
                        <asp:TextBox ID="email" CssClass="form-control" TextMode="Email" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label_TELEFONO" runat="server" Text="Telefono del Cliente"></asp:Label>
                        <asp:TextBox ID="telefono" CssClass="form-control" TextMode="Phone" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label_GENERO" runat="server" Text="Genero del Cliente"></asp:Label>
                        <asp:RadioButtonList ID="genero" runat="server">
                            <asp:ListItem>Masculino</asp:ListItem>
                            <asp:ListItem>Femenino</asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label_ESTADO" runat="server" Text="Estado del Cliente"></asp:Label>
                        <asp:RadioButtonList ID="Estado" runat="server">
                            <asp:ListItem>Activo</asp:ListItem>
                            <asp:ListItem>Inactivo</asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <div class="form-group">
                        <asp:Button ID="Actualizar_Cliente" CssClass="btn btn-primary" runat="server" Text="Actualizar" OnClick="Actualizar_Cliente_Click" /><br />
                        <asp:Label ID="COMENTARIO_ACTUALIZAR" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </asp:Panel>
</asp:Content>
