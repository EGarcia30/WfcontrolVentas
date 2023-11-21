using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WfControlVentas.mantenimiento.crudV
{
    public partial class eliminarV : System.Web.UI.Page
    {
        wcfControlVentas.ServiceClient ws = new wcfControlVentas.ServiceClient();
        public static int id = 0;
        DataSet datos;
        int validador;
        protected void Page_Load(object sender, EventArgs e)
        {
            string validacionUser = null;
            validacionUser = Session["tipoUsuario"].ToString();
            if (validacionUser.Equals("usuario") || validacionUser == null)
            {
                Response.Redirect("../ventas.aspx");
            }

            //condicion la primer vez que se entre a la pag
            if (!IsPostBack)
            {
                //condicion de que el id que hemos puesto en la url no este null
                if (Request.QueryString["id"] != null)
                {
                    //Se le asigna a nuestra variable id de tipo int
                    id = int.Parse(Request.QueryString["id"].ToString());

                    //se consulta al wcf y nos retorne los datos que deseamos de la tabla
                    datos = ws.mostrarVentaCRUD(id);

                    //mostramos los datos en un gv
                    GvVentaE.DataSource = datos.Tables[1];
                    GvVentaE.DataBind();
                }
                else
                {
                    //Si no se encuentra el id nos mostrara un mensaje de error
                    lblMensaje.Text = "El ID no fue identificado";
                    lblMensaje.CssClass = "alert alert-danger";
                }
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                datos = ws.EliminarVenta(id);

                int validar = int.Parse(datos.Tables[0].Rows[0]["validador"].ToString());

                lblMensaje.Text = datos.Tables[0].Rows[0]["Mensaje"].ToString();

                switch (validar)
                {
                    case 1:
                        lblMensaje.CssClass = "alert alert-success d-block";
                        break;
                    default:
                        lblMensaje.CssClass = "alert alert-danger d-block";
                        break;
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
                lblMensaje.CssClass = "alert alert-danger d-block";
            }
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../ventas.aspx");
        }
    }
}