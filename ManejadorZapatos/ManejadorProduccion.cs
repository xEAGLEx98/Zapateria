using AccesoDatosZapato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadorZapatos
{
    public class ManejadorProduccion
    {
        AccesoDatosProduccion ap = new AccesoDatosProduccion();
        public void Guardar(dynamic Entidad)
        {
            ap.Agregar(Entidad);
        }
        public void Limpiar()
        {
            DialogResult rs = MessageBox.Show("¿Estás seguro que deseas limpiar los completados?", "ATENCIÓN",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                ap.Limpiar();
        }
        public void Mostrar(string filtro, DataGridView tabla)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = ap.mostrar(filtro).Tables["produccion"];
            tabla.Columns[0].Visible = false;
        }
        public void ExtraePedido(ComboBox caja)
        {
            caja.DataSource = ap.mostrarPedido().Tables["pedidos"];
            caja.DisplayMember = "pedido";
            caja.ValueMember = "id";
        }
    }
}
