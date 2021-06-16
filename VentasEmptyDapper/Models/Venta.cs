using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace VentasEmptyDapper.Models
{
    [Table("Ventas")]
    public class Venta
    {
        [ExplicitKey]
        public Guid Id { get; set; }
        
        public string IdCliente { get; set; }
        
        public string IdColaborador { get; set; }
        public string TipoVenta { get; set; }

        
        [Write(false)]
        [Computed]
        public DateTime Fecha { get; set; }

        [Write(false)]
        [Computed]
        public int CodigoVenta { get; set; }
        
        
        // propiedades con que no son parte de la tabla en la BDD
        

        [Write(false)]
        [Computed]
        public Cliente Cliente { get; set; }
        
        [Write(false)]
        [Computed]
        public Colaborador Colaborador { get; set; }

        [Write(false)]
        [Computed]
        public IEnumerable<DetalleVenta> DetallesVenta { get; set; }


    }
}
