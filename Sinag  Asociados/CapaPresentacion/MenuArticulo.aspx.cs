using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion.Articulos
{
    public partial class MenuArticulo1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Registrar1_Click(object sender, EventArgs e)
        {
            Response.Redirect("V_ArticuloRegistrar.aspx");
                }
    }
}