namespace PresentacionesZapatos
{
    partial class FrmMenu
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
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.optPedidos = new System.Windows.Forms.ToolStripButton();
            this.optProduccion = new System.Windows.Forms.ToolStripButton();
            this.optCompras = new System.Windows.Forms.ToolStripButton();
            this.optInventario = new System.Windows.Forms.ToolStripButton();
            this.optAlmacen = new System.Windows.Forms.ToolStripButton();
            this.Ventas = new System.Windows.Forms.ToolStripButton();
            this.optSalir = new System.Windows.Forms.ToolStripButton();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optPedidos,
            this.optProduccion,
            this.optCompras,
            this.optInventario,
            this.optAlmacen,
            this.Ventas,
            this.optSalir});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(89, 316);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            // 
            // optPedidos
            // 
            this.optPedidos.BackColor = System.Drawing.Color.Bisque;
            this.optPedidos.Image = global::PresentacionesZapatos.Properties.Resources.hacer_un_pedido;
            this.optPedidos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optPedidos.Name = "optPedidos";
            this.optPedidos.Size = new System.Drawing.Size(86, 20);
            this.optPedidos.Text = "Pedidos";
            this.optPedidos.Click += new System.EventHandler(this.optPedidos_Click);
            // 
            // optProduccion
            // 
            this.optProduccion.BackColor = System.Drawing.Color.Gainsboro;
            this.optProduccion.Image = global::PresentacionesZapatos.Properties.Resources.transportador;
            this.optProduccion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optProduccion.Name = "optProduccion";
            this.optProduccion.Size = new System.Drawing.Size(86, 20);
            this.optProduccion.Text = "Producción";
            this.optProduccion.Click += new System.EventHandler(this.optProduccion_Click);
            // 
            // optCompras
            // 
            this.optCompras.BackColor = System.Drawing.Color.SeaShell;
            this.optCompras.Image = global::PresentacionesZapatos.Properties.Resources.caja;
            this.optCompras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optCompras.Name = "optCompras";
            this.optCompras.Size = new System.Drawing.Size(86, 20);
            this.optCompras.Text = "Compras";
            this.optCompras.Click += new System.EventHandler(this.optCompras_Click);
            // 
            // optInventario
            // 
            this.optInventario.BackColor = System.Drawing.Color.PowderBlue;
            this.optInventario.Image = global::PresentacionesZapatos.Properties.Resources.inventario;
            this.optInventario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optInventario.Name = "optInventario";
            this.optInventario.Size = new System.Drawing.Size(86, 20);
            this.optInventario.Text = "Inventario";
            this.optInventario.Click += new System.EventHandler(this.optInventario_Click);
            // 
            // optAlmacen
            // 
            this.optAlmacen.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.optAlmacen.Image = global::PresentacionesZapatos.Properties.Resources.almacen;
            this.optAlmacen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optAlmacen.Name = "optAlmacen";
            this.optAlmacen.Size = new System.Drawing.Size(86, 20);
            this.optAlmacen.Text = "Almacén";
            this.optAlmacen.Click += new System.EventHandler(this.optAlmacen_Click);
            // 
            // Ventas
            // 
            this.Ventas.BackColor = System.Drawing.Color.PeachPuff;
            this.Ventas.Image = global::PresentacionesZapatos.Properties.Resources.ventas;
            this.Ventas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Ventas.Name = "Ventas";
            this.Ventas.Size = new System.Drawing.Size(86, 20);
            this.Ventas.Text = "Ventas";
            this.Ventas.Click += new System.EventHandler(this.Ventas_Click);
            // 
            // optSalir
            // 
            this.optSalir.BackColor = System.Drawing.Color.MistyRose;
            this.optSalir.Image = global::PresentacionesZapatos.Properties.Resources.eliminar;
            this.optSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optSalir.Name = "optSalir";
            this.optSalir.Size = new System.Drawing.Size(86, 20);
            this.optSalir.Text = "Salir";
            this.optSalir.Click += new System.EventHandler(this.optSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(536, 316);
            this.Controls.Add(this.tsMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton optPedidos;
        private System.Windows.Forms.ToolStripButton optProduccion;
        private System.Windows.Forms.ToolStripButton optCompras;
        private System.Windows.Forms.ToolStripButton optInventario;
        private System.Windows.Forms.ToolStripButton optAlmacen;
        private System.Windows.Forms.ToolStripButton Ventas;
        private System.Windows.Forms.ToolStripButton optSalir;
    }
}