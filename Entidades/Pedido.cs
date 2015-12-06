using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        public int ID_Pedido { get; set; }
        public int ID_Cliente { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public System.DateTime FechaEntrega { get; set; }
        public decimal TotalBruto { get; set; }
        public decimal Impuesto { get; set; }
        public decimal ValorNeto { get; set; }
        public bool Estado { get; set; }
    }
}
