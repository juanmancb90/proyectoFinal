/*
 * Nombre de la Clase: ProductosWCFBL
 * Descripcion: Toma el objeto de tipo SQLProductos creado desde la capa Data_Access_Layer y lo pasa a la capa User_Interface
 * Autor: Equipo Makross - Grupo de Desarrollo
 * Fecha: 14/12/2015
 */

/*
 * Listado de Metodos:
 * >> List<ProductosWCF> ObtenerProductos(string cs)
 */
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
