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
    
    public partial class TBL_PERFIL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_PERFIL()
        {
            this.TBL_PERMISOS = new HashSet<TBL_PERMISOS>();
        }
    
        public int IDPERFIL { get; set; }
        public string PERFIL { get; set; }
        public string OBSERVACION { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_PERMISOS> TBL_PERMISOS { get; set; }
    }
}
