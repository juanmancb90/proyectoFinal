using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace BL
{
    public class PedidosBL
    {
        public List<Pedidos> ObtenerPedidosBL(string cs)
        {
            PedidosDAL context = new PedidosDAL(cs);
            List<Pedidos> pedido = context.ObtenerPedidosDAL();

            return pedido;
        }
    }
}
