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
    
    public partial class PREGUNTA
    {
        public int IDPREGUNTA { get; set; }
        public string PREGUNTA1 { get; set; }
        public string OPCION1 { get; set; }
        public string OPCION2 { get; set; }
        public string OPCION3 { get; set; }
        public string OPCION4 { get; set; }
        public int CLAVE { get; set; }
        public int IDCATEGORIA { get; set; }
        public int NIVEL { get; set; }
        public string DIFICULTAD { get; set; }
        public bool FLGELIMINADO { get; set; }
    
        public virtual CATEGORIA CATEGORIA { get; set; }
    }
}