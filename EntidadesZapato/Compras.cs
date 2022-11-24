using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EntidadesZapato
{
    public class Compras
    {
        public Compras(int id, int cantidad, double costo, int insumo)
        {
            Id = id;
            Cantidad = cantidad;
            Costo = costo;
            Insumo = insumo;
        }

        public int Id { get; set; }
        public int Cantidad { get; set; }
        public double Costo { get; set; }
        public int Insumo { get; set; }
    }
}
