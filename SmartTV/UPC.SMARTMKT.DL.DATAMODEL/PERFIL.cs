//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPC.SMARTMKT.DL.DATAMODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class PERFIL
    {
        public int IDPERFIL { get; set; }
        public string NOMBRE { get; set; }
        public Nullable<System.DateTime> FECNACIMIENTO { get; set; }
        public string USUARIO { get; set; }
        public int NIVEL { get; set; }
        public int PUNTOS { get; set; }
    
        public virtual USUARIO USUARIO1 { get; set; }
    }
}
