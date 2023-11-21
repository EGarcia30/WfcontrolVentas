using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WfControlVentas.master
{
    public partial class Menu : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*al cargar nuestras paginas dentro de la master page se validan con nuestra variable de sesion usuario*/
            if (Session["nombreUsuario"] == null)
            {
                //Retorna a nuestra pagina de inicio de sesion
                Response.Redirect("https://localhost:44355/inicioSesion.aspx");
            }

            /*Se agregan las variables de sesion a nuestro navbar horizontal*/
            lblUsuario.Text = Session["nombreUsuario"].ToString();
            lblTipo.Text = Session["tipoUsuario"].ToString();

        }
    }
}