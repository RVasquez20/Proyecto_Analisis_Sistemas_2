using System;
using System.Collections.Generic;

namespace APICLIENTES.Models
{
    public partial class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Nit { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public DateTime? FechaIngreso { get; set; }
    }
}
