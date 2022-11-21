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
    public partial class FrmProduccion : Form
    {
        ManejadorProduccion mp;
        public FrmProduccion()
        {
            InitializeComponent();
            mp = new ManejadorProduccion();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }
        void Actualizar()
        {
            mp.Mostrar(txtBuscar.Text,dtgMostrar);
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmProduccionAdd owo = new FrmProduccionAdd();
            owo.ShowDialog();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            mp.Limpiar();
        }

        private void FrmProduccion_Load(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
