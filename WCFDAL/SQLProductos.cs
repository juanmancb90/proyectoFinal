using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFEntidades;

namespace WCFDAL
{
    public class SQLProductos
    {
        private string cs;
        
        public SQLProductos(string cn)
        {
            this.cs = cn;
        }

        /* 
         * Metodo
         * Descripcion: Retorna un listado de productos
         * Entrada: void
         * Salida: List<Productos>
         */
        public List<Productos> ObtenerProducto()
        {
            List<Productos> productos = new List<Productos>();

            using (DB_Acme_DevEntities contexto = new DB_Acme_DevEntities())
            {
                var SQLProducto = from producto in contexto.TB_Producto select producto;

                foreach (var item in SQLProducto)
                {
                    Productos productoActual = MapearProducto(item);
                    productos.Add(productoActual);
                }
            }

            return (productos);
        }

        /* 
         * Metodo
         * Descripcion: Mapea los atributos de un producto
         * Entrada: TB_Producto
         * Salida: Productos
         */
        private Productos MapearProducto(TB_Producto item)
        {
            Productos producto = new Productos();

            producto.ID_Producto = item.ID_Producto;
            producto.ID_Categoria = item.ID_Categoria;
            producto.ID_Promocion = item.ID_Promocion;
            producto.NombreProducto = item.NombreProducto;
            producto.Codigo = item.Codigo;
            producto.Descripcion = item.Descripcion;
            producto.Fabricante = item.Fabricante;
            producto.Stock = item.Stock;
            producto.Impuesto = item.Impuesto;
            producto.ValorUnitario = item.ValorUnitario;
            producto.Estado = item.Estado;

            return (producto);
        }
    }
}
