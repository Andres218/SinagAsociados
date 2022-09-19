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
    public partial class V_Empleado_Eliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LABEL_TABLA_CONSULTA_EMPLEADO.Visible = false;
        }

        protected void ELIMINAR_EMPLEADO_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            DataSet Datosempleado = new DataSet();
            try
            {
                Datosempleado = empleado.Procedimiento_Consultar_Empleado(INFORMACION_BUSCADA.Text, "Codigo del Empleado");

                DataTable DatosConsultados =
                        Datosempleado.Tables["DatosConsultados"];

                int numregistros = DatosConsultados.Rows.Count;

                if (numregistros == 0)
                {
                    LABEL_TABLA_CONSULTA_EMPLEADO.Visible = true;
                    LABEL_TABLA_CONSULTA_EMPLEADO.Text = "No existe en la base de datos empleado con el valor buscado";
                }
                else
                {
                    bool respuestaSQL = empleado.Procedimiento_Eliminar_Empleado(INFORMACION_BUSCADA.Text);
                    if (respuestaSQL == true)
                    {
                        LABEL_TABLA_CONSULTA_EMPLEADO.Visible = true;
                        LABEL_TABLA_CONSULTA_EMPLEADO.Text = "Los datos de este cliente fueron eliminados";
                    }
                    else
                    {
                        LABEL_TABLA_CONSULTA_EMPLEADO.Visible = true;
                        LABEL_TABLA_CONSULTA_EMPLEADO.Text = empleado.TEXTO;
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