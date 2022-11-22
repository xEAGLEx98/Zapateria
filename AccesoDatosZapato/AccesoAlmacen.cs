using ConectarRedReal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatosZapato
{
    public class AccesoAlmacen
    {
        Base b = new Base("localhost", "root", "", "zapateria");
        public DataSet Mostrar(string filtro)
        {
            return b.Obtener
            (string.Format("call showAlmacen('%{0}%')",
            filtro), "almacen");
        }
    }
}
