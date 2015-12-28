using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFEntidades;

namespace WCFDAL
{
    public class SQLPedidos
    {
        private string cn;

        public SQLPedidos(string cs)
        {
            this.cn = cs;
        }

        public SQLPedidos() { }

        /* 
         * Metodo
         * Descripcion: Retorna un listado de pedidos
         * Entrada: void
         * Salida: List<Pedidos>
         */
        public List<Pedidos> ObtenerPedido()
        {
            List<Pedidos> pedidos = new List<Pedidos>();

            using (DB_Acme_DevEntities contexto = new DB_Acme_DevEntities())
            {
                var SQLPedido = from pedido in contexto.TB_Pedido select pedido;

                foreach (var item in SQLPedido)
                {
                    Pedidos pedidoActual = MapearPedido(item);
                    pedidos.Add(pedidoActual);
                }
            }

            return (pedidos);
        }

        /* 
         * Metodo
         * Descripcion: Mapea los atributos de un pedido
         * Entrada: TB_Pedido
         * Salida: Pedidos
         */
        private Pedidos MapearPedido(TB_Pedido item)
        {
            Pedidos pedido = new Pedidos();

            pedido.ID_Pedido = item.ID_Pedido;
            pedido.ID_Cliente = item.ID_Cliente;
            pedido.FechaRegistro = item.FechaRegistro;
            pedido.TotalBruto = item.TotalBruto;
            pedido.Impuesto = item.Impuesto;
            pedido.ValorNeto = item.ValorNeto;
            pedido.Estado = item.Estado;

            return (pedido);
        }
    }
}
