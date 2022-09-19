<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="V_Empleado_Consultar.aspx.cs" Inherits="CapaPresentacion.V_Empleado_Consultar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <fieldset>
            <legend class="text-center header" style="width:300px; padding-top:10px; color:#5DADE2; ">Busqueda de Empleado</legend>
            <div class="form-inline">
                <div class="form-group"><asp:DropDownList ID="SELECCION_OPCION_VALIDA_EMPLEADO" CssClass="form-control mr-sm-2" runat="server">
                    <asp:ListItem>Seleccione una opcion</asp:ListItem>
                    <asp:ListItem>Codigo del Empleado</asp:ListItem>
                    <asp:ListItem>Ver Todas</asp:ListItem>
                    </asp:DropDownList></div>
                <asp:TextBox ID="INFORMACION_BUSCADA" CssClass="form-control mr-sm-2 " runat="server" placeholder="ingrese la identificacion del empleado" Width="500px" ></asp:TextBox>
                <asp:Button ID="CONSULTAR_EMPLEADO" runat="server" CssClass="btn btn-outline-success my-2 my-sm-0" Text="Buscar" OnClick="CONSULTAR_EMPLEADO_Click"    />
            </div>
        </fieldset>
        <br /><div class="form-inline"><asp:Label ID="LABEL_SELECCION_OPCION_VALIDA_EMPLEADO" runat="server" CssClass="mr-sm-2" Text="Label"></asp:Label>
            <asp:Label ID="LABEL_TABLA_CONSULTA_EMPLEADO" runat="server" CssClass="mr-sm-2" Text="Label"></asp:Label></div>
    </div>
        <div class="container">
             <asp:GridView ID="TABLA_CONSULTA_EMPLEADO" runat="server" CssClass="table table-responsive" CellPadding="3" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" >
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        </div>
</asp:Content>
