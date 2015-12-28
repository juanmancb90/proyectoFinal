using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFEntidades;
using WCFDAL;

namespace WCFBL
{
    public class PedidosBL
    {
        /* 
         * Metodo
         * Descripcion: Retornar un listado de pedidos
         * Entrada: string
         * Salida: List<Pedidos>
         */
        public List<Pedidos> ObtenerPedidos(string cs)
        {
            SQLPedidos contexto = new SQLPedidos(cs);
            List<Pedidos> pedidos = contexto.ObtenerPedido();
            return (pedidos);
        }

        public string TestBLWcf()
        {
            return "Test BL WCF";
        }
    }
}
