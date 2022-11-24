using System.Data;
using ConectarBd;
namespace AccesoDatosZapato
{
    public class AccesoPedidos
    {
        Base b = new Base("localhost", "root", "", "zapateria");

        public void Borrar(dynamic entidad)
        {
            b.Comando(string.Format("CALL deletePedido({0})", entidad.Id));
        }
        public void Guardar(dynamic entidad)
        {
            b.Comando(string.Format("CALL insertPedido('{0}', {1}, {2}, '{3}', '{4}', {5})",
                entidad.Pedido, entidad.Cantidad, entidad.Costo,
                entidad.FechaPedido, entidad.FechaConcluido, entidad.Id));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("CALL showPedido('%{0}%')", filtro), "pedidos");
        }
    }
}
