using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminLTEv2.Models;

namespace AdminLTEv2.Controllers
{
    public class UsuarioController : Controller
    {
        //
        // GET: /Usuario/

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult metodoAjax()
        {
            ViewBag.mensaje = "mensajitoS";
            List<Usuario> list = new List<Usuario>();
            Usuario objusu = new Usuario();
            objusu.nombres = "david";
            Usuario objusu2 = new Usuario();
            objusu2.nombres = "jose";
            list.Add(objusu);
            list.Add(objusu2);
            return PartialView("_midiv",list);
        }

    }
}
