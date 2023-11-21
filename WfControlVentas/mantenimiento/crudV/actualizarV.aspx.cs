using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WfControlVentas.mantenimiento.crudV
{
    public partial class actualizarV : System.Web.UI.Page
    {

        //instaciamos wcf y algunos datos que nos serviran al cargar la pag
        wcfControlVentas.ServiceClient ws = new wcfControlVentas.ServiceClient();
        DataSet datos;
        DataSet datosP;
        int validador;
        public static int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
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

                    txtCantVent.Text = datos.Tables[1].Rows[0]["cantVenta"].ToString();
                    rdbVenta.Checked = true;
                }
                else
                {
                    //Si no se encuentra el id nos mostrara un mensaje de error
                    lblMensaje.Text = "El ID no fue identificado";
                    lblMensaje.CssClass = "alert alert-danger d-block";
                }
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int idVenta = id;
                datos = ws.mostrarVentaCRUD(idVenta);
                int idProducto = int.Parse(datos.Tables[1].Rows[0]["id_producto"].ToString());
                int cantVenta = int.Parse(txtCantVent.Text);
                datosP = ws.mostrarProductoCRUD(idProducto);
                int cantPantalon = int.Parse(datosP.Tables[1].Rows[0]["cantPantalones"].ToString());
                float precioU = float.Parse(datosP.Tables[1].Rows[0]["precioUnitario"].ToString());
                string estado = "";
                if (rdbVenta.Checked == true) estado = rdbVenta.Text.Trim();
                string usuario = Session["nombreUsuario"].ToString();

                datos = ws.ActualizarVenta(idVenta, idProducto, cantVenta, cantPantalon, precioU, estado, usuario);

                validador = int.Parse(datos.Tables[0].Rows[0]["validador"].ToString());

                lblMensaje.Text = datos.Tables[0].Rows[0]["Mensaje"].ToString();

                switch (validador)
                {
                    case 1:
                        lblMensaje.CssClass = "alert alert-success d-block";
                        break;
                    default:
                        lblMensaje.CssClass = "alert alert-danger d-block";
                        break;
                }


            }
            catch(Exception ex)
            {
                lblMensaje.Text = ex.Message;
                lblMensaje.CssClass = "alert alert-danger";
            }

        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../ventas.aspx");
        }
    }
}