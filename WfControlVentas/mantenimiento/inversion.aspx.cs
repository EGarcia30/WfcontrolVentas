using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls;

namespace WfControlVentas.mantenimiento
{
    public partial class inversion : System.Web.UI.Page
    {
        //instanciamos nuestro wcf y definimos un dataset que usaremos para llenar nuestra tabla factura
        wcfControlVentas.ServiceClient ws = new wcfControlVentas.ServiceClient();
        DataSet datos;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["tipoUsuario"].Equals("usuario"))
            {
                btnIngresar.Enabled = false;
            }

            //En la primera ejecución de la pag se esconden nuestros calendarios
            if (!IsPostBack)
            {               

                DateTime fch = DateTime.Now.AddMonths(-1);
                DateTime fchFin = DateTime.Now;

                GvFactura.DataSource = ws.mostrarFacturaDinamico(fch, fchFin);
                GvFactura.DataBind();

                fchInicio.Visible = false;
                fchFinal.Visible = false;
            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            //Redirijir a nuestro crud en la seccion de ingresar nueva factura
            Response.Redirect("/mantenimiento/crudf/ingresar.aspx");
        }

        protected void btnFchInicio_Click(object sender, EventArgs e)
        {
            fchInicio.Visible = !fchInicio.Visible;
        }

        protected void btnFchFinal_Click(object sender, EventArgs e)
        {
            fchFinal.Visible = !fchFinal.Visible;
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string id;
            Button btn = (Button)sender;
            GridViewRow fila = (GridViewRow)btn.NamingContainer;
            id = fila.Cells[1].Text;
            Response.Redirect("/mantenimiento/crudf/actualizar.aspx?id=" + id);

        }

        protected void btnVerTablaFactura_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtenemos nuestras fechas de los calendarios seleccionados
                DateTime fchInicial = fchInicio.SelectedDate;
                DateTime fchFin = fchFinal.SelectedDate;

                //Volvemos a esconder los calendarios a los botones
                fchInicio.Visible = false;
                fchFinal.Visible = false;

                //llenamos nuestro GridView con la tabla factura dentro del rango de fechas seleccionados
                GvFactura.DataSource = ws.mostrarFacturaDinamico(fchInicial, fchFin);
                GvFactura.DataBind();


            }
            catch (Exception ex)
            {
                //si nuestro try y catch encuentra un error al momento de ejecutar nos aparecera este mensaje
                lblMensaje.Text = "Ocurrio un error al mostrar tabla Factura";
                lblMensaje.CssClass = "alert alert-warning d-block";
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //declaración de variables
                int num = 0;
                float mon = 0f;
                string usuario = "";
                int validador = 2;

                //Validación de expresiones regulares para nuestro buscador
                Boolean validacionNum = Regex.IsMatch(txtBuscar.Text, @"^[\d]");
                Boolean validacionFloat = Regex.IsMatch(txtBuscar.Text, @"[\d].00");
                Boolean validacionLetra = Regex.IsMatch(txtBuscar.Text, @"^[\D]");

                //condicion para asignar a una variable su valor
                if (validacionLetra)
                {
                    usuario = txtBuscar.Text.Trim();
                }
                else if (validacionNum && !validacionLetra && !validacionFloat)
                {
                    num = int.Parse(txtBuscar.Text.Trim());
                }
                else if (validacionFloat && !validacionLetra)
                {
                    mon = float.Parse(txtBuscar.Text.Trim());
                }

                //Mandarla a buscar el dato correspondiente de la tabla
                datos = ws.buscadorFacturas(num, mon, usuario);

                validador = int.Parse(datos.Tables[0].Rows[0][0].ToString());

                //condicion dependiendo que nos traiga nuestro validador es lo que muestra
                switch (validador)
                {
                    case 2:
                        //Tabla Factura
                        GvFactura.DataSource = datos.Tables[1];
                        GvFactura.DataBind();
                        break;
                    case 1:
                        //nos retorna un mensaje de error que no se encuentra factura
                        lblMensaje.Text = datos.Tables[0].Rows[0]["Mensaje"].ToString();
                        lblMensaje.CssClass = "alert alert-warning d-block";
                        break;
                    default:
                        //Por defecto tiene un error de que el proceso fallo en algun punto de la busquedad
                        lblMensaje.Text = datos.Tables[0].Rows[0]["Mensaje"].ToString();
                        lblMensaje.CssClass = "alert alert-danger d-block";
                        break;
                };
            }
            catch(Exception ex)
            {
                //si nuestro try y catch encuentra un error al momento de ejecutar nos aparecera este mensaje
                lblMensaje.Text = ex.Message;
                lblMensaje.CssClass = "alert alert-danger d-block";
            }
           
        }
    }
}