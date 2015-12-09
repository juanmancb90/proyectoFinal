using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    public class DetallePedidosDAL
    {
        private string con;

        public DetallePedidosDAL(string cs)
        {
            this.con = cs;
        }

        public List<DetallePedidos> ObtenerDetallePedidosDAL()
        {
            List<DetallePedidos> detallePedidos = new List<DetallePedidos>();

            using(DB_AcmeEntities context = new DB_AcmeEntities())
            {
                var detallePedidosEF = from det in context.TB_DetallePedido
                                       select det;
                foreach (var item in detallePedidosEF)
                {
                    DetallePedidos detallePedidoAct = MapearDetallePedidos(item);
                    detallePedidos.Add(detallePedidoAct);
                }
                return detallePedidos;
            }
        }

        private DetallePedidos MapearDetallePedidos(TB_DetallePedido item)
        {
            DetallePedidos detallePedido = new DetallePedidos();

            detallePedido.ID_DetallePedido = item.ID_DetallePedido;
            detallePedido.ID_Pedido = item.ID_Pedido;
            detallePedido.ID_Producto = item.ID_Producto;
            detallePedido.NombreProducto = item.NombreProducto;
            detallePedido.Cantidad = item.Cantidad;
            detallePedido.ValorUnitario = item.ValorUnitario;
            detallePedido.SubTotal = item.SubTotal;

            return detallePedido;
        }


    }
}
