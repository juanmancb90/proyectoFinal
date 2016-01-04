/*
 * Nombre de la Clase: ProductosDAL
 * Descripcion: Establecer una conexión a la base de datos
 * Autor: Equipo Makross - Grupo de Desarrollo
 * Fecha: 14/12/2015
 */

/*
 * Listado de Metodos:
 * >> ProductosDAL(string cs)
 * >> List<Productos> ObtenerProducto()
 * >> void sincronizarProducto(Productos producto)
 * >> TB_Producto mapearProducto(Productos item)
 * >> Productos MapearProducto(TB_Producto item)
 */

using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;

namespace DAL
{
    public class ProductosDAL
    {
        private string cs;

        /* 
         * Metodo
         * Descripcion: Metodo constructor que recibe un parametro string
         * Entrada: string
         * Salida: void
         */
        public ProductosDAL(string cs)
        {
            this.cs = cs;
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

            using (DB_AcmeEntities contexto = new DB_AcmeEntities())
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
         * Descripcion: sincronizar un producto que proviene del Web Service
         * Entrada: Productos Producto
         * Salida: void
         */
        public void sincronizarProducto(Productos producto)
        {
            using (DB_AcmeEntities contexto = new DB_AcmeEntities())
            {
                try
                {
                    TB_Producto Producto = mapearProducto(producto);
                    ObjectParameter id = new ObjectParameter("ID_Producto", typeof(int));
                    contexto.SincronizarProducto(id, Producto.ID_Categoria, Producto.ID_Promocion, Producto.NombreProducto, Producto.Codigo, Producto.Descripcion, Producto.Fabricante, Producto.Stock, Producto.Impuesto, Producto.ValorUnitario, Producto.Estado);
                    contexto.SaveChanges();
                }
                catch (Exception e)
                {
                    e.ToString();
                }
            }
        }

        /* 
         * Metodo
         * Descripcion: Mapea los atributos de un producto
         * Entrada: Productos
         * Salida: Productos de entidad TB_Producto
         */
        private TB_Producto mapearProducto(Productos item)
        {
            TB_Producto Producto = new TB_Producto();
            Producto.ID_Producto = item.ID_Producto;
            Producto.ID_Categoria = item.ID_Categoria;
            Producto.ID_Promocion = item.ID_Promocion;
            Producto.NombreProducto = item.NombreProducto;
            Producto.Codigo = item.Codigo;
            Producto.Descripcion = item.Descripcion;
            Producto.Fabricante = item.Fabricante;
            Producto.Stock = item.Stock;
            Producto.Impuesto = item.Impuesto;
            Producto.ValorUnitario = item.ValorUnitario;
            Producto.Estado = item.Estado;
            return Producto;
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