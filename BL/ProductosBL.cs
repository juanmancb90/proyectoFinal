using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BL
{
    public class ProductosBL
    {
        public List<Productos> ObtenerProductosBL(string cs)
        {
            ProductosDAL context = new ProductosDAL(cs);
            List<Productos> producto = context.ObtenerProductosDAL();
            return producto;
        }
    }
}
