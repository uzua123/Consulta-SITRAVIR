using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class Requisitomodel
    {
        public int IDREQUISITO { get; set; }
        public string REQUISITO { get; set; }
        public Nullable<int> FLGESTADO { get; set; }
        public Nullable<int> USU_CREACION { get; set; }
        public Nullable<System.DateTime> FEC_CREACION { get; set; }
        public Nullable<int> USU_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FEC_MODIFICACION { get; set; }
         public virtual ICollection<TupaRequisitoModel> TBL_TUPA_REQUISITO { get; set; }

    }
}
