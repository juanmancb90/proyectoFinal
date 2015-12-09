using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace BL
{
    public class DetallePedidosBL
    {
        public List<DetallePedidos> ObtenerDetallePedidosBL(string cs)
        {
            DetallePedidosDAL context = new DetallePedidosDAL(cs);
            List<DetallePedidos> detallePedido = context.ObtenerDetallePedidosDAL();

            return detallePedido;
        }
    }
}
