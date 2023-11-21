using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WfControlVentas.mantenimiento
{
    public partial class usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["tipoUsuario"].Equals("usuario"))
            {
                btnAgregar.Enabled = false;
            }

            lblNombre.Text = Session["nombreReal"].ToString();
            lblNombreR.Text = Session["nombreReal"].ToString();
            lblId.Text = Session["id"].ToString();
            lblNombreU.Text = Session["nombreUsuario"].ToString();
            lblClave.Text = Session["clave"].ToString();
            lblTipo.Text = Session["tipoUsuario"].ToString();

        }

        protected void btnUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("../mantenimiento/listaUsuarios.aspx");
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../mantenimiento/crudU/ingresarU.aspx");
        }
    }
}