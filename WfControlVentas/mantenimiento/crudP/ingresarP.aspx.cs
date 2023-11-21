using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WfControlVentas.mantenimiento.crudP
{
    public partial class ingresarP : System.Web.UI.Page
    {
        wcfControlVentas.ServiceClient ws = new wcfControlVentas.ServiceClient();
        DataSet validacion;
        DataSet datos;
        protected void Page_Load(object sender, EventArgs e)
        {
            string validacionUser = null;
            validacionUser = Session["tipoUsuario"].ToString();
            if (validacionUser.Equals("usuario") || validacionUser == null)
            {
                Response.Redirect("../producto.aspx");
            }

            if (!IsPostBack)
            {
                rdbStock.Checked = false;
                rdbVenta.Checked = false;
            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //declaracion de variables
                int cant = int.Parse(txtCant.Text.Trim());
                string color = txtColor.Text.Trim();
                string marca = txtMarca.Text.Trim();
                string talla = txtTalla.Text.Trim();
                float precioU = float.Parse(txtPrecio.Text.Trim());
                string estado = "";
                if(rdbStock.Checked == true) estado = rdbStock.Text.Trim();
                int idFac = int.Parse(txtIdFactura.Text.Trim());
                int idUser = int.Parse(Session["id"].ToString());
                string usuario = Session["nombreUsuario"].ToString();

                //taremos los datos de factura
                validacion = ws.mostrarFacturaEdit(idFac);

                int cantPrendaComprada = int.Parse(validacion.Tables[1].Rows[0]["cantidadPrendas"].ToString());

                //validamos la cantidad total de prendas compradas con las puestas en producto
                if(cant <= cantPrendaComprada)
                {
                    datos = ws.IngresarProducto(cant, color, marca, talla, precioU, estado, idFac, idUser, usuario);

                    int validar = int.Parse(datos.Tables[0].Rows[0]["validador"].ToString());

                    lblMensaje.Text = datos.Tables[0].Rows[0]["Mensaje"].ToString();

                    switch (validar)
                    {
                        case 2:
                            lblMensaje.CssClass = "alert alert-success d-block";
                            break;
                        case 1:
                            lblMensaje.CssClass = "alert alert-warning d-block";
                            break;
                        default:
                            lblMensaje.CssClass = "alert alert-danger d-block";
                            break;
                    }
                }
                else
                {
                    lblMensaje.Text = "Error: Ingreso mas pantalones que la cantidad total comprada en factura!";
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
            Response.Redirect("/mantenimiento/crudP/ingresarP.aspx");
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../producto.aspx");
        }

    }
}