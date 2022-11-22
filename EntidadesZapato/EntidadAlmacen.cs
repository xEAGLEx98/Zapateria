using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesZapato
{
    public class EntidadAlmacen
    {
        public EntidadAlmacen(int id, string producto, int cantidad, int idpedido)
        {
            _id = id;
            _producto = producto;
            _cantidad = cantidad;
            _idpedido = idpedido;
        }

        public int _id { get; set; }
        public string _producto { get; set; }
        public int _cantidad { get; set; }
        public int _idpedido { get; set; }
    }
}
