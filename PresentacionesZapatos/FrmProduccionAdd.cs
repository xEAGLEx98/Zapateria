using Crud;
using EntidadesZapato;
using ManejadorZapatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionesZapatos
{
    public partial class FrmProduccionAdd : Form
    {
        ManejadorProduccion mp;
        Graficos g;
        public FrmProduccionAdd()
        {
            InitializeComponent();
            mp = new ManejadorProduccion();
            g = new Graficos();
            mp.ExtraePedido(cmbPedido);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mp.Guardar(new Produccion(int.Parse(cmbPedido.SelectedValue.ToString()),int.Parse(txtCantidad.Text)));
            g.Mensaje("Producción registrada", "Enhorabuena", MessageBoxIcon.Information);
            Close();
        }
    }
}
