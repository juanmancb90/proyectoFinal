/*
 * Nombre de la Clase: ProductosBL
 * Descripcion: Toma el objeto de tipo SQLProductos creado desde la capa Data_Access_Layer y lo pasa a la capa User_Interface
 * Autor: Equipo Makross - Grupo de Desarrollo
 * Fecha: 14/12/2015
 */

/*
 * Listado de Metodos:
 * >> List<Productos> ObtenerProductos(string cs)
 */

using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
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
            ProductosDAL contexto = new ProductosDAL(cs);
            List<Productos> productos = contexto.ObtenerProducto();
            return (productos);
        }

        public void ActualizarProducto(List<Productos> item, string cs)
        {
            throw new NotImplementedException();
        }

    }
}
