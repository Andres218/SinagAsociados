using System;
using LogicaCapa;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace CapaPresentacion.Empleados
{
    public partial class V_EmpleadoRegistrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            COMENTARIO_REGISTRAR.Visible = false;
        }


        protected void Registrar_Empleado_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            try
            {
                empleado.Codigo_Empleado = Id_E.Text;
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

                bool respuestaSQL = empleado.Procedimiento_Registrar_Empleado();

                if (respuestaSQL == true)
                {
                    COMENTARIO_REGISTRAR.Visible = true;
                    COMENTARIO_REGISTRAR.Text = "Empleado Registrado";
                    Id_E.Text = ""; nombre.Text = ""; genero.SelectedValue = ""; Rol_E.SelectedValue = ""; Contraseña.Text = "";
                    email.Text = ""; Direccion.Text = ""; telefono.Text = ""; Estado.SelectedValue = ""; Usuario.Text = "";
                }
                else
                {
                    COMENTARIO_REGISTRAR.Visible = true;
                    COMENTARIO_REGISTRAR.Text = empleado.TEXTO;
                }
            }
            catch (Exception EX)
            {
                COMENTARIO_REGISTRAR.Visible = true;
                COMENTARIO_REGISTRAR.Text = "ERROR!" + EX.Message + " " + empleado.TEXTO;
            }
        }
    }
}

