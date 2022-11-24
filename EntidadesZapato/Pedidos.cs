using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesZapato
{
    public class Pedidos
    {
        public Pedidos(int id, string pedido, int cantidad, 
            double costo, string fechaPedido, string fechaConcluido)
        {
            Id = id;
            Pedido = pedido;
            Cantidad = cantidad;
            Costo = costo;
            FechaPedido = fechaPedido;
            FechaConcluido = fechaConcluido;
        }

        public int Id { get; set; }
        public string Pedido { get; set; }
        public int Cantidad { get; set; }
        public double Costo { get; set; }
        public string FechaPedido { get; set; }
        public string FechaConcluido { get; set; }
    }
}
