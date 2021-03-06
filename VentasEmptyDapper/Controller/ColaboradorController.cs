using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using VentasEmptyDapper.Models;

namespace VentasEmptyDapper.Controller
{
    public class ColaboradorController : ConnectionController
    {
        public Colaboradores GetColaborador(string DNI)
        {
            using (var db = Connection)
            {
                return db.Get<Colaboradores>(DNI);
            }
        }
    }
}
