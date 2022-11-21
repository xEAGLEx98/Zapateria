using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesZapato
{
    public class Produccion
    {
        public Produccion(int idPedido, int cantidad)
        {
            __IdPedido = idPedido;
            _Cantidad = cantidad;
        }

        public int __IdPedido { get; set; }
        public int _Cantidad { get; set; }
    }
}
