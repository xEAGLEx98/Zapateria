using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesZapato;
using System.IO;
using AccesoDatosZapato;
using System.Windows.Forms;
using System.Drawing;

namespace ManejadorZapatos
{
    public class mCompras
    {
        aCompras c = new aCompras();
        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = c.Mostrar(filtro).Tables["compras"];

        }
    }
}
