using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace DAL
{
    public class ProductosDAL
    {
        private string con;

        public ProductosDAL(string cs)
        {
            this.con = cs;
        }

        public List<Productos> ObtenerProductosDAL()
        {
            List<Productos> productos = new List<Productos>();
            using (DB_AcmeEntities contexto = new DB_AcmeEntities())
            {
                var productosEF = from pro in contexto.TB_Producto
                                  select pro;

                foreach (var item in productosEF)
                {
                    Productos proActual = MapearEmpleado(item);
                    productos.Add(proActual);
                }
            }
            return productos;
        }

        private Productos MapearEmpleado(TB_Producto item)
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
            producto.Imagen = item.Imagen;

            return producto;

        }
    }
}
