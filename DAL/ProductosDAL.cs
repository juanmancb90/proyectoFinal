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

        public List<Productos> ObtenerProductos()
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
            /*producto.ID = item.ID;
            producto.Nombre = item.Nombre;
            producto.IDEmpresa = item.IDEmpresa;
            producto.FechaNacimiento = item.FechaNacimiento;
            producto.Numerodocumento = item.NombreProducto;*/

            return producto;

        }
    }
}
