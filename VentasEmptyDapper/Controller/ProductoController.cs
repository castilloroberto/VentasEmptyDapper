using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using VentasEmptyDapper.Models;

namespace VentasEmptyDapper.Controller
{
    public class ProductoController : ConnectionController
    {

        public IEnumerable<Productos> GetProductos()
        {
            using (var db = Connection)
            {
                return db.GetAll<Productos>();
            }
        }


        public bool InsertProducto(Productos p)
        {
            using (var db = Connection)
            {
                return db.Insert(p) > 0;
            }
        }
    }
}
