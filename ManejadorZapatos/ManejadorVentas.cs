using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatosZapato;

namespace ManejadorZapatos
{
    public class ManejadorVentas
    {
        AccesoVentas av = new AccesoVentas();
        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = av.Mostrar(filtro).Tables["Ventas"];

        }
    }
}
