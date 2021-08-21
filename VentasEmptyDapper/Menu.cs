
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VentasEmptyDapper.Controller;
using VentasEmptyDapper.Models;
using VentasEmptyDapper.Views;
using System.Threading.Tasks;


namespace MasterDetailDapper
{
    public partial class Menu : Form
    {
        private List<Button> botones = new List<Button>();

        public object InventarioView { get; private set; }

        public Menu()
        {
            InitializeComponent();
            botones.Add(btn_colaboradores);
            botones.Add(btn_inventario);
            botones.Add(btn_ventasContado);
            botones.Add(btn_ventasCredito);
            Seleccionar(btn_ventasContado);
            VentaAlContadoView ventaAlContadoView = new VentaAlContadoView();
            mainPanel.Controls.Add(ventaAlContadoView);


        }
       
        private void ResetButtons()
        {
            foreach (Button boton in botones)
            {
                boton.BackColor = BackColor;
                boton.ForeColor = Color.Black;
            }
        }
        private void btn_ventasContado_Click(object sender, EventArgs e)
        {
            Seleccionar(btn_ventasContado);
            VentaAlContadoView ventaAlContadoView = new VentaAlContadoView();
            mainPanel.Controls.Add(ventaAlContadoView);
        }

        private void btn_ventasCredito_Click(object sender, EventArgs e)
        {
            Seleccionar(btn_ventasCredito);

        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            Seleccionar(btn_inventario);
            InvetarioView cs = new InvetarioView();
            mainPanel.Controls.Add(cs);

        }

        private void btn_colaboradores_Click(object sender, EventArgs e)
        {
            Seleccionar(btn_colaboradores);

        }

        private void Seleccionar(Button btn)
        {
            ResetButtons();
            btn.BackColor = Color.FromName("dodgerblue");
            btn.ForeColor = Color.FromName("white");
            mainPanel.Controls.Clear();

        }
    }
}
