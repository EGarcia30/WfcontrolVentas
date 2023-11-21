using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WfControlVentas.mantenimiento.crudU
{
    public partial class ingresarU : System.Web.UI.Page
    {
        wcfControlVentas.ServiceClient ws = new wcfControlVentas.ServiceClient();
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            string validacionUser = null;
            validacionUser = Session["tipoUsuario"].ToString();
            if (validacionUser.Equals("usuario") || validacionUser == null)
            {
                Response.Redirect("../usuario.aspx");
            }

            if (!IsPostBack)
            {
                rdbAdministrador.Checked = false;
                rdbDesarrollador.Checked = false;
                rdbUsuario.Checked = false;
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreU = txtNombreU.Text.ToUpper();
                string nombreR = txtNombreR.Text.Trim();
                string clave = txtClave.Text.ToUpper();
                string tipoU = "";
                if (rdbDesarrollador.Checked == true)
                {
                    tipoU = rdbDesarrollador.Text.ToLower();
                }
                else if(rdbAdministrador.Checked == true)
                {
                    tipoU = rdbAdministrador.Text.ToLower();
                }
                else if(rdbUsuario.Checked == true)
                {
                    tipoU = rdbUsuario.Text.ToLower();
                }
                string usuario = Session["nombreUsuario"].ToString();

                ds = ws.agregarUsuario(nombreU, nombreR, clave, tipoU, usuario);

                int validar = int.Parse(ds.Tables[0].Rows[0]["validador"].ToString());

                lblMensaje.Text = ds.Tables[0].Rows[0]["Mensaje"].ToString();

                if(validar == 1)
                {
                    lblMensaje.CssClass = "alert alert-success d-block";
                }
                else
                {
                    lblMensaje.CssClass = "alert alert-warning d-block";
                }

            }
            catch(Exception ex)
            {
                lblMensaje.Text = ex.Message;
                lblMensaje.CssClass = "alert alert-danger d-block";
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/mantenimiento/crudU/ingresarU.aspx");
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../usuario.aspx");
        }
    }
}