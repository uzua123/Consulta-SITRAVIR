using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class DetalleExpedienteModel
    {
        public int IDDET_EXPEDIENTE { get; set; }
        public Nullable<int> IDEXPEDIENTE { get; set; }
        public Nullable<int> IDCORRELATIVO { get; set; }
        public Nullable<System.DateTime> FEC_RECEPCION { get; set; }
        public string OBS_RECEPCION { get; set; }
        public Nullable<System.DateTime> FEC_DERIVACION { get; set; }
        public string OBS_DERIVACION { get; set; }
        public string ESTADO { get; set; }
        public string DOC_ADJUNTADO { get; set; }
        public Nullable<int> IDREMITENTE_E { get; set; }
        public Nullable<int> IDREMITENTE_I { get; set; }
        public Nullable<int> IDDESTINO_E { get; set; }
        public Nullable<int> IDDESTINO_I { get; set; }
        public string TIPO { get; set; }
        public string PRIORIDAD { get; set; }
        public Nullable<System.DateTime> FEC_ENVIO { get; set; }
        public Nullable<System.DateTime> FEC_FINALIZAR { get; set; }
        public string OBS_FINALIZAR { get; set; }
        public Nullable<System.DateTime> FEC_ARCHIVAR { get; set; }
        public string OBS_ARCHIVAR { get; set; }
        public string UBIC_ARCHIVO { get; set; }
        public string USU_CREACION { get; set; }
        public Nullable<System.DateTime> FEC_CREACION { get; set; }

        public virtual OficinaModel TBL_OFICINA { get; set; }
        public virtual ExpedienteModel TBL_EXPEDIENTE { get; set; }
        public virtual OficinaModel TBL_OFICINA1 { get; set; }
    }
}
