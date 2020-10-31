using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class TupaModel
    {
        public int IDTUPA { get; set; }
        public string TUPA { get; set; }
        public int DIAS { get; set; }
        public string TIPO_DIA { get; set; }
        public Nullable<int> IDOFICINA { get; set; }
        public Nullable<int> FLGESTADO { get; set; }

        public virtual OficinaModel TBL_OFICINA { get; set; }
        public virtual ICollection<TupaRequisitoModel> TBL_TUPA_REQUISITO { get; set; }

    }
}
