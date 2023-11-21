using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WfControlVentas.mantenimiento
{
    public partial class cerrarSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["id"] = "";
            Session["nombreUsuario"] = "";
            Session["nombreReal"] = "";
            Session["clave"] = "";
            Session["tipoUsuario"] = "";

            Response.Redirect("../inicioSesion.aspx");
        }
    }
}