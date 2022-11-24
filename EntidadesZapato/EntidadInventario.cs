using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesZapato
{
    public class EntidadInventario
    {
        public EntidadInventario(int id, string insumo, int cantidad, int idpedido)
        {
            _id = id;
            _insumo = insumo;
            _cantidad = cantidad;
            _idpedido = idpedido;
        }

        public int _id { get; set; }
        public string _insumo { get; set; }
        public int _cantidad { get; set; }
        public int _idpedido { get; set; }
    }
}

