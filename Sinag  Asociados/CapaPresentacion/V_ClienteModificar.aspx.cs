using LogicaCapa;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion.Clientes
{
    public partial class V_ClienteModificar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                Formulario_Actualizar_Cliente.Visible = false;
            }
            COMENTARIO_ACTUALIZAR.Visible = false;
            LABEL_TABLA_CONSULTA_CLIENTE.Visible = false;
        }

        protected void CONSULTAR_CLIENTE_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            DataSet DatosCliente = new DataSet();

            try
            {
                DatosCliente = cliente.Procedimiento_Consultar_Cliente(INFORMACION_BUSCADA.Text, "Codigo del Cliente");

                DataTable DatosConsultados =
                        DatosCliente.Tables["DatosConsultados"];

                int numregistros = DatosConsultados.Rows.Count;

                if (numregistros == 0)
                {
                    LABEL_TABLA_CONSULTA_CLIENTE.Visible = true;
                    LABEL_TABLA_CONSULTA_CLIENTE.Text = "No existe en la base de datos cliente con el valor buscado";
                }
                else
                {
                    Formulario_Actualizar_Cliente.Visible = true;
                    nombre.Text = DatosConsultados.Rows[0]["NombreCliente"].ToString();
                    genero.SelectedValue = DatosConsultados.Rows[0]["GeneroCliente"].ToString();
                    NumeroID.Text = DatosConsultados.Rows[0]["NumeroDeidentificacion_Cliente"].ToString();
                    email.Text = DatosConsultados.Rows[0]["Correo_Cliente"].ToString();
                    Direccion.Text = DatosConsultados.Rows[0]["DireccionCliente"].ToString();
                    telefono.Text = DatosConsultados.Rows[0]["TelefonoCliente"].ToString();
                    Estado.SelectedValue = DatosConsultados.Rows[0]["EstadoCliente"].ToString();
                }
            }
            catch (Exception ex)
            {
                LABEL_TABLA_CONSULTA_CLIENTE.Visible = true;
                LABEL_TABLA_CONSULTA_CLIENTE.Text = "no se ha podido efectuar la consulta debido al siguiente ERROR: " + ex.Message;
            }
        }

        protected void Actualizar_Cliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            try
            {
                cliente.Id_Cliente = INFORMACION_BUSCADA.Text;
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

                bool respuestaSQL = cliente.Procedimiento_Actualizar_Cliente();

                if (respuestaSQL == true)
                {
                    COMENTARIO_ACTUALIZAR.Visible = true;
                    COMENTARIO_ACTUALIZAR.Text = "Datos Actualizados";
                    nombre.Text = ""; genero.SelectedValue = ""; NumeroID.Text = "";
                    email.Text = ""; Direccion.Text = ""; telefono.Text = ""; Estado.SelectedValue = "";
                }
                else
                {
                    COMENTARIO_ACTUALIZAR.Visible = true;
                    COMENTARIO_ACTUALIZAR.Text = cliente.TEXTO;
                }
            }
            catch (Exception EX)
            {
                COMENTARIO_ACTUALIZAR.Visible = true;
                COMENTARIO_ACTUALIZAR.Text = "ERROR!" + EX.Message + " " + cliente.TEXTO;
            }
        }
    }
}