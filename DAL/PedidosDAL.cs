using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    public class PedidosDAL
    {
        private string con;

        public PedidosDAL(string cs)
        {
            this.con = cs;
        }

        public List<Pedidos> ObtenerPedidosDAL()
        {
            List<Pedidos> pedidos = new List<Pedidos>();
            using(DB_AcmeEntities context = new DB_AcmeEntities())
            {
                var pedidosEF = from ped in context.TB_Pedido
                                select ped;
                foreach (var item in pedidosEF)
                {
                    Pedidos pedidoAct = MapearPedidos(item);
                    pedidos.Add(pedidoAct);
                }
            }
            return pedidos;
        }

        private Pedidos MapearPedidos(TB_Pedido item)
        {
            Pedidos pedido = new Pedidos();

            pedido.ID_Pedido = item.ID_Pedido;
            pedido.ID_Cliente = item.ID_Cliente;
            pedido.FechaRegistro = item.FechaRegistro;
            pedido.FechaEntrega = item.FechaEntrega;
            pedido.TotalBruto = item.TotalBruto;
            pedido.Impuesto = item.Impuesto;
            pedido.ValorNeto = item.ValorNeto;
            pedido.Estado = item.Estado;

            return pedido;
        }
    }
}
