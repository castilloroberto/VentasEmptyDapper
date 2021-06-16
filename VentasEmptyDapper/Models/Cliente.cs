using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace VentasEmptyDapper.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [ExplicitKey]
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string RTN { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }

    }
}
