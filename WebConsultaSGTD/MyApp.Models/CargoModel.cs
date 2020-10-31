using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
   public class CargoModel
    {
        public int IDCARGO { get; set; }
        public string CARGO { get; set; }
        public Nullable<int> FLGESTADO { get; set; }
        public Nullable<int> USU_CREACION { get; set; }
        public Nullable<System.DateTime> FEC_CREACION { get; set; }
        public Nullable<int> USU_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FEC_MODIFICACION { get; set; }

        public virtual ICollection<EmpleadoModel> TBL_EMPLEADO { get; set; }

    }
}
