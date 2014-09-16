using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using UPC.SMARTMKT.SI.DataContracts;
namespace UPC.SMARTMKT.SI.ServiceContracts
{
    [ServiceContract]
    public interface IUsuarioService
    {
        [OperationContract]
        UsuarioDC ObtenerUsuario(String sUsuario);

        [OperationContract]
        bool CrearUsuario(UsuarioDC objUsuarioDC);

    }
}
