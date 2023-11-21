using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;

namespace WfControlVentas.mantenimiento
{
    public partial class producto : System.Web.UI.Page
    {
        //instanciamos nuestro wcf y definimos un dataset que usaremos para llenar nuestra tabla producto
        wcfControlVentas.ServiceClient ws = new wcfControlVentas.ServiceClient();
        DataSet datos;
        public string id;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["tipoUsuario"].Equals("usuario"))
            {
                btnIngresar.Enabled = false;
            }

            //Escondemos los calendarios la primer vez que se muestra
            if (!IsPostBack)
            {
                DateTime fch = DateTime.Now.AddMonths(-1);
                DateTime fchFin = DateTime.Now;

                GvProducto.DataSource = ws.mostrarProductoDinamico(fch, fchFin);
                GvProducto.DataBind();

                fchInicio.Visible = false;
                fchFinal.Visible = false;
            }


        }

        //accion al apretar los botones nos muestra o desaparece el calendario
        protected void btnFchInicio_Click(object sender, EventArgs e)
        {
            fchInicio.Visible = !fchInicio.Visible;
        }

        protected void btnFchFinal_Click(object sender, EventArgs e)
        {
            fchFinal.Visible = !fchFinal.Visible;
        }

        protected void btnVentas_Click(object sender, EventArgs e)
        {
            Response.Redirect("ventas.aspx");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Button btnEliminar = (Button)sender;
            GridViewRow fila = (GridViewRow)btnEliminar.NamingContainer;

            id = fila.Cells[1].Text;

            Response.Redirect("/mantenimiento/crudP/eliminarP.aspx?id=" + id);
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Button btnActualizar = (Button)sender;
            GridViewRow fila = (GridViewRow)btnActualizar.NamingContainer;
            id = fila.Cells[1].Text;

            Response.Redirect("/mantenimiento/crudP/actualizarP.aspx?id=" + id);
        }

        protected void btnVerTablaProducto_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtenemos nuestras fechas de los calendarios seleccionados
                DateTime fchInicial = fchInicio.SelectedDate;
                DateTime fchFin = fchFinal.SelectedDate;

                //Volvemos a esconder los calendarios a los botones
                fchInicio.Visible = false;
                fchFinal.Visible = false;

                //llenamos nuestro GridView con la tabla producto dentro del rango de fechas seleccionados
                GvProducto.DataSource = ws.mostrarProductoDinamico(fchInicial, fchFin);
                GvProducto.DataBind();

            }
            catch (Exception ex)
            {
                //si nuestro try y catch encuentra un error al momento de ejecutar nos aparecera este mensaje
                lblMensaje.Text = "Ocurrio un error al mostrar tabla Producto";
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
                int validador = 2;

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
                datos = ws.buscadorProductos(num, letra, dec);

                validador = int.Parse(datos.Tables[0].Rows[0][0].ToString());

                //condicion dependiendo que nos traiga nuestro validador es lo que muestra
                switch (validador)
                {
                    case 2:
                        //Tabla Producto
                        GvProducto.DataSource = datos.Tables[1];
                        GvProducto.DataBind();
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
                //si nuestro try y catch encuentra un error al momento de ejecutar nos aparecera este mensaje
                lblMensaje.Text = ex.Message;
                lblMensaje.CssClass = "alert alert-danger d-block";
            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            //Redirijir a nuestro crud en la seccion de ingresar nuevo Producto
            Response.Redirect("/mantenimiento/crudP/ingresarP.aspx");
        }
    }
}