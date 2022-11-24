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
    public partial class FrmInventario : Form
    {
        ManejadorInventario mi;
        public static EntidadInventario inventario = new EntidadInventario(0, "", 0, 0);
        int fila = 0, columna = 0;
        public FrmInventario()
        {
            InitializeComponent();
            mi = new ManejadorInventario();
        }

        private void dtgMostrar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
            inventario._id = int.Parse(dtgMostrar.Rows[fila]
                .Cells[0].Value.ToString());
            inventario._insumo = dtgMostrar.Rows[fila]
                .Cells[1].Value.ToString();
            inventario._cantidad = int.Parse(dtgMostrar.Rows[fila]
                .Cells[2].Value.ToString());
            inventario._idpedido = int.Parse(dtgMostrar.Rows[fila].
                Cells[3].Value.ToString());
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        void Actualizar()
        {
            mi.Mostrar(dtgMostrar, txtBuscar.Text);
        }
    }
}
