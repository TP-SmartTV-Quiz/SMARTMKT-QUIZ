using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPC.SMARTMKT.DL.DATAMODEL;
using UPC.SMARTMKT.DL.DALC;
namespace UPC.SMARTMKT.BL.BC
{
    public class UsuarioBC
    {
        public USUARIO UsuarioObtener(String sUsuario)
        {
            try
            {
                UsuarioDALC objUsuarioDALC = new UsuarioDALC();
                return objUsuarioDALC.UsuarioObtener(sUsuario);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        public bool CrearUsuario(USUARIO objUsuario)
        {
            try
            {
                UsuarioDALC objUsuarioDALC = new UsuarioDALC();
               return objUsuarioDALC.CrearUsuario(objUsuario);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
