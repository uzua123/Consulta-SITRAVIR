using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Threading.Tasks;
using MyApp.Models;

namespace MyApp.DB.DbOperations
{
  public  class ConsultaOperation
    {
        #region SINGLETON
            private static ConsultaOperation _expedienteService = null;
            private ConsultaOperation() { }
            public static ConsultaOperation getInstancia()
            {
                if (_expedienteService == null)
                {
                    _expedienteService = new ConsultaOperation();

                }
                return _expedienteService;
            }

        #endregion

        public async Task<TBL_EXPEDIENTE> SearchNroExpediente(string _id, string _clave)
        {
            TBL_EXPEDIENTE model = new TBL_EXPEDIENTE();
            using (var db = new DBSTDEntities())
            {
                model = await db.TBL_EXPEDIENTE.
                                   Include(e => e.TBL_PERSONA).
                                   Include(e => e.TBL_TIPO_DOCUMENTO).
                                   Include(e => e.TBL_DET_EXPEDIENTE).
                                   Where(e => e.NRO_EXPEDIENTE == _id).
                                   Where(e => e.CLAVE_WEB == _clave).

                                   FirstOrDefaultAsync();

                if (model != null)
                {
                    return model;
                }
                else
                {
                    return model;
                }

            }
        }

        public string GetOficina(int id)
        {
            string oficina = "";

            using (var db = new DBSTDEntities())
            {
                var dato = db.TBL_OFICINA.Where(d => d.IDOFICINA == id).FirstOrDefault();
                oficina = dato.OFICINA;
            }

            return oficina;
        }
        #region Prueba
        //public ExpedienteModel SearchNroExpediente(string _id, string _clave)
        //{
        //    ExpedienteModel model = new ExpedienteModel();
        //    using (var db = new DBSTDEntities())
        //    {
        //        model = db.TBL_EXPEDIENTE
        //                .Select(exp => new ExpedienteModel()
        //                {
        //                    IDEXPEDIENTE = exp.IDEXPEDIENTE,
        //                    NRO_DOCUMENTO = exp.NRO_DOCUMENTO,
        //                    ASUNTO = exp.ASUNTO,
        //                    IDESTADO = exp.IDESTADO,
        //                    FEC_RECEPCION = exp.FEC_RECEPCION,
        //                    TBL_TIPO_DOCUMENTO = new TipoDocumentoModel()
        //                    {
        //                        IDTIPO_DOCUMENTO = exp.TBL_TIPO_DOCUMENTO.IDTIPO_DOCUMENTO,
        //                        TIPODOCUMENTO = exp.TBL_TIPO_DOCUMENTO.TIPODOCUMENTO
        //                    },
        //                    TBL_PERSONA = new PersonaModel()
        //                    {
        //                        IDPERSONA = exp.TBL_PERSONA.IDPERSONA,
        //                        NOMBRE = exp.TBL_PERSONA.NOMBRE,
        //                        DNI = exp.TBL_PERSONA.DNI,
        //                        RUC = exp.TBL_PERSONA.RUC,
        //                        CELULAR = exp.TBL_PERSONA.CELULAR,
        //                        CORREO = exp.TBL_PERSONA.CORREO,
        //                        DIRECCION = exp.TBL_PERSONA.DIRECCION
        //                    }

        //                }).FirstOrDefault();

        //        if (model != null)
        //        {
        //            return model;
        //        }
        //        else
        //        {
        //            return model;
        //        }

        //    }
        //}
        //public string GetOficina(int id)
        //{
        //    string oficina = "";

        //    using (var db = new DBSTDEntities())
        //    {
        //        var dato = db.TBL_OFICINA.Where(d => d.IDOFICINA == id).FirstOrDefault();
        //        oficina = dato.OFICINA;
        //    }

        //    return oficina;
        //} 
        #endregion
    }
}
