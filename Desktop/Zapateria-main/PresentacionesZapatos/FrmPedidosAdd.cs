using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManejadorZapatos;
using EntidadesZapato;
namespace PresentacionesZapatos
{
    public partial class FrmPedidosAdd : Form
    {
        ManejadorPedido mp;
        public FrmPedidosAdd()
        {
            InitializeComponent();
            mp = new ManejadorPedido();
            if (FrmPedidos.pedidos.Id > 0)
            {
                txtE.Text = FrmPedidos.pedidos.Pedido;
                txtCantidad.Text = FrmPedidos.pedidos.Cantidad.ToString();
                txtCosto.Text = FrmPedidos.pedidos.Costo.ToString();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbPedido.SelectedItem.ToString());
            string p = cmbPedido.SelectedItem.ToString();
            mp.Guardar(new Pedidos(FrmPedidos.pedidos.Id,
                txtE.Text,
                int.Parse(txtCantidad.Text),
                double.Parse(txtCosto.Text),
                DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")));
            Close();
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
