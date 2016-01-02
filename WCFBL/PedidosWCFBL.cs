﻿using System;
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
