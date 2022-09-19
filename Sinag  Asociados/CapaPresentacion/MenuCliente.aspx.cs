using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion.Clientes
{
    public partial class MenuCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Registrar3_Click(object sender, EventArgs e)
        {
            Response.Redirect("V_ClienteRegistrar.aspx");
        }
    }
}