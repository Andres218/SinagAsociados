<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="V_EmpleadoRegistrar.aspx.cs" Inherits="CapaPresentacion.Empleados.V_EmpleadoRegistrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <div class="form-horizontal">
                    <asp:Label ID="TITULO" runat="server" CssClass="text-center h3" Text="Registro del Empleado"></asp:Label>
                    <div class="form-group">
                        <asp:Label ID="Label_ID_E" runat="server" Text="Identificacion del Empleado"></asp:Label>
                        <asp:TextBox ID="Id_E" CssClass="form-control" runat="server" TextMode="Number"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label_NOMBRE" runat="server" Text="Nombre del Empleado"></asp:Label>
                        <asp:TextBox ID="nombre" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label_DIRECCION" runat="server" Text="Direccion del Empleado"></asp:Label>
                        <asp:TextBox ID="Direccion" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label_EMAIL" runat="server" Text="Correo Electronico del Empleado"></asp:Label>
                        <asp:TextBox ID="email" CssClass="form-control" TextMode="Email" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label_TELEFONO" runat="server" Text="Telefono del Empleado"></asp:Label>
                        <asp:TextBox ID="telefono" CssClass="form-control" TextMode="Phone" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label_GENERO" runat="server" Text="Genero del Empleado"></asp:Label>
                        <asp:RadioButtonList ID="genero" runat="server">
                            <asp:ListItem>Masculino</asp:ListItem>
                            <asp:ListItem>Femenino</asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label_ESTADO" runat="server" Text="Estado del Empleado"></asp:Label>
                        <asp:RadioButtonList ID="Estado" runat="server">
                            <asp:ListItem>Activo</asp:ListItem>
                            <asp:ListItem>Inactivo</asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label_USUARIO" runat="server" Text="Usuario del Empleado"></asp:Label>
                        <asp:TextBox ID="Usuario" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label_CONTRASEÑA" runat="server" Text="Contraseña del Empleado"></asp:Label>
                        <asp:TextBox ID="Contraseña" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Label_ROL_E" runat="server" Text="Rol del Empleado"></asp:Label>
                        <asp:RadioButtonList ID="Rol_E" runat="server">
                            <asp:ListItem>Administrador</asp:ListItem>
                            <asp:ListItem>Empleado</asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <div class="form-group">
                        <asp:Button ID="Registrar_Empleado" CssClass="btn btn-primary" runat="server" Text="Registrar" OnClick="Registrar_Empleado_Click" /><br />
                        <asp:Label ID="COMENTARIO_REGISTRAR" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>