/*
 * Nombre de la Clase: PedidosWCF
 * Descripcion: Entidad que mapea la tabla TB_Pedidos y la convierte en entidad de negocio para las otras capas
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
    public class PedidosWCF
    {
        public int ID_Pedido { get; set; }
        public int ID_Cliente { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public decimal TotalBruto { get; set; }
        public decimal Impuesto { get; set; }
        public decimal ValorNeto { get; set; }
        public bool Estado { get; set; }
    }
}
