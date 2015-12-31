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

        public void SincronizarProductosBL(String cs, Productos producto = null)
        {
            ProductosDAL contexto = new ProductosDAL(cs);
            //bool rst = false;
            if (producto == null)
            {
                producto = new Productos();
                producto.ID_Producto = 1;
                producto.ID_Categoria = 1;
                producto.ID_Promocion = 1;
                producto.NombreProducto = "prueba";
                producto.Codigo = "1234567";
                producto.Descripcion = "esto es un aprueba";
                producto.Fabricante = "prueba1";
                producto.Stock = 5;
                producto.Impuesto = (decimal)0.16;
                producto.ValorUnitario = 800;
                producto.Estado = true;
            }
            else
            {
                List<Productos> productosDAL = contexto.ObtenerProducto();

                if (productosDAL.Exists(x => x.ID_Producto == producto.ID_Producto))
                {
                    contexto.actualizarProductos(producto);
                }
                else if (productosDAL.Exists(x => x.ID_Producto == producto.ID_Producto) == false)
                {
                    contexto.insertarProductos(producto);
                }
            }
           
        }
    }
}
