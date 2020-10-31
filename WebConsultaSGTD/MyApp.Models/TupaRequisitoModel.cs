using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class TupaRequisitoModel
    {
        public int IDTUPA_REQUISITO { get; set; }
        public Nullable<int> IDTUPA { get; set; }
        public Nullable<int> IDREQUISITO { get; set; }

        public virtual Requisitomodel TBL_REQUISITO { get; set; }
        public virtual TupaModel TBL_TUPA { get; set; }
    }
}
