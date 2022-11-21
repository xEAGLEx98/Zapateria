using ConectarRedReal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatosZapato
{
    public class AccesoDatosProduccion
    {
        Base b = new Base("localhost", "root", "", "zapateria");
        public void Agregar(dynamic Entidad)
        {
            b.comando(String.Format("call insertar_producciones({0},{1})", Entidad.__IdPedido, Entidad._Cantidad));
        }
        public void Limpiar(dynamic Entidad)
        {
            b.comando(string.Format("call limpiar_produccion({0})",Entidad.__IdPedido));
        }
        public DataSet mostrar(string filtro)
        {
            return b.Obtener(string.Format("SELECT p.id,p._idpedido AS 'No. Pedido',pe.pedido AS " +
                "'Pedido',p.estado AS 'Estado',p.cantidad AS 'Cantidad' FROM produccion p, pedidos" +
                " pe WHERE p._idpedido = pe.id AND pe.pedido LIKE '%{0}%'",filtro),"produccion");
        }
        public DataSet mostrarPedido()
        {
            return b.Obtener("select pedido, id from pedidos","pedidos");
        }
    }
}
