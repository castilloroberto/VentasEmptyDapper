
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterDetailDapper
{
    public partial class VentasAlContado : Form
    {
        


        public VentasAlContado()
        {
            InitializeComponent();
            
           
        }
       private void FillDataGrid()
        {
           
        }
        private void btn_agregarProducto_Click(object sender, EventArgs e)
        {
            
        }
        private void AddDetalleVenta()
        {
           
        }
        private void ClearInputs()
        {
           
        }
       
        private string GetDgvCell(int i)
        {

            throw new NotImplementedException();
        }

        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_precio.Text = GetDgvCell(2);
           
        }

        private void txt_dniCliente_KeyUp(object sender, KeyEventArgs e)
        {
            
           
            
        }

        private void txt_dniColaborador_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void btn_terminarVenta_Click(object sender, EventArgs e)
        {
            
            
        }
        private void ClearVenta()
        {
           
        }
    }
}
