using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class PersonaModel
    {
        public int IDPERSONA { get; set; }
        public string TIPO { get; set; }
        public string NOMBRE { get; set; }
        public string APEPATERNO { get; set; }
        public string APEMATERNO { get; set; }
        public string DNI { get; set; }
        public string RUC { get; set; }
        public string DIRECCION { get; set; }
        public string CORREO { get; set; }
        public string CELULAR { get; set; }
        public Nullable<int> USU_CREACION { get; set; }
        public Nullable<System.DateTime> FEC_CREACION { get; set; }
        public Nullable<int> USU_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FEC_MODIFICACION { get; set; }

        public virtual ICollection<ExpedienteModel> TBL_EXPEDIENTE { get; set; }
        public virtual ICollection<SolicitanteModel> TBL_SOLICITANTE { get; set; }

    }
}
