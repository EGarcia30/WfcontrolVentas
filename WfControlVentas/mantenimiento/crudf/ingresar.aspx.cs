using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WfControlVentas.mantenimiento.crudf
{
    public partial class ingresar : System.Web.UI.Page
    {
        wcfControlVentas.ServiceClient ws = new wcfControlVentas.ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            string validacionUser = null;
            validacionUser = Session["tipoUsuario"].ToString();
            if (validacionUser.Equals("usuario") || validacionUser == null)
            {
                Response.Redirect("../inversion.aspx");
            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                int validador = 0;
                float monto = float.Parse(txtInversion.Text.Trim());
                int cantidad = int.Parse(txtCantidad.Text.Trim());
                int id = int.Parse(Session["id"].ToString());
                string usuario = Session["nombreUsuario"].ToString();

                DataSet datos = ws.IngresarFactura(monto, cantidad, id, usuario);

                validador = int.Parse(datos.Tables[0].Rows[0]["validador"].ToString());

                if (validador == 1)
                {
                    lblMensaje.Text = datos.Tables[0].Rows[0]["Mensaje"].ToString();
                    lblMensaje.CssClass = "alert alert-success d-block";
                }
                else
                {
                    lblMensaje.Text = datos.Tables[0].Rows[0]["Mensaje"].ToString();
                    lblMensaje.CssClass = "alert alert-warning d-block";
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
                lblMensaje.CssClass = "alert alert-danger d-block";
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/mantenimiento/crudf/ingresar.aspx");
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../inversion.aspx");
        }
    }
}