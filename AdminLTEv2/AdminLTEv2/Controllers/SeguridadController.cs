using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminLTEv2.Models;
namespace AdminLTEv2.Controllers
{
    public class SeguridadController : Controller
    {
        //
        // GET: /Seguridad/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IniciarSesion(Usuario objUsuario)
        {
            MetalprenBDEntities mydb = new MetalprenBDEntities();
            List<Menu> listaPadre = new List<Menu>();

            Usuario objUsu = new Usuario();
            objUsu.user = objUsuario.user;
            objUsu.nombres = "David Perez Chate";
            objUsu.pass = "123";

            foreach (var reg in mydb.sp_MenuesxUsuario(1))
            {
                Menu objPadre = new Menu();
                objPadre.Descripcion = reg.Descripcion;
                List<Menu> listaHijo = new List<Menu>();
                foreach (var reg2 in mydb.sp_SubMenuesxUsuario(1, reg.MenuId))
                {
                    Menu objHijo = new Menu();
                    objHijo.Descripcion = reg2.Descripcion;
                    objHijo.Controlador = reg2.Controlador;
                    objHijo.Accion = reg2.Accion;
                    listaHijo.Add(objHijo);
                }
                objPadre.listaSubMenues = listaHijo;
                listaPadre.Add(objPadre);

            }

            Session["listaS"] = listaPadre;
            Session["objUsu"] = objUsu;

            return View(); 
        }

        public ActionResult cerrarSesion()
        {
            Session.Clear();
            return View(@"~\Views\Seguridad\Index.cshtml");
        }




    }
}
