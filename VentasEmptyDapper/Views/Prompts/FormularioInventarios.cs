using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VentasEmptyDapper.Controller;
using VentasEmptyDapper.Models;

namespace SuMueble
{
    public partial class FormularioInventarios : Form
    {

        CategoriaController categoriaController = new CategoriaController();
        ProductoController productoController = new ProductoController(); 
        public FormularioInventarios()
        {
            InitializeComponent();
            cb_categorias.DataSource = categoriaController.GetCategorias();
            cb_categorias.ValueMember = "ID";
            cb_categorias.DisplayMember = "Categoria";
        }

        private void btn_Hecho_Click(object sender, EventArgs e)
        {
            Productos p = new Productos()
            {
                Codigo = txt_codigo.Text,
                Producto = txt_producto.Text,
                Existencias = int.Parse(txt_existencias.Text),
                IDCategoria = cb_categorias.SelectedValue.GetHashCode(),
                PrecioUnitario = float.Parse(txt_precio.Text)
            };

            productoController.InsertProducto(p);
            this.Close();
        }
    }
}
