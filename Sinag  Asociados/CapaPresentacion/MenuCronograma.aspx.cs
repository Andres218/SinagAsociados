using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion.Cronogramas
{
    public partial class MenuCronograma : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Registrar2_Click(object sender, EventArgs e)
        {
            Response.Redirect("V_CronogramaRegistrar.aspx");
        }
    }
}