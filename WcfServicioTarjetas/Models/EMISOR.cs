//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServicioTarjetas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EMISOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMISOR()
        {
            this.TARJETA = new HashSet<TARJETA>();
        }
    
        public int EMI_CODIGO { get; set; }
        public string EMI_DESCRIPCION { get; set; }
        public string EMI_PREFIJO { get; set; }
        public int EMI_NUMERO_DIGITOS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TARJETA> TARJETA { get; set; }
    }
}
