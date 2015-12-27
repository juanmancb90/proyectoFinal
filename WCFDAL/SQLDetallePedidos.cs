using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFEntidades;

namespace WCFDAL
{
    public class SQLDetallePedidos
    {
          private string cs;

        /* 
         * Metodo
         * Descripcion: Metodo constructor por defecto
         * Entrada: void
         * Salida: void
         */
        public SQLDetallePedidos()
        { }

        /* 
         * Metodo
         * Descripcion: Metodo constructor que recibe un parametro string
         * Entrada: string
         * Salida: void
         */
        public SQLDetallePedidos(string cs)
        {
            this.cs = cs;
        }

        /* 
         * Metodo
         * Descripcion: Retorna un listado de detalle de pedidos
         * Entrada: void
         * Salida: List<DetallePedidos>
         */
        public List<DetallePedidos> ObtenerDetallePedido()
        {
            List<DetallePedidos> detallePedidos = new List<DetallePedidos>();

            using (DB_Acme_DevEntities contexto = new DB_Acme_DevEntities())
            {
                var SQLDetallePedidos = from detallePedido in contexto.TB_DetallePedido select detallePedido;

                foreach (var item in SQLDetallePedidos)
                {
                    DetallePedidos detallePedidoActual = MapearDetallePedido(item);
                    detallePedidos.Add(detallePedidoActual);
                }
            }

            return (detallePedidos);
        }

        /* 
         * Metodo
         * Descripcion: Mapea los atributos de un detalle de pedido
         * Entrada: TB_DetallePedido
         * Salida: DetallePedidos
         */
        private DetallePedidos MapearDetallePedido(TB_DetallePedido item)
        {
            DetallePedidos detallePedido = new DetallePedidos();

            detallePedido.ID_DetallePedido = item.ID_DetallePedido;
            detallePedido.ID_Pedido = item.ID_Pedido;
            detallePedido.ID_Producto = item.ID_Producto;
            detallePedido.Codigo = item.Codigo;
            detallePedido.NombreProducto = item.NombreProducto;
            detallePedido.Descripcion = item.Descripcion;
            detallePedido.Cantidad = item.Cantidad;
            detallePedido.ValorUnitario = item.ValorUnitario;
            detallePedido.Impuesto = item.Impuesto;
            detallePedido.SubTotal = item.SubTotal;

            return (detallePedido);
        }
    }
}
