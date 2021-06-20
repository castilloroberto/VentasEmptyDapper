using SuMueble;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VentasEmptyDapper.Controller;

namespace VentasEmptyDapper.Views
{
    public partial class InvetarioView : UserControl
    {
        ProductoController productoController = new ProductoController();
        public InvetarioView()
        {
            InitializeComponent();
            dgv_productos.AutoGenerateColumns = false;
            cargardatos();
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            FormularioInventarios formularioInventarios = new FormularioInventarios();
            formularioInventarios.ShowDialog();
            cargardatos();

        }
        private void cargardatos()
        {
            dgv_productos.DataSource = productoController.GetProductos();
        }
    }
}
