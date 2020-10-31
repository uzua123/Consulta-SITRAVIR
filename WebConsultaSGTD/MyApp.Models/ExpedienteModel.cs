using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class ExpedienteModel
    {
        public int IDEXPEDIENTE { get; set; }
        public Nullable<short> AÑO { get; set; }
        public string TIPO { get; set; }
        public Nullable<int> IDTIPO_DOCUMENTO { get; set; }
        public string NRO_DOCUMENTO { get; set; }
        public System.DateTime FEC_RECEPCION { get; set; }
        public Nullable<int> IDSOLICITANTE { get; set; }
        public string ASUNTO { get; set; }
        public int FOLIOS { get; set; }
        public string OBSERVACION { get; set; }
        public string CLAVE_WEB { get; set; }
        public string NRO_EXPEDIENTE { get; set; }
        public string IDESTADO { get; set; }
        public virtual ICollection<DetalleExpedienteModel> TBL_DET_EXPEDIENTE { get; set; }
        public virtual PersonaModel TBL_PERSONA { get; set; }
        public virtual TipoDocumentoModel TBL_TIPO_DOCUMENTO { get; set; }
    }
}
