using System;
using System.Collections.Generic;

namespace ApiNetPanaderia.Models
{
    public partial class Empleado
    {
        public int IdEmpleado { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Direccion { get; set; }
        public int? Telefono { get; set; }
        public int? Dpi { get; set; }
        public string? Genero { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public DateTime? FechaInicioLabores { get; set; }
        public DateTime? FechaIngreso { get; set; }
    }
}
