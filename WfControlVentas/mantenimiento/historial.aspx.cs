using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WfControlVentas.mantenimiento
{
    public partial class historial : System.Web.UI.Page
    {
        //instanciamos nuestro wcf y definimos un dataset que usaremos para llenar nuestra tabla factura
        wcfControlVentas.ServiceClient ws = new wcfControlVentas.ServiceClient();
        DataSet datos;
        protected void Page_Load(object sender, EventArgs e)
        {
            //En la primera ejecución de la pag se esconden nuestros calendarios
            if (!IsPostBack)
            {
                DateTime fch = DateTime.Now.AddMonths(-1);
                DateTime fchFin = DateTime.Now;

                datos = ws.mostrarHistorialDinamico(fch, fchFin);

                GvProductoH.DataSource = datos.Tables[0];
                GvProductoH.DataBind();

                GvVentaH.DataSource = datos.Tables[1];
                GvVentaH.DataBind();

                fchInicio.Visible = false;
                fchFinal.Visible = false;
            }
        }

        protected void btnVerTablaHistorial_Click(object sender, EventArgs e)
        {
            //Obtenemos nuestras fechas de los calendarios seleccionados
            DateTime fchInicial = fchInicio.SelectedDate;
            DateTime fchFin = fchFinal.SelectedDate;

            //Volvemos a esconder los calendarios a los botones
            fchInicio.Visible = false;
            fchFinal.Visible = false;

            datos = ws.mostrarHistorialDinamico(fchInicial, fchFin);
            //llenamos nuestro GridView con la tabla factura dentro del rango de fechas seleccionados
            GvProductoH.DataSource = datos.Tables[0];
            GvProductoH.DataBind();

            GvVentaH.DataSource = datos.Tables[1];
            GvVentaH.DataBind();
        }

        protected void btnFchInicio_Click(object sender, EventArgs e)
        {
            fchInicio.Visible = !fchInicio.Visible;
        }

        protected void btnFchFinal_Click(object sender, EventArgs e)
        {
            fchFinal.Visible = !fchFinal.Visible;
        }
    }
}