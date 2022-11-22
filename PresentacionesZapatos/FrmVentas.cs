using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesZapato;
using ManejadorZapatos;

namespace PresentacionesZapatos
{
    public partial class FrmVentas : Form
    {
        ManejadorVentas mv;
        public static EntidadVentas ev = new EntidadVentas(0, 0, default);
        int fila = 0, columna = 0;
        public FrmVentas()
        {
            InitializeComponent();
            mv = new ManejadorVentas();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtgMostrar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
            ev._id = int.Parse(dtgMostrar.Rows[fila]
                .Cells[0].Value.ToString());
            ev._idpedido = int.Parse(dtgMostrar.Rows[fila].
                Cells[1].Value.ToString());
            ev._fecha = dtgMostrar.Rows[fila]
                .Cells[2].Value.ToString();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        void Actualizar()
        {
            mv.Mostrar(dtgMostrar, txtBuscar.Text);
        }
    }
}
