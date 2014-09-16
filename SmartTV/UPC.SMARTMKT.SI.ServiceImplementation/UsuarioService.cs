using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

using UPC.SMARTMKT.SI.DataContracts;
using UPC.SMARTMKT.SI.ServiceContracts;
using UPC.SMARTMKT.DL.DATAMODEL;
using UPC.SMARTMKT.BL.BC;

namespace UPC.SMARTMKT.SI.ServiceImplementation
{
    public class UsuarioService :IUsuarioService
    {
        public UsuarioDC ObtenerUsuario(String sUsuario)
        {
            try
            {
                UsuarioBC objUsuarioBC = new UsuarioBC();
                return HelperTrans.TranslateFromUsuarioToUsuarioDC(objUsuarioBC.UsuarioObtener(sUsuario));
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        public bool CrearUsuario(UsuarioDC objUsuarioDC)
        {
            try
            {
                UsuarioBC objUsuarioBC = new UsuarioBC();
               return objUsuarioBC.CrearUsuario(HelperTrans.TranslateFromUsuarioDCToUsuario(objUsuarioDC));

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
