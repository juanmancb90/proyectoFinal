using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Modelo
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public bool Oferta { get; set; }
    }
}
