using EntidadesZapato;
using ManejadorZapatos;
using System;
using System.Windows.Forms;

namespace PresentacionesZapatos
{
    public partial class FrmPedidos : Form
    {
        int fila = 0, columna = 0;
        ManejadorPedidos mp;
        public static Pedidos pedidos = new Pedidos(0, "", 0, 0.0, "", "");
        public FrmPedidos()
        {
            InitializeComponent();
            mp = new ManejadorPedidos();
        }
        void Actualizar()
        {
            mp.Mostrar(dtgMostrar, txtBuscar.Text);
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pedidos.Id = -1;
            FrmPedidosAdd uwu = new FrmPedidosAdd();
            uwu.ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtgMostrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pedidos.Id = int.Parse(dtgMostrar.Rows[fila].Cells[0].Value.ToString());
            pedidos.Pedido = dtgMostrar.Rows[fila].Cells[1].Value.ToString();
            pedidos.Cantidad = int.Parse(dtgMostrar.Rows[fila].Cells[2].Value.ToString());
            pedidos.Costo = double.Parse(dtgMostrar.Rows[fila].Cells[3].Value.ToString());
            pedidos.FechaPedido = dtgMostrar.Rows[fila].Cells[4].Value.ToString();
            pedidos.FechaConcluido = dtgMostrar.Rows[fila].Cells[5].Value.ToString();
            switch (columna)
            {
                case 6:
                    {
                        FrmPedidosAdd a = new FrmPedidosAdd();
                        a.ShowDialog();
                        Actualizar();
                    }
                    break;
                case 7:
                    {
                        mp.Borrar(pedidos);
                        Actualizar();
                    }
                    break;
            }
        }

        private void dtgMostrar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
        }
    }
}
