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
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaEntrega { get; set; }
        public double TotalBruto { get; set; }
        public double Impuestos { get; set; }
        public double ValorNeto { get; set; }
        public bool Estado { get; set; }
    }
}
