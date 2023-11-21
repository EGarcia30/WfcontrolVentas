using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WfControlVentas.mantenimiento.crudV
{
    public partial class ingresarV : System.Web.UI.Page
    {
        wcfControlVentas.ServiceClient ws = new wcfControlVentas.ServiceClient();
        DataSet validacion;
        DataSet datos;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //decalracion y asignacion de variables
                int cantVenta = int.Parse(txtCantVent.Text);
                string estado = "";
                if (rdbVenta.Checked == true) estado = rdbVenta.Text.Trim();
                int idProducto = int.Parse(txtIdProducto.Text);
                int idFactura = int.Parse(txtIdFactura.Text);
                int idUser = int.Parse(Session["id"].ToString());
                string usuario = Session["nombreUsuario"].ToString();

                //traemos los datos de la tabla producto que necesitamos
                validacion = ws.mostrarProductoCRUD(idProducto);

                //asignamos a variables
                int cantPantalones = int.Parse(validacion.Tables[1].Rows[0]["cantPantalones"].ToString());
                float precioU = float.Parse(validacion.Tables[1].Rows[0]["precioUnitario"].ToString());

                //ejecutamos nuestro ingreso de venta en el wcf
                datos = ws.IngresarVenta(cantPantalones, cantVenta, precioU, estado, idProducto, idFactura, idUser, usuario);

                //hacemos uso del retorno validador para dar caracteristica a nuestro mensaje
                int validar = int.Parse(datos.Tables[0].Rows[0]["validador"].ToString());

                lblMensaje.Text = datos.Tables[0].Rows[0]["Mensaje"].ToString();

                switch (validar)
                {
                    case 1:
                        lblMensaje.CssClass = "alert alert-success d-block";
                        break;
                    default:
                        lblMensaje.CssClass = "alert alert-warning d-block";
                        break;
                }
            }
            catch(Exception ex)
            {
                lblMensaje.Text = ex.Message;
                lblMensaje.CssClass = "alert alert-warning d-block";
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/mantenimiento/crudV/ingresarV.aspx");
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../ventas.aspx");
        }
    }
}