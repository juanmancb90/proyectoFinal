using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFEntidades;
using WCFDAL;

namespace WCFBL
{
    public class DetallePedidosBL
    {
        /* 
         * Metodo
         * Descripcion: Retornar un listado de detalle pedidos
         * Entrada: string
         * Salida: List<DetallePedidos>
         */
        public List<DetallePedidos> ObtenerDetallePedidos(string cs)
        {
            SQLDetallePedidos contexto = new SQLDetallePedidos(cs);
            List<DetallePedidos> detallePedidos = contexto.ObtenerDetallePedido();
            return (detallePedidos);
        }
    }
}
