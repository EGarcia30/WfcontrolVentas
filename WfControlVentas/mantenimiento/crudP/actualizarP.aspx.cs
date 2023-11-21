using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WfControlVentas.mantenimiento.crudP
{
    public partial class actualizarP : System.Web.UI.Page
    {
        //instaciamos wcf y algunos datos que nos serviran al cargar la pag
        wcfControlVentas.ServiceClient ws = new wcfControlVentas.ServiceClient();
        DataSet datos;
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
                    datos = ws.mostrarProductoCRUD(id);

                    //traemos nuestro validador de bd para despues condicionar
                    validador = int.Parse(datos.Tables[0].Rows[0]["validador"].ToString());

                    //en nuestro switch depende del caso hace una accion especifica
                    switch (validador)
                    {
                        case 1:
                            txtCant.Text = datos.Tables[1].Rows[0]["cantPantalones"].ToString();
                            txtColor.Text = datos.Tables[1].Rows[0]["colorEstilo_producto"].ToString();
                            txtMarca.Text = datos.Tables[1].Rows[0]["marca"].ToString();
                            txtTalla.Text = datos.Tables[1].Rows[0]["tallaReal"].ToString();
                            txtPrecio.Text = datos.Tables[1].Rows[0]["precioUnitario"].ToString();
                            rdbStock.Checked = true;
                            txtIdFactura.Text = datos.Tables[1].Rows[0]["id_factura"].ToString();
                            break;
                        default:
                            lblMensaje.Text = datos.Tables[0].Rows[0]["Mensaje"].ToString();
                            lblMensaje.CssClass = "alert alert-danger d-block";
                            break;
                    }
                }
                else
                {
                    //Si no se encuentra el id nos mostrara un mensaje de error
                    lblMensaje.Text = "El ID no fue identificado";
                    lblMensaje.CssClass = "alert alert-danger";
                }

            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
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
                if (rdbStock.Checked == true) estado = rdbStock.Text.Trim();
                int idFac = int.Parse(txtIdFactura.Text.Trim());
                int idUser = int.Parse(Session["id"].ToString());
                string usuario = Session["nombreUsuario"].ToString();

                datos = ws.ActualizarProducto(id, cant, color, marca, talla, precioU, estado, usuario);

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
            catch(Exception ex)
            {
                lblMensaje.Text = ex.Message;
                lblMensaje.CssClass = "alert alert-danger d-block";
            }
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("../producto.aspx");
        }
    }
}