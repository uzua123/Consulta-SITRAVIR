using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class UsuariosModel
    {
        public int IDUSUARIO { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDOS { get; set; }
        public string DNI { get; set; }
        public string EMAIL { get; set; }
        public string DIRECCION { get; set; }
        public string PASSWORD { get; set; }
        public Nullable<int> FLGESTADO { get; set; }
    }
}
