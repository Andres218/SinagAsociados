<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="V_ClienteRegistrar.aspx.cs" Inherits="CapaPresentacion.Clientes.V_ClienteRegistrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <div class="form-horizontal">
                    <asp:Label ID="TITULO" runat="server" CssClass="text-center h3" Text="Registro del Cliente"></asp:Label>
                    <div class="form-group">
                        <asp:Label ID="Label_ID_C" runat="server" Text="Identificacion del Cliente"></asp:Label>
                        <asp:TextBox ID="Id_C" CssClass="form-control" runat="server" TextMode="Number"></asp:TextBox>
                    </div>
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
                        <asp:Button ID="Registrar_Cliente" CssClass="btn btn-primary" runat="server" Text="Registrar" OnClick="Registrar_Cliente_Click" /><br />
                        <asp:Label ID="COMENTARIO_REGISTRAR" runat="server" Text="Label"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

