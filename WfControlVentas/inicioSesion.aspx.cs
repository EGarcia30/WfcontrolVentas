using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WfControlVentas
{
    public partial class inicioSesion : System.Web.UI.Page
    {
        //instaciamos nuestro wcf y declaramos nuestro dataset
        wcfControlVentas.ServiceClient ws = new wcfControlVentas.ServiceClient();
        DataSet datos;
        protected void Page_Load(object sender, EventArgs e)
        {
             
        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                //declaracion y asignacion a variables
                string usuario = txtUsuario.Text;
                string clave = txtContra.Text;
                int validar = 0;

                //usamos nuestro bd para que nos retorne informacion en bd y llenar nuestro dataset
                datos = ws.InicioSesion(usuario, clave);

                //de nuestra columna validador en bd le asignamos el valor a nuestra variable
                validar = int.Parse(datos.Tables[0].Rows[0]["validador"].ToString());


                //condicionamos con nuestra variable validador
                if (validar == 1)
                {
                    //si cumple la condicion nos crea variables de sesion para identificar al usuario ingresado dentro del sistema
                    Session["id"] = datos.Tables[0].Rows[0]["id_usuario"].ToString();
                    Session["nombreUsuario"] = datos.Tables[0].Rows[0]["n_usuario"].ToString();
                    Session["nombreReal"] = datos.Tables[0].Rows[0]["n_real"].ToString();
                    Session["clave"] = datos.Tables[0].Rows[0]["clave"].ToString();
                    Session["tipoUsuario"] = datos.Tables[0].Rows[0]["t_usuario"].ToString();

                    //Por ultimo se reedirije a nuestro index y estaria dentro del programa
                    Response.Redirect("mantenimiento/index.aspx");
                }
                else { 
                    //si no cumple la condición nos llenara nuestro label con un mensaje de error y se le agregan estilos
                    lblError.Text = datos.Tables[0].Rows[0]["Mensaje"].ToString();
                    lblError.CssClass = "alert alert-warning d-block";
                }

            }
            catch(Exception ex)
            {
                //si ocurre algun tipo de error en el proceso de ejecutar nos retornara el mensaje con sus estilos css
                lblError.Text = ex.Message;
                lblError.CssClass = "alert alert-danger d-block";
            }
        }
    }
}