using System;
using System.Windows.Forms;
using ManejadorZapatos;
using EntidadesZapato;
namespace PresentacionesZapatos
{
    public partial class FrmPedidosAdd : Form
    {
        ManejadorPedidos mp;
        public FrmPedidosAdd()
        {
            InitializeComponent();
            mp = new ManejadorPedidos();
            mp = new ManejadorPedidos();
            if (FrmPedidos.pedidos.Id > 0)
            {
                txtPedido.Text = FrmPedidos.pedidos.Pedido;
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
            mp.Guardar(new Pedidos(FrmPedidos.pedidos.Id,
                txtPedido.Text,
                int.Parse(txtCantidad.Text),
                double.Parse(txtCosto.Text),
                DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")));
            Close();
        }
    }
}
