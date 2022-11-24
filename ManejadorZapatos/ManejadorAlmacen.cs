using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatosZapato;

namespace ManejadorZapatos
{
    public class ManejadorAlmacen
    {
        AccesoAlmacen aa = new AccesoAlmacen();
        public void Mostrar(DataGridView tabla, string filtro)
        {

            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = aa.Mostrar(filtro).Tables["Almacen"];
            
        }
    }
}
