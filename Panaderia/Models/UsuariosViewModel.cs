using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Panaderia.Models
{
    public class UsuariosViewModel
    {
        public int id_usuario { get; set; }
        
        [Display(Name = "Nombre")]
        public string nombre { get; set; }
        
        [Display(Name = "Apellidos")]
        public string apellido { get; set; }
        
        [Display(Name = "Direccion")]
        public string direccion { get; set; }
        
        [Display(Name = "Email")]
        public string email { get; set; }
        
        [Display(Name ="Usuario")]
        public string users { get; set; }
        
        [Display(Name = "Contraseña")]
        public string pass { get; set; }

        
        public int id_rol { get; set; }
        [Display(Name = "Rol")]
        public string rol { get; set; }
    }
}