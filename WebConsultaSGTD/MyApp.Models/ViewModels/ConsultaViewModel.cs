using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models.ViewModels
{
  public  class ConsultaViewModel
    {
        [Required]
        [Display(Name = "Nro Expediente")]
        public string NroExpediente { get; set; }

        [Required]
        [Display(Name = "Clave Web")]
        public string ClaveWeb { get; set; }
        [Required]
        public bool Captcha { get; set; }


    }
}
