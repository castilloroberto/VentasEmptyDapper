using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using VentasEmptyDapper.Models;

namespace VentasEmptyDapper.Controller
{
    public class ClienteController : ConnectionController
    {
        public Cliente GetCliente(string DNI)
        {
            var db =  Connection;
            return db.Get<Cliente>(DNI);

        }
        public bool InsertCliente(Cliente cliente)
        {
            var db = Connection;
            return db.Insert<Cliente>(cliente) > 1;
        }
        public bool UpdateCliente(Cliente cliente)
        {
            var db = Connection;
            return db.Update<Cliente>(cliente);
        }       
        public bool SaveCliente(Cliente cliente)
        {
            Cliente clienteDB = GetCliente(cliente.DNI);
            bool res = false;
            if (clienteDB == null)
            {
                // insert
                res = InsertCliente(cliente);

            }
            else
            {
                //update
                res = UpdateCliente(cliente);
            }
            return res;
        }
    }
}
