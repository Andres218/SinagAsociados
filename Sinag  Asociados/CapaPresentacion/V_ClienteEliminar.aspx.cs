using LogicaCapa;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class V_ClienteEliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LABEL_TABLA_CONSULTA_CLIENTE.Visible = false;
        }

        protected void ELIMINAR_CLIENTE_Click(object sender, EventArgs e)
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
                    bool respuestaSQL = cliente.Procedimiento_Eliminar_Cliente(INFORMACION_BUSCADA.Text);
                    if (respuestaSQL == true)
                    {
                        LABEL_TABLA_CONSULTA_CLIENTE.Visible = true;
                        LABEL_TABLA_CONSULTA_CLIENTE.Text = "Los datos de este cliente fueron eliminados";
                    }
                    else
                    {
                        LABEL_TABLA_CONSULTA_CLIENTE.Visible = true;
                        LABEL_TABLA_CONSULTA_CLIENTE.Text = cliente.TEXTO;
                    }
                }
            }
            catch (Exception ex)
            {
                LABEL_TABLA_CONSULTA_CLIENTE.Visible = true;
                LABEL_TABLA_CONSULTA_CLIENTE.Text = "no se ha podido efectuar la consulta debido al siguiente ERROR: " + ex.Message;
            }
        }
    }
}