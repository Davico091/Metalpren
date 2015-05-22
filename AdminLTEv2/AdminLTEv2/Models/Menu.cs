using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminLTEv2.Models
{
    public class Menu
    {
        public int MenuId { get; set; }
        public string Descripcion { get; set; }
        public string Controlador { get; set; }
        public string Accion { get; set; }
        public int Nivel { get; set; }
        public decimal orden { get; set; }

        public List<Menu> listaSubMenues { get; set; }
    }
}