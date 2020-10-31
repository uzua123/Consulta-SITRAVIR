using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class TipoDocumentoModel
    {
        public int IDTIPO_DOCUMENTO { get; set; }
        public string TIPODOCUMENTO { get; set; }
        public string SIGLA { get; set; }
        public Nullable<int> FLGESTADO { get; set; }
        public virtual ICollection<ExpedienteModel> TBL_EXPEDIENTE { get; set; }

    }
}
