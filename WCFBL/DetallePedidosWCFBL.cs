/*
 * Nombre de la Clase: DetallePedidosWCFBL
 * Descripcion: Toma objetos de tipo SQLPedidos creado desde la capa Data_Access_Layer y lo pasa a la capa User_Interface
 * Autor: Equipo Makross - Grupo de Desarrollo
 * Fecha: 14/12/2015
 */

/*
 * Listado de Metodos:
 * >> List<DetallePedidosWCF> ObtenerDetallePedidos(string cs)
 * >> void SincronizarDetallePedidos(string cs, DetallePedidosWCF detallePedido)
 */
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

        /* 
         * Metodo
         * Descripcion: Sincronizar eñ listado de detalle pedidos del web service
         * Entrada: string cs, DetallePedidosWCF detallePedido
         * Salida: void
         */
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
