using LogicaCapa;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion.Empleados
{
    public partial class V_EmpleadoModificar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                Formulario_Actualizar_Empleado.Visible = false;
            }
            COMENTARIO_ACTUALIZAR.Visible = false;
            LABEL_TABLA_CONSULTA_EMPLEADO.Visible = false;
        }

        protected void CONSULTAR_EMPLEADO_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            DataSet DatosCliente = new DataSet();

            DatosCliente = empleado.Procedimiento_Consultar_Empleado(INFORMACION_BUSCADA.Text, "Codigo del Empleado");

            try
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
                    Formulario_Actualizar_Empleado.Visible = true;
                    nombre.Text = DatosConsultados.Rows[0]["NombreEmpleado"].ToString();
                    genero.SelectedValue = DatosConsultados.Rows[0]["GeneroEmpleado"].ToString();
                    email.Text = DatosConsultados.Rows[0]["CorreoEmpleado"].ToString();
                    Direccion.Text = DatosConsultados.Rows[0]["DireccionEmpleado"].ToString();
                    telefono.Text = DatosConsultados.Rows[0]["TelefonoEmpleado"].ToString();
                    Estado.SelectedValue = DatosConsultados.Rows[0]["EstadoEmpleado"].ToString();
                    Rol_E.SelectedValue = DatosConsultados.Rows[0]["RolEmpleado"].ToString();
                    Usuario.Text = DatosConsultados.Rows[0]["Usuario"].ToString();
                    Contraseña.Text = DatosConsultados.Rows[0]["Contraseña"].ToString();

                }
            }
            catch (Exception ex)
            {
                LABEL_TABLA_CONSULTA_EMPLEADO.Visible = true;
                LABEL_TABLA_CONSULTA_EMPLEADO.Text = "no se ha podido efectuar la consulta debido al siguiente ERROR: " + ex.Message;
            }
        }

        protected void Actualizar_Empleado_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            try
            {
                empleado.Codigo_Empleado = INFORMACION_BUSCADA.Text;
                empleado.Nombre = nombre.Text;
                empleado.Usuario = Usuario.Text;
                empleado.Contraseña = Contraseña.Text;
                empleado.Correo = email.Text;
                empleado.Direccion = Direccion.Text;
                empleado.Telefono = telefono.Text;
                if (Rol_E.SelectedValue == "Administrador")
                {
                    empleado.ROLEMPLEADO = "Administrador";
                }
                else if (Rol_E.SelectedValue == "Empleado")
                {
                    empleado.ROLEMPLEADO = "Empleado";
                }
                if (Estado.SelectedValue == "Activo")
                {
                    empleado.Estado_Empleado = "Activo";
                }
                else if (Estado.SelectedValue == "Inactivo")
                {
                    empleado.Estado_Empleado = "Inactivo";
                }
                if (genero.SelectedValue == "Masculino")
                {
                    empleado.Genero = "Masculino";
                }
                else if (genero.SelectedValue == "Femenino")
                {
                    empleado.Genero = "Femenino";
                }

                bool respuestaSQL = empleado.Procedimiento_ActualizarEmpleado();

                if (respuestaSQL == true)
                {
                    COMENTARIO_ACTUALIZAR.Visible = true;
                    COMENTARIO_ACTUALIZAR.Text = "Datos Actualizados";
                     nombre.Text = ""; genero.SelectedValue = ""; Rol_E.SelectedValue = ""; Contraseña.Text = "";
                    email.Text = ""; Direccion.Text = ""; telefono.Text = ""; Estado.SelectedValue = ""; Usuario.Text = "";
                }
                else
                {
                    COMENTARIO_ACTUALIZAR.Visible = true;
                    COMENTARIO_ACTUALIZAR.Text = empleado.TEXTO;
                }
            }
            catch (Exception EX)
            {
                COMENTARIO_ACTUALIZAR.Visible = true;
                COMENTARIO_ACTUALIZAR.Text = "ERROR!" + EX.Message + " " + empleado.TEXTO;
            }
        }
    }
}