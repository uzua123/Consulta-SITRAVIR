using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class EmpleadoModel
    {
        public int IDEMPLEADO { get; set; }
        public string NOMBRE { get; set; }
        public string APEPATERNO { get; set; }
        public string APEMATERNO { get; set; }
        public string DNI { get; set; }
        public string DIRECCION { get; set; }
        public string CORREO { get; set; }
        public string CELULAR { get; set; }
        public Nullable<int> IDCARGO { get; set; }
        public Nullable<int> IDOFICINA { get; set; }
        public Nullable<System.DateTime> FEC_INGRESO { get; set; }
        public Nullable<System.DateTime> FEC_FINAL { get; set; }
        public string USUARIO { get; set; }
        public string PASSWORD { get; set; }
        public Nullable<bool> FLGESTADO { get; set; }
        public string FOTO { get; set; }

        public virtual CargoModel TBL_CARGO { get; set; }
        public virtual OficinaModel TBL_OFICINA { get; set; }
    }
}
