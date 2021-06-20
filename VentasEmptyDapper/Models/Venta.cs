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
        public Guid ID { get; set; }
        
        // no se escribe ni se actauliza es generado por la base de datos
        [Write(false)]
        [Computed]
        public int CodigoFactura { get; set; }
        public string IDCliente { get; set; }
        
        public string IDColaborador { get; set; }
        public int IDTipoVenta { get; set; }

        public float Prima { get; set; }

        public int Cuotas { get; set; }

        [Write(false)]
        [Computed]
        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        [Write(false)]
        [Computed]
        public int CodigoVenta { get; set; }
        
        
        // propiedades con que no son parte de la tabla en la BDD
        

        [Write(false)]
        [Computed]
        public Cliente Cliente { get; set; }
        
        [Write(false)]
        [Computed]
        public Colaboradores Colaborador { get; set; }

        [Write(false)]
        [Computed]
        public IEnumerable<DetalleVenta> DetallesVenta { get; set; }


        public Venta()
        {
            // inicializar valores nulos
        }


    }
}
