using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UPC.SMARTMKT.DL.DATAMODEL;
using UPC.SMARTMKT.SI.DataContracts;

namespace UPC.SMARTMKT.SI.ServiceImplementation
{
    public class HelperTrans
    {
        public static UsuarioDC TranslateFromUsuarioToUsuarioDC(USUARIO objUsuario)
        {
            if (objUsuario != null)
            {

                UsuarioDC objUsuarioDC = new UsuarioDC(); ;
                objUsuarioDC.USUARIO = objUsuario.USUARIO1;
                objUsuarioDC.CONTRASENA = objUsuario.CONTRASEÑA;
                objUsuarioDC.NOMBRE = objUsuario.NOMBRE;
                objUsuarioDC.FECNACIMIENTO = objUsuario.FECNACIMIENTO;
                objUsuarioDC.CORREO = objUsuario.CORREO;
                return objUsuarioDC;
            }
            else 
            {
                return null;
            }
            
        }
        public static USUARIO TranslateFromUsuarioDCToUsuario(UsuarioDC objUsuarioDC)
        {
            USUARIO objUsuario = new USUARIO(); ;
            if (objUsuarioDC != null)
            {

                objUsuario.USUARIO1 = objUsuarioDC.USUARIO;
                objUsuario.CONTRASEÑA = objUsuarioDC.CONTRASENA;
                objUsuario.NOMBRE = objUsuarioDC.NOMBRE;
                objUsuario.FECNACIMIENTO = objUsuarioDC.FECNACIMIENTO;
                objUsuario.CORREO = objUsuarioDC.CORREO;
                return objUsuario;
            }
            else
            {
                return null;
            }
        }
    }
}
