﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebConsultaSGTD.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        [Route("")]
        public ActionResult GenericError()
        {
            return View("GenericError");
        }
        [Route("InternalError")]
        public ActionResult InternalError()
        {
            return View("InternalError");
        }
        [Route("NotFound")]
        public ActionResult NotFound()
        {
            return View("NotFound");
        }
        [Route("AccessDenied")]
        public ActionResult AccessDenied()
        {
            return View("AccessDenied");
        }
    }
}