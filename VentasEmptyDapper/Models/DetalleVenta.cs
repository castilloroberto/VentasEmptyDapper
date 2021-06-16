using System;
using System.Collections.Generic;
using System.Text;

namespace VentasEmptyDapper.Models
{
    public class DetalleVenta
    {
        public Guid IdVenta { get; set; }
        public Productos Producto { get; set; }


    }
}
