/*
 * Nombre de la Clase: PedidosWCFBL
 * Descripcion: Toma objetos de tipo SQLPedidos creado desde la capa Data_Access_Layer y lo pasa a la capa User_Interface
 * Autor: Equipo Makross - Grupo de Desarrollo
 * Fecha: 14/12/2015
 */

/*
 * Listado de Metodos:
 * >> List<Pedidos> ObtenerPedidos(string cs)
 * >> void SincronizarPedidos(string cs, PedidosWCF pedido)
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
    public class PedidosWCFBL
    {
        /* 
         * Metodo
         * Descripcion: Retornar un listado de pedidos
         * Entrada: string
         * Salida: List<Pedidos>
         */
        public List<PedidosWCF> ObtenerPedidos(string cs)
        {
            SQLPedidos contexto = new SQLPedidos(cs);
            List<PedidosWCF> pedidos = contexto.ObtenerPedido();
            return (pedidos);
        }

        /* 
         * Metodo
         * Descripcion: Sincroniza el listado de pedidos
         * Entrada: string cs, PedidosWCF pedido
         * Salida: void
         */
        public void SincronizarPedidos(string cs, PedidosWCF pedido)
        {
            SQLPedidos contexto = new SQLPedidos(cs);
            List<PedidosWCF> pedidosDAL = contexto.ObtenerPedido();

            if (pedido != null) 
            {
                contexto.InsertarPedidos(pedido);
            }
        }
    }
}
