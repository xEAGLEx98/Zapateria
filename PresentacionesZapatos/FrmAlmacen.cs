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
    public partial class FrmAlmacen : Form
    {
        ManejadorAlmacen mal;
        public static EntidadAlmacen ea = new EntidadAlmacen(0, "", 0, 0);
        int fila = 0, col = 0;
        public FrmAlmacen()
        {
            InitializeComponent();
            mal = new ManejadorAlmacen();
        }

        private void dtgMostrar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
            ea._id = int.Parse(dtgMostrar.Rows[fila]
                .Cells[0].Value.ToString());
            ea._producto = dtgMostrar.Rows[fila]
                .Cells[1].Value.ToString();
            ea._cantidad = int.Parse(dtgMostrar.Rows[fila]
                .Cells[2].Value.ToString());
            ea._idpedido = int.Parse(dtgMostrar.Rows[fila].
                Cells[3].Value.ToString());
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void FrmAlmacen_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        void Actualizar()
        {
            mal.Mostrar(dtgMostrar, txtBuscar.Text);
        }
    }
}
