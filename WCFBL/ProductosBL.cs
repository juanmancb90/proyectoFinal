using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFEntidades;
using WCFDAL;

namespace WCFBL
{
    public class ProductosBL
    {
        /* 
        * Metodo
        * Descripcion: Retornar un listado de productos
        * Entrada: string
        * Salida: List<Productos>
        */
        public List<Productos> ObtenerProductos(string cs)
        {
            SQLProductos contexto = new SQLProductos(cs);
            List<Productos> productos = contexto.ObtenerProducto();
            return (productos);
        }
    }
}
