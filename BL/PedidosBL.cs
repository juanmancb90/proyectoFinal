/*
 * Nombre de la Clase: PedidosBL
 * Descripcion: Toma objetos de tipo SQLPedidos creado desde la capa Data_Access_Layer y lo pasa a la capa User_Interface
 * Autor: Equipo Makross - Grupo de Desarrollo
 * Fecha: 14/12/2015
 */

/*
 * Listado de Metodos:
 * >> List<Pedidos> ObtenerPedidos(string cs)
 * >> int ConsultarIdentificadorPedidos()
 * >> void InsertarPedidos(int iD_Cliente, decimal totalBruto, decimal impuesto, decimal valorNeto)
 */

using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
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
            PedidosDAL contexto = new PedidosDAL(cs);
            List<Pedidos> pedidos = contexto.ObtenerPedido();
            return (pedidos);
        }

        /* 
         * Metodo
         * Descripcion: Retornar el identificador de un pedido
         * Entrada: void
         * Salida: int
         */
        public int ConsultarIdentificadorPedidos()
        {
            PedidosDAL contexto = new PedidosDAL();
            int iD_Pedido = contexto.ConsultarIdentificadorPedido();
            return (iD_Pedido);
        }

        /* 
         * Metodo
         * Descripcion: Inserta atributos de un pedido
         * Entrada: int, decimal, decimal, decimal
         * Salida: void
         */
        public void InsertarPedidos(int iD_Cliente, decimal totalBruto, decimal impuesto, decimal valorNeto)
        {
            PedidosDAL contexto = new PedidosDAL();
            contexto.InsertarPedido(iD_Cliente, totalBruto, impuesto, valorNeto);
        }

        public List<Pedidos> ObtenerPedidosPorFecha(string cs, string fechaActual)
        {
            PedidosDAL contexto = new PedidosDAL(cs);
            List<Pedidos> pedidos = contexto.ObtenerPedidoFecha(fechaActual);
            return pedidos;
        }

        public void ActualizarEstadoPedido(string cs, List<Pedidos> pedidosBL)
        {
            PedidosDAL contexto = new PedidosDAL(cs);

            foreach (var item in pedidosBL)
            {
               contexto.ActualizarEstadoPedidos(item.ID_Pedido);
            }
        }
    }
}
