﻿/*
 * Nombre de la Clase: DetallePedidosWCF
 * Descripcion: Entidad que mapea la tabla TB_DetallePedidos y la convierte en entidad de negocio para las otras capas
 * Autor: Equipo Makross - Grupo de Desarrollo
 * Fecha: 25/12/2015
 */

/*
 * Listado de Metodos:
 * >> 
 * >> 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFEntidades
{
    public class DetallePedidosWCF
    {
        public int ID_DetallePedido { get; set; }
        public int ID_Pedido { get; set; }
        public int ID_Producto { get; set; }
        public string Codigo { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Impuesto { get; set; }
        public decimal SubTotal { get; set; }
    }
}
