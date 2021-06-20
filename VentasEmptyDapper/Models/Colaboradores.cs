using Dapper.Contrib.Extensions;
using System;

namespace VentasEmptyDapper.Models
{
 
    [Table("Colaboradores")]
    public class Colaboradores
    {
        [ExplicitKey]
        public string DNI { get; set; }
        public string RTN { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public int IDPuesto { get; set; }
        public string Direccion { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime Contratado { get; set; }

        [Computed]
        public DateTime FinContrato { get; set; }
        
        [Computed]
        public bool Estado { get; set; }

        

    }
}