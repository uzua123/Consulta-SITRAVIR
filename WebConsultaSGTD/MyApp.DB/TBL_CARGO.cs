//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyApp.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_CARGO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_CARGO()
        {
            this.TBL_EMPLEADO = new HashSet<TBL_EMPLEADO>();
        }
    
        public int IDCARGO { get; set; }
        public string CARGO { get; set; }
        public Nullable<bool> FLGESTADO { get; set; }
        public Nullable<int> USU_CREACION { get; set; }
        public Nullable<System.DateTime> FEC_CREACION { get; set; }
        public Nullable<int> USU_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FEC_MODIFICACION { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_EMPLEADO> TBL_EMPLEADO { get; set; }
    }
}
