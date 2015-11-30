using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetallePedido
    {
        public int ID_DetallePedido { get; set; }
        public int ID_Pedido { get; set; }
        public int ID_Prducto { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public double ValorUnitario { get; set; }
        public double SubTotal { get; set; }
         
    }
}
