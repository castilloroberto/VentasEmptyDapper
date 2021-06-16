using System;
using System.Collections.Generic;
using System.Text;
using VentasEmptyDapper.Models;

namespace VentasEmptyDapper.Controller
{
    public class VentaController : ConnectionController
    {
        public bool InsertVenta(Venta venta)
        {
            var db = Connection;
            db.insert
        }
        public bool SaveVenta( Venta venta)
        {
            ClienteController clienteController = new ClienteController();

            var db = Connection;
            //verificar que el cliente este registrado
            bool cliente = clienteController.SaveCliente(venta.Cliente);
            if (cliente)
            {

                if (venta.Id == Guid.Empty)
                {
                    //insert
                    venta.Id = Guid.NewGuid();
                    InsertVenta(venta);
                    // insertar los sus detalles de venta luego de crear la venta

                }
                else
                {
                    //update
                }
            }
        }  

    }
}
