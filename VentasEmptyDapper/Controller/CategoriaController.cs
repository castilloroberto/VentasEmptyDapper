using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using VentasEmptyDapper.Models;

namespace VentasEmptyDapper.Controller
{
    public class CategoriaController : ConnectionController
    {

        public IEnumerable<Categorias> GetCategorias()
        {
            using (var db = Connection)
            {
                return db.GetAll<Categorias>();
            }
        }

    }
}
