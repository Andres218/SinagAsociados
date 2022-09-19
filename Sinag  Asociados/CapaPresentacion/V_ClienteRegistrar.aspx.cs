using LogicaCapa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion.Clientes
{
    public partial class V_ClienteRegistrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            COMENTARIO_REGISTRAR.Visible = false;
        }

        protected void Registrar_Cliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            try
            {
                cliente.Id_Cliente = Id_C.Text;
                cliente.Nombre = nombre.Text;
                cliente.Identificacion = NumeroID.Text;
                cliente.Correo = email.Text;
                cliente.Direccion = Direccion.Text;
                cliente.Telefono = telefono.Text;
                if (Estado.SelectedValue == "Activo")
                {
                    cliente.EstadoCliente = "Activo";
                }
                else if (Estado.SelectedValue == "Inactivo")
                {
                    cliente.EstadoCliente = "Inactivo";
                }
                if (genero.SelectedValue == "Masculino")
                {
                    cliente.Genero = "Masculino";
                }
                else if (genero.SelectedValue == "Femenino")
                {
                    cliente.Genero = "Femenino";
                }

                bool respuestaSQL = cliente.Procedimineto_Registrar_Cliente();

                if (respuestaSQL == true)
                {
                    COMENTARIO_REGISTRAR.Visible = true;
                    COMENTARIO_REGISTRAR.Text = "Cliente Registrado";
                    Id_C.Text = ""; nombre.Text = ""; genero.SelectedValue = ""; NumeroID.Text = "";
                    email.Text = ""; Direccion.Text = ""; telefono.Text = ""; Estado.SelectedValue = "";
                }
                else
                {
                    COMENTARIO_REGISTRAR.Visible = true;
                    COMENTARIO_REGISTRAR.Text = cliente.TEXTO;
                }
            }
            catch(Exception EX)
            {
                COMENTARIO_REGISTRAR.Visible = true;
                COMENTARIO_REGISTRAR.Text = "ERROR!" + EX.Message + " " + cliente.TEXTO;
            }
        }
    }
}