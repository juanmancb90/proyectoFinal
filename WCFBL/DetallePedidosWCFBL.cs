using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFEntidades;
using WCFDAL;

namespace WCFBL
{
    public class DetallePedidosWCFBL
    {
        /* 
         * Metodo
         * Descripcion: Retornar un listado de detalle pedidos
         * Entrada: string
         * Salida: List<DetallePedidos>
         */
        public List<DetallePedidosWCF> ObtenerDetallePedidos(string cs)
        {
            SQLDetallePedidos contexto = new SQLDetallePedidos(cs);
            List<DetallePedidosWCF> detallePedidos = contexto.ObtenerDetallePedido();
            return (detallePedidos);
        }

        public void SincronizarDetallePedidos(string cs, DetallePedidosWCF detallePedido)
        {
            SQLDetallePedidos contexto = new SQLDetallePedidos(cs);
            List<DetallePedidosWCF> detallePedidosDAL = contexto.ObtenerDetallePedido();

            if (detallePedido != null)
            {
                contexto.InsertarDetallePedidos(detallePedido);
            }
        }
    }
}
