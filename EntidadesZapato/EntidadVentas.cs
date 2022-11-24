using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesZapato
{
    public class EntidadVentas
    {
        public EntidadVentas(int id, int idpedido, string fecha)
        {
            _id = id;
            _idpedido = idpedido;
            _fecha = fecha;
        }

        public int _id { get; set; }
        public int _idpedido { get; set; }
        public string _fecha { get; set; }
    }
}
