using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class SolicitanteModel
    {
        public int IDSOLICITANTE { get; set; }
        public Nullable<int> IDPERSONA { get; set; }
        public Nullable<bool> FLGESTADO { get; set; }

        public virtual PersonaModel TBL_PERSONA { get; set; }
    }
}
