using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacionWeb
{
    public class Contacto :System.Web.UI.Page
    {
        Comentarios CE = new Comentarios();
        logicaNegocioComentarios CN = new logicaNegocioComentarios();

        protected void btcontacto_Click(object sender, EventArgs e)
        {
            try
            {
                CE.Nombres = txtnombres.Value;
                CE.Correo = txtcorreo.Value;
                CE.Telefono = txttelefono.Value;
                CE.Mensaje = txtmensaje.Value;

                if (CN.insertarcomentarios(CE) == 1)
                {
                    indicador.Text = "Enviado";
                    indicador.CssClass = "label label-sucess";

                    txtnombres.Value = "";
                    txtcorreo.Value = "";
                    txtmensaje.Value = "";
                    txttelefono.Value = "";
                }
                else
                {
                    indicador.Text = "Error al enviar";
                    indicador.CssClass = "label label-danger";
                }
            }

            catch (Exception ex)
            {
                indicador.Text = ex.Message.ToString();
            }
            
        }



    }

}
