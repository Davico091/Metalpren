using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminLTEv2.Controllers
{
    public class pruebaController : Controller
    {
        //
        // GET: /prueba/

        public ActionResult Index()
        {
            return View("~/index.cshtml");
        }

    }
}
