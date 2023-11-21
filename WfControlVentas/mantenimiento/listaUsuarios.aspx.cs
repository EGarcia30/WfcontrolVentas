using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WfControlVentas
{
    public partial class listaUsuarios : System.Web.UI.Page
    {
        wcfControlVentas.ServiceClient ws = new wcfControlVentas.ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GvUsuarios.DataSource = ws.mostrarUsuarios();
                GvUsuarios.DataBind();
            }
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../mantenimiento/usuario.aspx");
        }
    }
}