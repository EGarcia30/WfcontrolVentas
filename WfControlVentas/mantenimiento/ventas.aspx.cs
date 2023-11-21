using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Data;

namespace WfControlVentas.mantenimiento
{
    public partial class ventas : System.Web.UI.Page
    {
        wcfControlVentas.ServiceClient ws = new wcfControlVentas.ServiceClient();
        DataSet datos;
        public string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            //verificacion de la primer vez que se muestra
            if (!IsPostBack)
            {
                DateTime fch = DateTime.Now.AddMonths(-1);
                DateTime fchFin = DateTime.Now;

                GvVentas.DataSource = ws.mostrarVentaDinamico(fch, fchFin);
                GvVentas.DataBind();

                fchInicio.Visible = false;
                fchFinal.Visible = false;
            }
        }

        protected void btnFchInicio_Click(object sender, EventArgs e)
        {
            fchInicio.Visible = !fchInicio.Visible;
        }

        protected void btnFchFinal_Click(object sender, EventArgs e)
        {
            fchFinal.Visible = !fchFinal.Visible;
        }

        protected void btnProducto_Click(object sender, EventArgs e)
        {
            Response.Redirect("producto.aspx");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Button btnEliminar = (Button)sender;
            GridViewRow fila = (GridViewRow)btnEliminar.NamingContainer;
            id = fila.Cells[1].Text;

            Response.Redirect("/mantenimiento/crudV/eliminarV.aspx?id=" + id);
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Button btnActualizar = (Button)sender;
            GridViewRow fila = (GridViewRow)btnActualizar.NamingContainer;
            id = fila.Cells[1].Text;

            Response.Redirect("/mantenimiento/crudV/actualizarV.aspx?id=" + id);
        }

        protected void btnVerTablaVenta_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fchInicial = fchInicio.SelectedDate;
                DateTime fchFin = fchFinal.SelectedDate;

                fchInicio.Visible = false;
                fchFinal.Visible = false;

                GvVentas.DataSource = ws.mostrarVentaDinamico(fchInicial, fchFin);
                GvVentas.DataBind();

            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
                lblMensaje.CssClass = "alert alert-warning d-block";
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //declaración de variables
                int num = 0;
                float dec = 0f;
                string letra = "";
                int validador = 0;

                //Validación de expresiones regulares para nuestro buscador
                Boolean validacionNum = Regex.IsMatch(txtBuscar.Text, @"^[\d]");
                Boolean validacionFloat = Regex.IsMatch(txtBuscar.Text, @"[\d].00");
                Boolean validacionLetra = Regex.IsMatch(txtBuscar.Text, @"^[\D]");

                //condicion para asignar a una variable su valor
                if (validacionLetra)
                {
                    letra = txtBuscar.Text.Trim();
                }
                else if (validacionNum && !validacionLetra && !validacionFloat)
                {
                    num = int.Parse(txtBuscar.Text.Trim());
                }
                else if (validacionFloat && !validacionLetra)
                {
                    dec = float.Parse(txtBuscar.Text.Trim());
                }

                //Mandarla a buscar el dato correspondiente de la tabla
                datos = ws.buscadorVentas(num, dec, letra);

                validador = int.Parse(datos.Tables[0].Rows[0][0].ToString());

                //condicion dependiendo que nos traiga nuestro validador es lo que muestra
                switch (validador)
                {
                    case 1:
                        //Tabla Ventas
                        GvVentas.DataSource = datos.Tables[1];
                        GvVentas.DataBind();
                        break;
                    default:
                        //Por defecto tiene un error de que el proceso fallo en algun punto de la busquedad
                        lblMensaje.Text = datos.Tables[0].Rows[0]["Mensaje"].ToString();
                        lblMensaje.CssClass = "alert alert-danger d-block";
                        break;
                };
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
                lblMensaje.CssClass = "alert alert-warning d-block";
            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            //Redirijir a nuestro crud en la seccion de ingresar nueva venta
            Response.Redirect("/mantenimiento/crudV/ingresarV.aspx");
        }
    }
}