using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Configuration;
using WCFBL;
//using WCFEntidades;

namespace WebServiceApi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class WebServiceApi : IWebServiceApi
    {
        private string cs = ConfigurationManager.ConnectionStrings[0].ConnectionString;

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string GetHelloWorld(string name)
        {
            return string.Format("Hello World: {0}",name);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string GetDataBL()
        {
            PedidosWCFBL context = new PedidosWCFBL();
            var dataBL = context.TestBLWcf();
            return dataBL;
        }

        public List<ProductosWCF> GetProductosWCFBL()
        {
            ProductosWCFBL contexto = new ProductosWCFBL();
            List<ProductosWCF> productos = new List<ProductosWCF>();
            var productosWCFBL = contexto.ObtenerProductos(cs);
            foreach (var item in productosWCFBL)
            {
                ProductosWCF productoAct = new ProductosWCF { 
                    ID_Producto = item.ID_Producto, 
                    ID_Categoria = item.ID_Categoria,
                    ID_Promocion = item.ID_Promocion,
                    NombreProducto = item.NombreProducto,
                    Codigo = item.Codigo,
                    Descripcion = item.Descripcion,
                    Fabricante = item.Fabricante,
                    Stock = item.Stock,
                    Impuesto = item.Impuesto,
                    ValorUnitario = item.ValorUnitario,
                    Estado = item.Estado
                };
                productos.Add(productoAct);
            }
            return productos;
        }
    }
}
