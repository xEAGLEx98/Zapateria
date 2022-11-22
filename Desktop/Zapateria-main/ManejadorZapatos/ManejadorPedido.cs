using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatosZapato;
using Crud;
namespace ManejadorZapatos
{
    public class ManejadorPedido : IZapatos
    {
        AccesoPedidos ap = new AccesoPedidos();
        Grafica g = new Grafica();

        public void Borrar(dynamic entidad)
        {
            DialogResult dr = MessageBox.Show("¿Estás seguro de eliminar este registro?",
                "!ATENCIÓN", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                ap.Borrar(entidad);
            }
        }

        public void Guardar(dynamic entidad)
        {
            ap.Guardar(entidad);
            g.Mensaje("Tu pedido se ha guardado satisfactoriamente",
                "!INFORME", MessageBoxIcon.Information);
        }
        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.ColumnHeadersHeight = 40;
            tabla.DataSource = ap.Mostrar(filtro).Tables["pedidos"];
            tabla.Columns.Insert(6,g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(7,g.Boton("Borrar", Color.Red));
            tabla.Columns[0].Visible = false;
        }
    }
}
