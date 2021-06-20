using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using VentasEmptyDapper.Models;

namespace VentasEmptyDapper.Controller
{
    public class VentaController : ConnectionController
    {
        private bool InsertVenta(Venta venta)
        {
            using (var db = Connection)
            {
                
                return db.Insert(venta) > 0;
            }
        }
        public bool SaveVenta( Venta venta)
        {
            ClienteController clienteController = new ClienteController();

            //verificar que el cliente este registrado
            bool ok = clienteController.SaveCliente(venta.Cliente);
            if (ok)
            {

                if (venta.ID == Guid.Empty)
                {
                    //insert
                    venta.ID = Guid.NewGuid();
                    ok = InsertVenta(venta);
                    // insertar los sus detalles de venta luego de crear la venta

                }
                else
                {
                    //update
                    ok = Update(venta);
                }
            }
            return ok;
        }

        private bool Update(Venta venta)
        {
            using (var db = Connection)
            {
                return db.Update(venta);
            }
        }
    }
}
