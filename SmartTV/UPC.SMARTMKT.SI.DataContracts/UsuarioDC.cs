using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
namespace UPC.SMARTMKT.SI.DataContracts
{
    [DataContract]
    public class UsuarioDC
    {
        private String _USUARIO;
        private String _CONTRASENA;
        private String _NOMBRE;
        private String _CORREO;
        private DateTime _FECNACIMIENTO;

        [DataMember]
        public String USUARIO 
        {
            get { return _USUARIO; }
            set { _USUARIO = value; }
        }
        [DataMember]
        public String CONTRASENA
        {
            get { return _CONTRASENA; }
            set { _CONTRASENA = value; }
        }
        [DataMember]
        public String NOMBRE
        {
            get { return _NOMBRE; }
            set { _NOMBRE = value; }
        }
      
        [DataMember]
        public String CORREO
        {
            get { return _CORREO; }
            set { _CORREO = value; }
        }
        [DataMember]
        public DateTime FECNACIMIENTO
        {
            get { return _FECNACIMIENTO; }
            set { _FECNACIMIENTO = value; }
        }

    }
}
