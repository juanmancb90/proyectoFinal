/*
 * Nombre de la Clase: LoginAuditoriaDAL
 * Descripcion: Establecer una conexión a la base de datos
 * Autor: Equipo Makross - Grupo de Desarrollo
 * Fecha: 28/12/2015
 */

/*
 * Listado de Metodos:
 * >> SQLProductos(string cn)
 * >> List<ProductosWCF> ObtenerProducto()
 * >> ProductosWCF MapearProducto(TB_Producto item)
 */
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

        /* 
         * Metodo
         * Descripcion: Metodo constructor que recibe un parametro string
         * Entrada: string
         * Salida: void
         */
        public SQLProductos(string cn)
        {
            this.cs = cn;
        }

        /* 
         * Metodo
         * Descripcion: Retorna un listado de productos
         * Entrada: void
         * Salida: List<ProductosWCF>
         */
        public List<ProductosWCF> ObtenerProducto()
        {
            List<ProductosWCF> productos = new List<ProductosWCF>();

            using (DB_Acme_DevEntities contexto = new DB_Acme_DevEntities())
            {
                var SQLProducto = from producto in contexto.TB_Producto select producto;

                foreach (var item in SQLProducto)
                {
                    ProductosWCF productoActual = MapearProducto(item);
                    productos.Add(productoActual);
                }
            }

            return (productos);
        }

        /* 
         * Metodo
         * Descripcion: Mapea los atributos de un producto
         * Entrada: TB_Producto
         * Salida: ProductosWCF
         */
        private ProductosWCF MapearProducto(TB_Producto item)
        {
            ProductosWCF producto = new ProductosWCF();

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
