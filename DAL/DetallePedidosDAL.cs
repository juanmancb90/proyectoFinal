using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Collections.ObjectModel;

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

        /* 
         * Metodo
         * Descripcion: Actualiza el stock de un producto
         * Entrada: int, int
         * Salida: void
         */
        public void ActualizarStockProducto(int iD_Producto, int cantidad)
        {
            using (DB_AcmeEntities contexto = new DB_AcmeEntities())
            {
                contexto.ActualizarStockProducto(iD_Producto, cantidad);
            }
        }

        /* 
         * Metodo
         * Descripcion: Inserta un detalle de pedido en la base de datos
         * Entrada: int, int, int
         * Salida: void
         */
        public void InsertarDetallePedido(int iD_Pedido, int iD_Producto, int cantidad)
        {
            using (DB_AcmeEntities contexto = new DB_AcmeEntities())
            {
                contexto.InsertarDetallePedido(iD_Pedido, iD_Producto, cantidad);
            }
        }

        /* 
         * Metodo
         * Descripcion: Retorna una coleccion de detalle de pedido
         * Entrada: int, string, string, string, int, decimal, decimal, decimal
         * Salida: ObservableCollection<DetallePedidos>
         */
        public ObservableCollection<DetallePedidos> ObtenerDetallePedido(int iD_Producto, string codigo, string nombreProducto, string descripcion, int cantidadProducto, decimal valorUnitario, decimal impuesto, decimal subTotal)
        {
            ObservableCollection<DetallePedidos> detallePedidos = new ObservableCollection<DetallePedidos>();

            detallePedidos.Add(new DetallePedidos
            {
                ID_Producto = iD_Producto,
                Codigo = codigo,
                NombreProducto = nombreProducto,
                Descripcion = descripcion,
                Cantidad = cantidadProducto,
                ValorUnitario = valorUnitario,
                Impuesto = impuesto,
                SubTotal = subTotal
            });

            return (detallePedidos);
        }


        private DetallePedidos MapearDetallePedidos(TB_DetallePedido item)
        {
            DetallePedidos detallePedido = new DetallePedidos();

            detallePedido.ID_DetallePedido = item.ID_DetallePedido;
            detallePedido.ID_Pedido = item.ID_Pedido;
            detallePedido.ID_Producto = item.ID_Producto;
            detallePedido.NombreProducto = item.NombreProducto;
            detallePedido.Descripcion = item.Descripcion;
            detallePedido.Cantidad = item.Cantidad;
            detallePedido.ValorUnitario = item.ValorUnitario;
            detallePedido.Impuesto = item.Impuesto;
            detallePedido.SubTotal = item.SubTotal;

            return detallePedido;
        }


    }
}
