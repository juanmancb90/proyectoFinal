using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Configuration;
using WCFBL;
using WCFEntidades;

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

        public string GetDataBL()
        {
            PedidosWCFBL context = new PedidosWCFBL();
            var dataBL = context.TestBLWcf();
            return dataBL;
        }

        public List<ProductosWCF> GetProductosWCFBL()
        {
            ProductosWCFBL context = new ProductosWCFBL();
            List<ProductosWCF> productos = context.ObtenerProductos(cs);
            return productos;
        }

        public bool SetPedidosWCFBL(List<PedidosWCF> pedidos)
        {
            bool rst = false;
            return rst;
        }

        public bool SetDetallePedidosWCFBL(DetallePedidosWCF[] detallePedidos)
        {
            bool rst = false;

            return rst;
        }
    }
}
