/*
 * Nombre de la Clase: SQLPedidos
 * Descripcion: Establecer una conexión a la base de datos
 * Autor: Equipo Makross - Grupo de Desarrollo
 * Fecha: 28/12/2015
 */

/*
 * Listado de Metodos:
 * >> SQLPedidos(string cs)
 * >> SQLPedidos()
 * >> List<PedidosWCF> ObtenerPedido()
 * >> PedidosWCF MapearPedido(TB_Pedido item)
 * >> TB_Pedido MapearPedido(PedidosWCF pedido)
 * >> void InsertarPedidos(PedidosWCF pedido)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFEntidades;

namespace WCFDAL
{
    public class SQLPedidos
    {
        private string cn;

        /* 
         * Metodo
         * Descripcion: Metodo constructor que recibe un parametro string
         * Entrada: string
         * Salida: void
         */
        public SQLPedidos(string cs)
        {
            this.cn = cs;
        }

        /* 
        * Metodo
        * Descripcion: Metodo constructor
        * Entrada: void
        * Salida: void
        */
        public SQLPedidos() { }

        /* 
         * Metodo
         * Descripcion: Retorna un listado de pedidos
         * Entrada: void
         * Salida: List<Pedidos>
         */
        public List<PedidosWCF> ObtenerPedido()
        {
            List<PedidosWCF> pedidos = new List<PedidosWCF>();

            using (DB_Acme_DevEntities contexto = new DB_Acme_DevEntities())
            {
                var SQLPedido = from pedido in contexto.TB_Pedido select pedido;

                foreach (var item in SQLPedido)
                {
                    PedidosWCF pedidoActual = MapearPedido(item);
                    pedidos.Add(pedidoActual);
                }
            }

            return (pedidos);
        }

        /* 
         * Metodo
         * Descripcion: Mapea los atributos de un pedido
         * Entrada: TB_Pedido
         * Salida: Pedidos
         */
        private PedidosWCF MapearPedido(TB_Pedido item)
        {
            PedidosWCF pedido = new PedidosWCF();

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
         * Descripcion: Mapea los atributos de un pedido
         * Entrada: PedidosWCF
         * Salida: TB_Pedido
         */
        private TB_Pedido MapearPedido(PedidosWCF pedido)
        {
            TB_Pedido Pedido = new TB_Pedido();
            Pedido.ID_Pedido = pedido.ID_Pedido;
            Pedido.ID_Cliente = pedido.ID_Cliente;
            Pedido.FechaRegistro = pedido.FechaRegistro;
            Pedido.TotalBruto = pedido.TotalBruto;
            Pedido.Impuesto = pedido.Impuesto;
            Pedido.ValorNeto = pedido.ValorNeto;
            Pedido.Estado = pedido.Estado;

            return Pedido;
        }

        /* 
        * Metodo
        * Descripcion: Insertar los pedidos que provienen del desconectado
        * Entrada: PedidosWCF
        * Salida: void
        */
        public void InsertarPedidos(PedidosWCF pedido)
        {
            using(DB_Acme_DevEntities contexto = new DB_Acme_DevEntities()){
                TB_Pedido Pedido = MapearPedido(pedido);
               
                contexto.InsertarPedidoOffline(
                    Pedido.ID_Cliente,
                    Pedido.FechaRegistro,
                    Pedido.TotalBruto,
                    Pedido.Impuesto,
                    Pedido.ValorNeto
                );
                contexto.SaveChanges();
            }
            
        }
    }
}
