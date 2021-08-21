using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VentasEmptyDapper.Controller;
using VentasEmptyDapper.Models;

namespace VentasEmptyDapper.Views
{
    public partial class VentaAlContadoView : UserControl
    {
        ColaboradorController colaboradorController = new ColaboradorController();
        ProductoController productoController = new ProductoController();

        public VentaAlContadoView()
        {
            InitializeComponent();
            CargarDatos();
        }
        private void CargarDatos()
        {
            dgv_productos.DataSource = productoController.GetProductos();

        }
        private void txt_dniColaborador_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_dniColaborador.Text.Length == 13)
            {

                Colaboradores colaborador = colaboradorController.GetColaborador(txt_dniColaborador.Text);
                if (colaborador != null)
                {
                    dniColaboradorLabelError.Visible = false;
                    txt_dniColaborador.Text = colaborador.DNI;

                }
                else
                {
                    dniColaboradorLabelError.Visible = true;
                }

            }
        }



        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_precio.Text = GetDgvCell(3);

        }

        private string GetDgvCell(int i = 0)
        {

            return dgv_productos.Rows[dgv_productos.CurrentRow.Index].Cells[i].Value.ToString();
        }
    }
}
