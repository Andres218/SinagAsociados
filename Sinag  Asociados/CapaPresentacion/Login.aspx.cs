using LogicaCapa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Empleado emplea = new Empleado();
            emplea.Usuario = txtusuario.Text;
            emplea.Contraseña = Txtpass.Text;

            string RolEmpleado = emplea.SP_Login();
            
            if (RolEmpleado=="Administrador") 
            {
                Session["sesion"] = txtusuario.Text;
                Response.Redirect("Principal.aspx");

            }
            else if (RolEmpleado == "Empleado")
            {
                Session["sesion"] = txtusuario.Text;
                Response.Redirect("Principal.aspx");

            }
            else
            { 
                MensajeError.Text = "Usuario incorrecto";
                MensajeError.Visible = true;

            }

        }

        protected void txtusuario_TextChanged(object sender, EventArgs e)
        {




        }
    }

   
}