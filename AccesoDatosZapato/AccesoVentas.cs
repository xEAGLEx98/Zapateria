using ConectarRedReal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatosZapato
{
    public class AccesoVentas
    {
        Base b = new Base("Localhost", "root", "", "zapateria");
        public DataSet Mostrar(string filtro)
        {
            return b.Obtener
            (string.Format("call showVentas({0})",
            filtro), "ventas");
        }
    }
}
