namespace PresentacionesZapatos
{
    partial class FrmPedidos
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgMostrar = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(81, 13);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(575, 26);
            this.txtBuscar.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Ivory;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = global::PresentacionesZapatos.Properties.Resources.anadir;
            this.btnAgregar.Location = new System.Drawing.Point(662, 7);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(40, 37);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar:";
            // 
            // dtgMostrar
            // 
            this.dtgMostrar.BackgroundColor = System.Drawing.Color.OldLace;
            this.dtgMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMostrar.GridColor = System.Drawing.Color.Ivory;
            this.dtgMostrar.Location = new System.Drawing.Point(12, 48);
            this.dtgMostrar.Name = "dtgMostrar";
            this.dtgMostrar.Size = new System.Drawing.Size(690, 250);
            this.dtgMostrar.TabIndex = 3;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Image = global::PresentacionesZapatos.Properties.Resources.salida__2_;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(12, 304);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(121, 37);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = false;
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(714, 353);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dtgMostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBuscar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgMostrar;
        private System.Windows.Forms.Button btnRegresar;
    }
}