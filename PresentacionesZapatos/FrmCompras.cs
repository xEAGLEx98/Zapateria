using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using EntidadesZapato;
using System.IO;
using ManejadorZapatos;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionesZapatos
{
    public partial class FrmCompras : Form
    {
        mCompras manejador;
        public static Compras entidad = new Compras(0,0,0,0);
        public FrmCompras()
        {
            InitializeComponent();
            manejador = new mCompras();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmComprasAdd owo = new FrmComprasAdd();
            owo.ShowDialog();
        }

        void Actualizar()
        {
            manejador.Mostrar(dtgMostrar, txtBuscar.Text);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
