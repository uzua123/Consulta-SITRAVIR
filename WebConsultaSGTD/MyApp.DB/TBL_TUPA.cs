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
    
    public partial class TBL_TUPA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_TUPA()
        {
            this.TBL_TUPA_REQUISITO = new HashSet<TBL_TUPA_REQUISITO>();
        }
    
        public int IDTUPA { get; set; }
        public string TUPA { get; set; }
        public int DIAS { get; set; }
        public string TIPO_DIA { get; set; }
        public Nullable<int> IDOFICINA { get; set; }
        public Nullable<bool> FLGESTADO { get; set; }
    
        public virtual TBL_OFICINA TBL_OFICINA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_TUPA_REQUISITO> TBL_TUPA_REQUISITO { get; set; }
    }
}
