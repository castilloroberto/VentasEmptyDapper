
namespace VentasEmptyDapper.Views
{
    partial class InvetarioView
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.producto,
            this.precio,
            this.existencias});
            this.dgv_productos.Location = new System.Drawing.Point(200, 170);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.RowHeadersWidth = 51;
            this.dgv_productos.RowTemplate.Height = 29;
            this.dgv_productos.Size = new System.Drawing.Size(877, 382);
            this.dgv_productos.TabIndex = 0;
            // 
            // btn_insertar
            // 
            this.btn_insertar.Location = new System.Drawing.Point(935, 654);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(94, 29);
            this.btn_insertar.TabIndex = 1;
            this.btn_insertar.Text = "Insertar";
            this.btn_insertar.UseVisualStyleBackColor = true;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "Codigo";
            this.codigo.HeaderText = "Codigo";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 125;
            // 
            // producto
            // 
            this.producto.DataPropertyName = "Producto";
            this.producto.HeaderText = "Producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Width = 125;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "PrecioUnitario";
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 125;
            // 
            // existencias
            // 
            this.existencias.DataPropertyName = "Existencias";
            this.existencias.HeaderText = "Existencias";
            this.existencias.MinimumWidth = 6;
            this.existencias.Name = "existencias";
            this.existencias.ReadOnly = true;
            this.existencias.Width = 125;
            // 
            // InvetarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_insertar);
            this.Controls.Add(this.dgv_productos);
            this.Name = "InvetarioView";
            this.Size = new System.Drawing.Size(1344, 813);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencias;
    }
}
