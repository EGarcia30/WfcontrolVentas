using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WfControlVentas.mantenimiento
{
    public partial class index : System.Web.UI.Page
    {
        //instanciamos nuestro wcf y definimos un dataset que usaremos para llenar nuestra tabla producto
        wcfControlVentas.ServiceClient ws = new wcfControlVentas.ServiceClient();
        DataSet datos;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fchInicio.Visible = false;
                fchFinal.Visible = false;

                DateTime fch = DateTime.Now.AddMonths(-1);
                DateTime fchFin = DateTime.Now;

                datos = ws.mostrarInversion(fch, fchFin);
                lblInversion.Text = datos.Tables[0].Rows[0]["inversion"].ToString();

                datos = ws.mostrarGanancia(fch, fchFin);
                lblVentas.Text = datos.Tables[0].Rows[0]["ventas"].ToString();

                float inversion = float.Parse(lblInversion.Text);
                float venta = float.Parse(lblVentas.Text);
                float ganancia = (venta - inversion);
                lblProducto.Text = ganancia.ToString() + ".00";
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

        protected void btnVer_Click(object sender, EventArgs e)
        {
            //Obtenemos nuestras fechas de los calendarios seleccionados
            DateTime fchInicial = fchInicio.SelectedDate;
            DateTime fchFin = fchFinal.SelectedDate;

            //Volvemos a esconder los calendarios a los botones
            fchInicio.Visible = false;
            fchFinal.Visible = false;

            datos = ws.mostrarInversion(fchInicial, fchFin);
            lblInversion.Text = datos.Tables[0].Rows[0]["inversion"].ToString();

            datos = ws.mostrarGanancia(fchInicial, fchFin);
            lblVentas.Text = datos.Tables[0].Rows[0]["ventas"].ToString();

            try
            {
                float inversion = float.Parse(lblInversion.Text);
                float venta = float.Parse(lblVentas.Text);
                float ganancia = (venta - inversion);
                lblProducto.Text = ganancia.ToString() + ".00";

            }
            catch(Exception )
            {
                lblMensaje.Text = "No existe venta o inversion en esta fecha";
                lblMensaje.CssClass = "d-block alert alert-warning";
            }
        }
    }
}