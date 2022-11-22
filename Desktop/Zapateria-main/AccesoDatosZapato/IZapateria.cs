using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatosZapato
{
    public interface IZapateria
    {
        void Guardar(dynamic entidad);
        DataSet Mostrar(string filtro);
        void Borrar(dynamic entidad);
    }
}
