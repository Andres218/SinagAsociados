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
    public partial class V_Empleado_Consultar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LABEL_SELECCION_OPCION_VALIDA_EMPLEADO.Visible = false;
            LABEL_TABLA_CONSULTA_EMPLEADO.Visible = false;
        }

        protected void CONSULTAR_EMPLEADO_Click(object sender, EventArgs e)
        {
            bool OpcionValida = true;
            Empleado empleado = new Empleado();
            DataSet DatosCliente = new DataSet();

            try
            {
                if (SELECCION_OPCION_VALIDA_EMPLEADO.SelectedValue == "Codigo del Empleado")
                {
                    DatosCliente = empleado.Procedimiento_Consultar_Empleado(INFORMACION_BUSCADA.Text, "Codigo del Empleado");
                }
                else if (SELECCION_OPCION_VALIDA_EMPLEADO.SelectedValue == "Ver Todas")
                {
                    DatosCliente = empleado.Procedimiento_Consultar_Empleado("", "Ver Todas");
                }
                else
                {
                    OpcionValida = false;
                    LABEL_SELECCION_OPCION_VALIDA_EMPLEADO.Visible = true;
                    LABEL_SELECCION_OPCION_VALIDA_EMPLEADO.Text = "Seleccione una opcion";
                }

                if (OpcionValida == true)
                {
                    DataTable DatosConsultados =
                        DatosCliente.Tables["DatosConsultados"];

                    int numregistros = DatosConsultados.Rows.Count;

                    if (numregistros == 0)
                    {
                        LABEL_TABLA_CONSULTA_EMPLEADO.Visible = true;
                        LABEL_TABLA_CONSULTA_EMPLEADO.Text = "No existe en la base de datos cliente con el valor buscado";
                    }
                    else
                    {
                        TABLA_CONSULTA_EMPLEADO.DataSource = DatosConsultados;
                        TABLA_CONSULTA_EMPLEADO.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                LABEL_TABLA_CONSULTA_EMPLEADO.Visible = true;
                LABEL_TABLA_CONSULTA_EMPLEADO.Text = "no se ha podido efectuar la consulta debido al siguiente ERROR: " + ex.Message;
            }
        }
    }
}