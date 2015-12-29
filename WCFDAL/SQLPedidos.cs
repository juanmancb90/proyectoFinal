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
        public List<PedidosWCF> ObtenerPedido()
        {
            List<PedidosWCF> pedidos = new List<PedidosWCF>();

            using (DB_Acme_DevEntities contexto = new DB_Acme_DevEntities())
            {
                var SQLPedido = from pedido in contexto.TB_Pedido select pedido;

                foreach (var item in SQLPedido)
                {
                    PedidosWCF pedidoActual = MapearPedido(item);
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
        private PedidosWCF MapearPedido(TB_Pedido item)
        {
            PedidosWCF pedido = new PedidosWCF();

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
