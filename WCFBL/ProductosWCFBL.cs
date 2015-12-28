using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFEntidades;
using WCFDAL;

namespace WCFBL
{
    public class ProductosWCFBL
    {
        /* 
        * Metodo
        * Descripcion: Retornar un listado de productos
        * Entrada: string
        * Salida: List<Productos>
        */
        public List<ProductosWCF> ObtenerProductos(string cs)
        {
            SQLProductos contexto = new SQLProductos(cs);
            List<ProductosWCF> productos = contexto.ObtenerProducto();
            return (productos);
        }
    }
}
