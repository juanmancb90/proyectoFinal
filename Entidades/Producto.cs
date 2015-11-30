using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public int ID_Producto { get; set; }
        public int ID_Categoria { get; set; }
        public int ID_Promocion { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Fabricante { get; set; }
        public int Stock { get; set; }
        public double Impuesto { get; set; }
        public double ValorUnitario { get; set; }
        public bool Estado { get; set; }
    }
}
