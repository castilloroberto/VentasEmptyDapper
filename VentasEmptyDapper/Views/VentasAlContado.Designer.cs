
namespace MasterDetailDapper
{
    partial class VentasAlContado
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.lb_productosVenta = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dniColaborador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dniCliente = new System.Windows.Forms.TextBox();
            this.txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_tipoventa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_buscarProducto = new System.Windows.Forms.TextBox();
            this.btn_agregarProducto = new System.Windows.Forms.Button();
            this.btn_terminarVenta = new System.Windows.Forms.Button();
            this.l_monto = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cantidadProducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.dniColaboradorLabelError = new System.Windows.Forms.Label();
            this.labelClienteNuevo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.producto,
            this.precio,
            this.existencias});
            this.dgv_productos.Location = new System.Drawing.Point(158, 257);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.RowHeadersWidth = 51;
            this.dgv_productos.RowTemplate.Height = 29;
            this.dgv_productos.Size = new System.Drawing.Size(857, 365);
            this.dgv_productos.TabIndex = 0;
            this.dgv_productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellClick);
            // 
            // lb_productosVenta
            // 
            this.lb_productosVenta.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_productosVenta.FormattingEnabled = true;
            this.lb_productosVenta.ItemHeight = 20;
            this.lb_productosVenta.Location = new System.Drawing.Point(1078, 257);
            this.lb_productosVenta.Name = "lb_productosVenta";
            this.lb_productosVenta.Size = new System.Drawing.Size(513, 364);
            this.lb_productosVenta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1078, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resumen Venta";
            // 
            // txt_dniColaborador
            // 
            this.txt_dniColaborador.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_dniColaborador.Location = new System.Drawing.Point(1368, 96);
            this.txt_dniColaborador.Name = "txt_dniColaborador";
            this.txt_dniColaborador.PlaceholderText = "Numero de Identidad...";
            this.txt_dniColaborador.Size = new System.Drawing.Size(223, 34);
            this.txt_dniColaborador.TabIndex = 3;
            this.txt_dniColaborador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_dniColaborador_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1360, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI Colaborador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(152, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "DNI Cliente";
            // 
            // txt_dniCliente
            // 
            this.txt_dniCliente.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_dniCliente.Location = new System.Drawing.Point(158, 96);
            this.txt_dniCliente.MaxLength = 13;
            this.txt_dniCliente.Name = "txt_dniCliente";
            this.txt_dniCliente.PlaceholderText = "Numero de Identidad...";
            this.txt_dniCliente.Size = new System.Drawing.Size(223, 34);
            this.txt_dniCliente.TabIndex = 3;
            this.txt_dniCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_dniCliente_KeyUp);
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nombreCliente.Location = new System.Drawing.Point(420, 96);
            this.txt_nombreCliente.MaxLength = 255;
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.PlaceholderText = "Nombre y Apellidos...";
            this.txt_nombreCliente.Size = new System.Drawing.Size(325, 34);
            this.txt_nombreCliente.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(417, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre Cliente";
            // 
            // cb_tipoventa
            // 
            this.cb_tipoventa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipoventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_tipoventa.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_tipoventa.FormattingEnabled = true;
            this.cb_tipoventa.Location = new System.Drawing.Point(789, 198);
            this.cb_tipoventa.Name = "cb_tipoventa";
            this.cb_tipoventa.Size = new System.Drawing.Size(223, 36);
            this.cb_tipoventa.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(789, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tipo Venta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(155, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "Buscar Producto";
            // 
            // txt_buscarProducto
            // 
            this.txt_buscarProducto.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_buscarProducto.Location = new System.Drawing.Point(158, 200);
            this.txt_buscarProducto.Name = "txt_buscarProducto";
            this.txt_buscarProducto.PlaceholderText = "Nombre o Codigo de Producto...";
            this.txt_buscarProducto.Size = new System.Drawing.Size(223, 34);
            this.txt_buscarProducto.TabIndex = 3;
            // 
            // btn_agregarProducto
            // 
            this.btn_agregarProducto.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_agregarProducto.FlatAppearance.BorderSize = 0;
            this.btn_agregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarProducto.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarProducto.ForeColor = System.Drawing.Color.White;
            this.btn_agregarProducto.Location = new System.Drawing.Point(824, 657);
            this.btn_agregarProducto.Name = "btn_agregarProducto";
            this.btn_agregarProducto.Size = new System.Drawing.Size(191, 37);
            this.btn_agregarProducto.TabIndex = 5;
            this.btn_agregarProducto.Text = "Agregar a la Venta";
            this.btn_agregarProducto.UseVisualStyleBackColor = false;
            this.btn_agregarProducto.Click += new System.EventHandler(this.btn_agregarProducto_Click);
            // 
            // btn_terminarVenta
            // 
            this.btn_terminarVenta.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_terminarVenta.FlatAppearance.BorderSize = 0;
            this.btn_terminarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_terminarVenta.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_terminarVenta.ForeColor = System.Drawing.Color.White;
            this.btn_terminarVenta.Location = new System.Drawing.Point(1400, 657);
            this.btn_terminarVenta.Name = "btn_terminarVenta";
            this.btn_terminarVenta.Size = new System.Drawing.Size(191, 37);
            this.btn_terminarVenta.TabIndex = 5;
            this.btn_terminarVenta.Text = "Terminar Venta";
            this.btn_terminarVenta.UseVisualStyleBackColor = false;
            this.btn_terminarVenta.Click += new System.EventHandler(this.btn_terminarVenta_Click);
            // 
            // l_monto
            // 
            this.l_monto.AutoSize = true;
            this.l_monto.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_monto.Location = new System.Drawing.Point(1426, 202);
            this.l_monto.Name = "l_monto";
            this.l_monto.Size = new System.Drawing.Size(165, 32);
            this.l_monto.TabIndex = 2;
            this.l_monto.Text = "Lps. 000,000.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(436, 629);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "Cantidad Producto";
            // 
            // txt_cantidadProducto
            // 
            this.txt_cantidadProducto.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cantidadProducto.Location = new System.Drawing.Point(439, 660);
            this.txt_cantidadProducto.MaxLength = 100;
            this.txt_cantidadProducto.Name = "txt_cantidadProducto";
            this.txt_cantidadProducto.PlaceholderText = "Cantidad...";
            this.txt_cantidadProducto.Size = new System.Drawing.Size(223, 34);
            this.txt_cantidadProducto.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(156, 629);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 28);
            this.label9.TabIndex = 2;
            this.label9.Text = "Precio Producto";
            // 
            // txt_precio
            // 
            this.txt_precio.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_precio.Location = new System.Drawing.Point(159, 660);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.PlaceholderText = "Precio Sugerido...";
            this.txt_precio.Size = new System.Drawing.Size(223, 34);
            this.txt_precio.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(789, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Telefono Cliente";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_telefono.Location = new System.Drawing.Point(792, 96);
            this.txt_telefono.MaxLength = 8;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.PlaceholderText = "Escriba Aqui...";
            this.txt_telefono.Size = new System.Drawing.Size(223, 34);
            this.txt_telefono.TabIndex = 3;
            // 
            // dniColaboradorLabelError
            // 
            this.dniColaboradorLabelError.AutoSize = true;
            this.dniColaboradorLabelError.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dniColaboradorLabelError.ForeColor = System.Drawing.Color.Crimson;
            this.dniColaboradorLabelError.Location = new System.Drawing.Point(1368, 133);
            this.dniColaboradorLabelError.Name = "dniColaboradorLabelError";
            this.dniColaboradorLabelError.Size = new System.Drawing.Size(129, 20);
            this.dniColaboradorLabelError.TabIndex = 2;
            this.dniColaboradorLabelError.Text = "Escribio mal su DNI";
            this.dniColaboradorLabelError.Visible = false;
            // 
            // labelClienteNuevo
            // 
            this.labelClienteNuevo.AutoSize = true;
            this.labelClienteNuevo.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClienteNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.labelClienteNuevo.Location = new System.Drawing.Point(158, 133);
            this.labelClienteNuevo.Name = "labelClienteNuevo";
            this.labelClienteNuevo.Size = new System.Drawing.Size(98, 20);
            this.labelClienteNuevo.TabIndex = 2;
            this.labelClienteNuevo.Text = "Cliente Nuevo";
            this.labelClienteNuevo.Visible = false;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.labelNombre.Location = new System.Drawing.Point(420, 133);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(66, 20);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Ingresar...";
            this.labelNombre.Visible = false;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.labelTelefono.Location = new System.Drawing.Point(792, 133);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(66, 20);
            this.labelTelefono.TabIndex = 2;
            this.labelTelefono.Text = "Ingresar...";
            this.labelTelefono.Visible = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // producto
            // 
            this.producto.DataPropertyName = "Producto";
            this.producto.HeaderText = "Producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Width = 300;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "Precio";
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1752, 763);
            this.Controls.Add(this.btn_terminarVenta);
            this.Controls.Add(this.btn_agregarProducto);
            this.Controls.Add(this.cb_tipoventa);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_nombreCliente);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_cantidadProducto);
            this.Controls.Add(this.txt_buscarProducto);
            this.Controls.Add(this.txt_dniCliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_dniColaborador);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelClienteNuevo);
            this.Controls.Add(this.dniColaboradorLabelError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l_monto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_productosVenta);
            this.Controls.Add(this.dgv_productos);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.ListBox lb_productosVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_dniColaborador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dniCliente;
        private System.Windows.Forms.TextBox txt_nombreCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_tipoventa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_buscarProducto;
        private System.Windows.Forms.Button btn_agregarProducto;
        private System.Windows.Forms.Button btn_terminarVenta;
        private System.Windows.Forms.Label l_monto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_cantidadProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label dniColaboradorLabelError;
        private System.Windows.Forms.Label labelClienteNuevo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencias;
    }
}

