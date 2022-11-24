using AccesoDatosZapato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadorZapatos
{
    public class ManejadorInventario
    {
        AccesoInventario ai = new AccesoInventario();
        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = ai.Mostrar(filtro).Tables["Inventario"];
            
        }
    }
}
