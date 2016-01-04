/*
 * Nombre de la Clase: SQLPedidos
 * Descripcion: Establecer una conexión a la base de datos
 * Autor: Equipo Makross - Grupo de Desarrollo
 * Fecha: 14/12/2015
 */

/*
 * Listado de Metodos:
 * >> PedidosDAL()
 * >> PedidosDAL(string cs)
 * >> List<Pedidos> ObtenerPedido()
 * >> int ConsultarIdentificadorPedido()
 * >> void InsertarPedido(int iD_Cliente, decimal totalBruto, decimal impuesto, decimal valorNeto)
 * >> Pedidos MapearPedido(TB_Pedido item)
 * >> List<Pedidos> ObtenerPedidoFecha(string fechaActual)
 * >> Pedidos MapearPedido(ConsultarPedidoFecha_Result item)
 * >> void ActualizarEstadoPedidos(int p)
 */

using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;

namespace DAL
{
    public class PedidosDAL
    {
        private string cs;

        /* 
         * Metodo
         * Descripcion: Metodo constructor por defecto
         * Entrada: void
         * Salida: void
         */
        public PedidosDAL()
        { }

        /* 
         * Metodo
         * Descripcion: Metodo constructor que recibe un parametro string
         * Entrada: string
         * Salida: void
         */
        public PedidosDAL(string cs)
        {
            this.cs = cs;
        }

        /* 
         * Metodo
         * Descripcion: Retorna un listado de pedidos
         * Entrada: void
         * Salida: List<Pedidos>
         */
        public List<Pedidos> ObtenerPedido()
        {
            List<Pedidos> pedidos = new List<Pedidos>();

            using (DB_AcmeEntities contexto = new DB_AcmeEntities())
            {
                var SQLPedido = from pedido in contexto.TB_Pedido select pedido;

                foreach (var item in SQLPedido)
                {
                    Pedidos pedidoActual = MapearPedido(item);
                    pedidos.Add(pedidoActual);
                }
            }

            return (pedidos);
        }

        /* 
         * Metodo
         * Descripcion: Consulta el identificador de un pedido
         * Entrada: void
         * Salida: int
         */
        public int ConsultarIdentificadorPedido()
        {
            ObjectParameter iD_Pedido = new ObjectParameter("ID_Pedido", typeof(int));

            using (DB_AcmeEntities contexto = new DB_AcmeEntities())
            {
                contexto.ConsultarIdentificadorPedido(iD_Pedido);
            }

            return ((int)iD_Pedido.Value);
        }

        /* 
         * Metodo
         * Descripcion: Inserta un pedido en la base de datos
         * Entrada: int, decimal, decimal, decimal,
         * Salida: void
         */
        public void InsertarPedido(int iD_Cliente, decimal totalBruto, decimal impuesto, decimal valorNeto)
        {
            using (DB_AcmeEntities contexto = new DB_AcmeEntities())
            {
                contexto.InsertarPedido(iD_Cliente, totalBruto, impuesto, valorNeto);
            }
        }

        /* 
         * Metodo
         * Descripcion: Mapea los atributos de un pedido
         * Entrada: TB_Pedido
         * Salida: Pedidos
         */
        private Pedidos MapearPedido(TB_Pedido item)
        {
            Pedidos pedido = new Pedidos();

            pedido.ID_Pedido = item.ID_Pedido;
            pedido.ID_Cliente = item.ID_Cliente;
            pedido.FechaRegistro = item.FechaRegistro;
            pedido.TotalBruto = item.TotalBruto;
            pedido.Impuesto = item.Impuesto;
            pedido.ValorNeto = item.ValorNeto;
            pedido.Estado = item.Estado;

            return (pedido);
        }

        /* 
         * Metodo
         * Descripcion: Obtiene una listado de pedidos por fecha
         * Entrada: string fechaActual
         * Salida: List<Pedidos>
         */
        public List<Pedidos> ObtenerPedidoFecha(string fechaActual)
        {
            List<Pedidos> pedidos = new List<Pedidos>();

            using (DB_AcmeEntities contexto = new DB_AcmeEntities())
            {
                var SQLPedido = contexto.ConsultarPedidoFecha(fechaActual);

                foreach (var item in SQLPedido)
                {
                    Pedidos pedidoActual = MapearPedido(item);
                    pedidos.Add(pedidoActual);
                }
            }

            return pedidos;
        }


        /* 
         * Metodo
         * Descripcion: Mapea los atributos de un pedido
         * Entrada: ConsultarPedidoFecha_Result
         * Salida: Pedidos
         */
        private Pedidos MapearPedido(ConsultarPedidoFecha_Result item)
        {
            Pedidos pedido = new Pedidos();
            pedido.ID_Pedido = item.ID_Pedido;
            pedido.ID_Cliente = item.ID_Cliente;
            pedido.FechaRegistro = item.FechaRegistro;
            pedido.TotalBruto = item.TotalBruto;
            pedido.Impuesto = item.Impuesto;
            pedido.ValorNeto = item.ValorNeto;
            pedido.Estado = item.Estado;

            return pedido;
        }

        /* 
         * Metodo
         * Descripcion: Actualiza el estado de Sincronizacion de los pedidos
         * Entrada: int p
         * Salida: void
         */
        public void ActualizarEstadoPedidos(int p)
        {
            using (DB_AcmeEntities contexto = new DB_AcmeEntities())
            {
                contexto.ActualizarPedidoSincronizado(p);
            }
        }
    }
}
