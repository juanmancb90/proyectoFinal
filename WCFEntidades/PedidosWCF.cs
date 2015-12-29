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
