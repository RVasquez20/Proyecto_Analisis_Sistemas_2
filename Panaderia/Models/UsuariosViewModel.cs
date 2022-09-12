using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Panaderia.Models
{
    public class UsuariosViewModel
    {
        public int id_usuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public string users { get; set; }
        public string pass { get; set; }
        public int id_rol { get; set; }
        public string rol { get; set; }
    }
}