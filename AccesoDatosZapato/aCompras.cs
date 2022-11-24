using System;
using System.Collections.Generic;
using System.Linq;
using ConectarRedReal;
using EntidadesZapato;
using System.IO;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatosZapato
{
    public class aCompras
    {   
        Base b = new Base("localhost", "root", "", "zapateria");
        
        public DataSet Mostrar(string filtro)
        {
            return b.Obtener
                (string.Format("call showCompras('%{0}%')",filtro),"compras");
        }
    }
}
