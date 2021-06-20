
namespace MasterDetailDapper
{
    partial class Menu
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_colaboradores = new System.Windows.Forms.Button();
            this.btn_inventario = new System.Windows.Forms.Button();
            this.btn_ventasCredito = new System.Windows.Forms.Button();
            this.btn_ventasContado = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.menuPanel.Controls.Add(this.panel2);
            this.menuPanel.Controls.Add(this.panel1);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(250, 763);
            this.menuPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.btn_colaboradores);
            this.panel2.Controls.Add(this.btn_inventario);
            this.panel2.Controls.Add(this.btn_ventasCredito);
            this.panel2.Controls.Add(this.btn_ventasContado);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 577);
            this.panel2.TabIndex = 2;
            // 
            // btn_colaboradores
            // 
            this.btn_colaboradores.BackColor = System.Drawing.SystemColors.Control;
            this.btn_colaboradores.FlatAppearance.BorderSize = 0;
            this.btn_colaboradores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_colaboradores.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_colaboradores.Location = new System.Drawing.Point(0, 192);
            this.btn_colaboradores.Name = "btn_colaboradores";
            this.btn_colaboradores.Size = new System.Drawing.Size(250, 58);
            this.btn_colaboradores.TabIndex = 0;
            this.btn_colaboradores.Text = "Colaboradores";
            this.btn_colaboradores.UseVisualStyleBackColor = false;
            this.btn_colaboradores.Click += new System.EventHandler(this.btn_colaboradores_Click);
            // 
            // btn_inventario
            // 
            this.btn_inventario.BackColor = System.Drawing.SystemColors.Control;
            this.btn_inventario.FlatAppearance.BorderSize = 0;
            this.btn_inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventario.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_inventario.Location = new System.Drawing.Point(0, 128);
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Size = new System.Drawing.Size(250, 58);
            this.btn_inventario.TabIndex = 0;
            this.btn_inventario.Text = "Inventario";
            this.btn_inventario.UseVisualStyleBackColor = false;
            this.btn_inventario.Click += new System.EventHandler(this.btn_inventario_Click);
            // 
            // btn_ventasCredito
            // 
            this.btn_ventasCredito.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ventasCredito.FlatAppearance.BorderSize = 0;
            this.btn_ventasCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ventasCredito.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ventasCredito.Location = new System.Drawing.Point(0, 64);
            this.btn_ventasCredito.Name = "btn_ventasCredito";
            this.btn_ventasCredito.Size = new System.Drawing.Size(250, 58);
            this.btn_ventasCredito.TabIndex = 0;
            this.btn_ventasCredito.Text = "Ventas Al Credito";
            this.btn_ventasCredito.UseVisualStyleBackColor = false;
            this.btn_ventasCredito.Click += new System.EventHandler(this.btn_ventasCredito_Click);
            // 
            // btn_ventasContado
            // 
            this.btn_ventasContado.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ventasContado.FlatAppearance.BorderSize = 0;
            this.btn_ventasContado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ventasContado.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ventasContado.Location = new System.Drawing.Point(0, 0);
            this.btn_ventasContado.Name = "btn_ventasContado";
            this.btn_ventasContado.Size = new System.Drawing.Size(250, 58);
            this.btn_ventasContado.TabIndex = 0;
            this.btn_ventasContado.Text = "Ventas Al Contado";
            this.btn_ventasContado.UseVisualStyleBackColor = false;
            this.btn_ventasContado.Click += new System.EventHandler(this.btn_ventasContado_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 186);
            this.panel1.TabIndex = 1;
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.logo.Location = new System.Drawing.Point(42, 46);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(180, 46);
            this.logo.TabIndex = 0;
            this.logo.Text = "Su Mueble";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(250, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1502, 763);
            this.mainPanel.TabIndex = 1;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1752, 763);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "Menu";
            this.Text = "Form1";
            this.menuPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ventasContado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_colaboradores;
        private System.Windows.Forms.Button btn_inventario;
        private System.Windows.Forms.Button btn_ventasCredito;
    }
}

