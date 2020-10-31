using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class OficinaModel
    {
        public int IDOFICINA { get; set; }
        public string OFICINA { get; set; }
        public string SIGLA { get; set; }
        public string SIGLA_DOC { get; set; }
        public Nullable<int> FLGESTADO { get; set; }
        public Nullable<int> USU_CREACION { get; set; }
        public Nullable<System.DateTime> FEC_CREACION { get; set; }
        public Nullable<int> USU_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FEC_MODIFICACION { get; set; }
        public virtual ICollection<DetalleExpedienteModel> TBL_DET_EXPEDIENTE { get; set; }
        public virtual ICollection<DetalleExpedienteModel> TBL_DET_EXPEDIENTE1 { get; set; }
        public virtual ICollection<EmpleadoModel> TBL_EMPLEADO { get; set; }
        public virtual ICollection<TupaModel> TBL_TUPA { get; set; }
    }
}
