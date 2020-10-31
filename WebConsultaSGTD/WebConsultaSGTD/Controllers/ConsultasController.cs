using CaptchaMvc.HtmlHelpers;
using MyApp.DB.DbOperations;
using MyApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebConsultaSGTD.Controllers
{
    public class ConsultasController : Controller
    {
        
        // GET: Consultas
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Info(ConsultaViewModel model)
        {
            if (this.IsCaptchaValid(""))
            {
                if (!ModelState.IsValid)
                {
                    return View(nameof(ConsultasController.Index), model);
                }
                else
                {
                    Session["tiempo"] = 0;

                    var objCosulta = await ConsultaOperation.getInstancia().SearchNroExpediente(model.NroExpediente, model.ClaveWeb);
                    if (objCosulta != null)
                    {
                        Session["tiempo"] = GetTiempo();
                        TempData["msg"] = null;
                        return View(objCosulta);
                    }
                    else
                    {
                        TempData["msg"] = "No Existe registros con ese Nro Expediente";
                        return View();

                    }
                }

            }
            else
            {
                TempData["msg"] = "Captcha no valido.";
                
                return View(nameof(ConsultasController.Index), model);

            }

        }

        
        public int GetTiempo()
        {
            var actual = DateTime.Now;
            var minute = actual.Second-1;
            return minute;
        }
        //public bool Intentos()
        //{
        //    Session["retries"] = 3;
        //    if (Session["retries"] == null)
        //    {
        //        Session["retries"] = 0;
        //    }
        //    if (this.IsCaptchaValid(""))
        //    {
        //        if (!ModelState.IsValid)
        //        {
        //            return View("Index", model);
        //        }
        //        else
        //        {

        //            var objCosulta = objExpediente.SearchNroExpediente(model.NroExpediente, model.ClaveWeb);
        //            if (objCosulta != null)
        //            {
        //                TempData["msg"] = null;
        //                return /*Partial*/View(objCosulta);
        //            }
        //            else
        //            {
        //                TempData["msg"] = "No Existe registros con ese Nro Expediente";
        //                return /*Partial*/View();

        //                //Session["retries"] = Convert.ToInt32(Session["retries"])+1;
        //                //if (Convert.ToInt32(Session["retries"])==3)
        //                //{
        //                //    //model.ShowCaptcha = true;
        //                //    TempData["msg"] = "El Numero de Intentos superados";
        //                //    return /*Partial*/View();
        //                //}
        //            }
        //        }

        //    }
        //    else
        //    {
        //        TempData["msg"] = "Captcha no valido.";
        //        //return PartialView();
        //        return View("Index", model);
        //    }

        //}

    }
}