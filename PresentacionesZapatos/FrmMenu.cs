using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PresentacionesZapatos
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void optSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void optPedidos_Click(object sender, EventArgs e)
        {
            FrmPedidos owo = new FrmPedidos();
            owo.ShowDialog();
        }

        private void optProduccion_Click(object sender, EventArgs e)
        {
            FrmProduccion uwu = new FrmProduccion();
            uwu.ShowDialog();
        }

        private void optCompras_Click(object sender, EventArgs e)
        {
            FrmCompras umu = new FrmCompras();
            umu.ShowDialog();
        }

        private void optInventario_Click(object sender, EventArgs e)
        {
            FrmInventario ewe = new FrmInventario();
            ewe.ShowDialog();
        }

        private void optAlmacen_Click(object sender, EventArgs e)
        {
            FrmAlmacen omo = new FrmAlmacen();
            omo.ShowDialog();
        }

        private void Ventas_Click(object sender, EventArgs e)
        {
            FrmVentas qwq = new FrmVentas();
            qwq.ShowDialog();
        }
    }
}
