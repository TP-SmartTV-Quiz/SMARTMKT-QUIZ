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
    
    public partial class CATEGORIA
    {
        public CATEGORIA()
        {
            this.PREGUNTAs = new HashSet<PREGUNTA>();
        }
    
        public int IDCATEGORIA { get; set; }
        public string NBRCATEGORIA { get; set; }
    
        public virtual ICollection<PREGUNTA> PREGUNTAs { get; set; }
    }
}
