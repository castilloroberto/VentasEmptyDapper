
namespace SuMueble
{
    partial class FormularioInventarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Hecho = new System.Windows.Forms.Button();
            this.cb_categorias = new System.Windows.Forms.ComboBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.txt_existencias = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(382, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(57, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(382, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Existencias";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(57, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoría";
            // 
            // btn_Hecho
            // 
            this.btn_Hecho.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Hecho.FlatAppearance.BorderSize = 0;
            this.btn_Hecho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hecho.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Hecho.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Hecho.Location = new System.Drawing.Point(501, 421);
            this.btn_Hecho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Hecho.Name = "btn_Hecho";
            this.btn_Hecho.Size = new System.Drawing.Size(150, 37);
            this.btn_Hecho.TabIndex = 5;
            this.btn_Hecho.Text = "Hecho";
            this.btn_Hecho.UseVisualStyleBackColor = false;
            this.btn_Hecho.Click += new System.EventHandler(this.btn_Hecho_Click);
            // 
            // cb_categorias
            // 
            this.cb_categorias.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_categorias.FormattingEnabled = true;
            this.cb_categorias.Location = new System.Drawing.Point(57, 340);
            this.cb_categorias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_categorias.Name = "cb_categorias";
            this.cb_categorias.Size = new System.Drawing.Size(269, 36);
            this.cb_categorias.TabIndex = 6;
            // 
            // txt_precio
            // 
            this.txt_precio.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_precio.Location = new System.Drawing.Point(57, 213);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(269, 34);
            this.txt_precio.TabIndex = 7;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_codigo.Location = new System.Drawing.Point(57, 89);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(269, 34);
            this.txt_codigo.TabIndex = 8;
            // 
            // txt_producto
            // 
            this.txt_producto.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_producto.Location = new System.Drawing.Point(382, 89);
            this.txt_producto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(269, 34);
            this.txt_producto.TabIndex = 9;
            // 
            // txt_existencias
            // 
            this.txt_existencias.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_existencias.Location = new System.Drawing.Point(382, 213);
            this.txt_existencias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_existencias.Name = "txt_existencias";
            this.txt_existencias.Size = new System.Drawing.Size(269, 34);
            this.txt_existencias.TabIndex = 10;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.White;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancelar.Location = new System.Drawing.Point(57, 421);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(150, 37);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // FormularioInventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(708, 524);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.txt_existencias);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.cb_categorias);
            this.Controls.Add(this.btn_Hecho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormularioInventarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Hecho;
        private System.Windows.Forms.ComboBox cb_categorias;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.TextBox txt_existencias;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}