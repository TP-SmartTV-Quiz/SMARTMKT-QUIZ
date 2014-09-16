using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegistrarUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        bool CreoUsuario;
        DateTime FechaActual;
        string mensaje;
        
        try
        {
            if (Page.IsValid)
            {             
                ServiceUsuarioClient.UsuarioServiceClient objUsuarioService = new ServiceUsuarioClient.UsuarioServiceClient();
                ServiceUsuarioClient.UsuarioDC objUsuarioDC = new ServiceUsuarioClient.UsuarioDC();

                    objUsuarioDC.USUARIO = txtUsuario.Text;
                    objUsuarioDC.CONTRASENA = Encriptar.MD5hash(txtContrasena.Text);
                    objUsuarioDC.NOMBRE = txtNombre.Text;
                    objUsuarioDC.FECNACIMIENTO = DateTime.Parse(txtFecNacimiento.Text);
                    objUsuarioDC.CORREO = txtCorreo.Text;

                if (objUsuarioService.ObtenerUsuario(objUsuarioDC.USUARIO).USUARIO == objUsuarioDC.USUARIO)
                {
                    mensaje = "Este Nombre de usuario ya existe";
                    ClientScript.RegisterStartupScript(this.GetType(), "Popup", "MsgError('" + mensaje + "');", true);
                }
                else
                {
                    if (objUsuarioDC.FECNACIMIENTO.Year > 2010)
                    {
                        //   ClientScript.RegisterClientScriptBlock(GetType(), "MensajeInsertar", "<script language=\"JavaScript\">alert(\"El producto fue registrado satisfactoriamente.\")</script>", false);
                        mensaje = "Tienes que tener de 4 años a mas para poder jugar";
                        ClientScript.RegisterStartupScript(this.GetType(), "Popup", "MsgError('" + mensaje + "');", true);
                    }
                    else
                    {
                        CreoUsuario = objUsuarioService.CrearUsuario(objUsuarioDC);
                        if (CreoUsuario == false)
                        {
                            //    ClientScript.RegisterStartupScript(GetType(), "Javascript", "javascript:MsjConfirmacion(); ", true);
                            mensaje = "No se pudo registrar el usuario";
                            ClientScript.RegisterStartupScript(this.GetType(), "Popup", "MsgError('" + mensaje + "');", true);
                        }
                        if (CreoUsuario == true)
                        {
                            mensaje = "Se Registro el usuario con exito!";
                            ClientScript.RegisterStartupScript(this.GetType(), "Popup", "MsgConfirmacion('" + mensaje + "');", true);


                        }

                    }
                }
            }

        }
         catch (Exception ex)
        {

            throw ex;
        }
    }

    protected void ContrasenaValidator_ServerValidate(object source, ServerValidateEventArgs e)
    {
        e.IsValid = (e.Value.Length >= 8 && e.Value.Length <= 16);
    }
    protected void cvtxtUsuario_ServerValidate(object source, ServerValidateEventArgs e)
    {
        e.IsValid = (e.Value.Length >= 1 && e.Value.Length <= 16);
    }
}