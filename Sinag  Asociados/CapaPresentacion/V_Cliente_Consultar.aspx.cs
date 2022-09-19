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
    public partial class V_Cliente_Consultar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LABEL_SELECCION_OPCION_VALIDA_CLIENTE.Visible = false;
            LABEL_TABLA_CONSULTA_CLIENTE.Visible = false;
        }

        protected void CONSULTAR_CLIENTE_Click(object sender, EventArgs e)
        {
            bool OpcionValida = true;
            Cliente cliente = new Cliente();
            DataSet DatosCliente = new DataSet();

            try
            {
                if (SELECCION_OPCION_VALIDA_CLIENTE.SelectedValue == "Codigo del Cliente")
                {
                    DatosCliente = cliente.Procedimiento_Consultar_Cliente(INFORMACION_BUSCADA.Text, "Codigo del Cliente");
                }
                else if (SELECCION_OPCION_VALIDA_CLIENTE.SelectedValue == "Ver Todas")
                {
                    DatosCliente = cliente.Procedimiento_Consultar_Cliente("", "Ver Todas");
                }
                else
                {
                    OpcionValida = false;
                    LABEL_SELECCION_OPCION_VALIDA_CLIENTE.Visible = true;
                    LABEL_SELECCION_OPCION_VALIDA_CLIENTE.Text = "Seleccione una opcion";
                }

                if (OpcionValida == true)
                {
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
                        TABLA_CONSULTA_CLIENTE.DataSource = DatosConsultados;
                        TABLA_CONSULTA_CLIENTE.DataBind();
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