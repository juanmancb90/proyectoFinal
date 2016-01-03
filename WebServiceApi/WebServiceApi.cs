/*
 * Nombre de la Clase: WebServiceApi
 * Descripcion: Clase que implementa los metodos del interfaz del Web Service
 * Autor: Equipo Makross - Grupo de Desarrollo
 * Fecha: 28/12/2015
 */

/*
 * Listado de Metodos:
 * >> string GetProductosWCFBL()
 * >> bool SetPedidosWCFBL(string pedidos)
 * >> bool SetDetallePedidosWCFBL(string detallePedidos)
 * >> List<PedidosWCF> DesencriptarPedidos(string data)
 * >> List<DetallePedidosWCF> DesencriptarDetallePedidos(string data)
 * >> String EncriptarProductos(List<ProductosWCF> productos)
 */
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

        /* 
         * Metodo
         * Descripcion: Retornar un listado de producto que van a ser sincronizados
         * Entrada: void
         * Salida: string
         */
        public string GetProductosWCFBL()
        {
            ProductosWCFBL context = new ProductosWCFBL();
            List<ProductosWCF> productos = context.ObtenerProductos(cs);
            string productosEncriptados = EncriptarProductos(productos);

            return productosEncriptados;
        }

        /* 
         * Metodo
         * Descripcion: Sinconizar un listado de pedidos encriptados
         * Entrada: string pedidos
         * Salida: bool
         */
        public bool SetPedidosWCFBL(string pedidos)
        {
            bool rst;
            var Pedidos = DesencriptarPedidos(pedidos);
            PedidosWCFBL contexto = new PedidosWCFBL();
            if (Pedidos != null)
            {
                foreach (var item in Pedidos)
                {
                    contexto.SincronizarPedidos(cs, item);
                }

                rst = true;
            }
            else
            {
                rst = false;
            }

            return rst;
        }

        /* 
         * Metodo
         * Descripcion: sincroniza un listado de detalles de pedidos sincronizados
         * Entrada: string detallePedidos
         * Salida: bool
         */
        public bool SetDetallePedidosWCFBL(string detallePedidos)
        {
            bool rst;
            var DetallePedidos = DesencriptarDetallePedidos(detallePedidos);
            DetallePedidosWCFBL contexto = new DetallePedidosWCFBL();
            if (DetallePedidos != null) {
                foreach (var item in DetallePedidos)
                {
                    contexto.SincronizarDetallePedidos(cs, item);
                }

                rst = true;
            }
            else 
            {
                rst = false;
            }

            return rst;
        }

        /* 
         * Metodo
         * Descripcion: Desencripta la cadena de string correspondiente al listado de pedidos
         * Entrada: string data
         * Salida: List<PedidosWCF>
         */
        private List<PedidosWCF> DesencriptarPedidos(string data)
        {
            List<PedidosWCF> Pedidos = new List<PedidosWCF>();
            byte[] decripter = Convert.FromBase64String(data);
            string cadena = Encoding.Unicode.GetString(decripter);
            string[] pedidos = cadena.Split('#');
            for (int i = 0; i < pedidos.Length; i++)
            {
                string[] pedido = pedidos[i].Split('¿');
                PedidosWCF Pedido = new PedidosWCF();
                Pedido.ID_Pedido = Convert.ToInt32(pedido[0]);
                Pedido.ID_Cliente = Convert.ToInt32(pedido[1]);
                Pedido.FechaRegistro = Convert.ToDateTime(pedido[2]);
                Pedido.TotalBruto = Convert.ToDecimal(pedido[3]);
                Pedido.Impuesto = Convert.ToDecimal(pedido[4]);
                Pedido.ValorNeto = Convert.ToDecimal(pedido[5]);
                Pedido.Estado = Convert.ToBoolean(pedido[6]);
                Pedidos.Add(Pedido);
            }

            return Pedidos;
        }

        /* 
         * Metodo
         * Descripcion: Desencripta la cadena de string correspondiente al listado de detalle de pedidos
         * Entrada: string data
         * Salida: List<DetallePedidosWCF>
         */
        private List<DetallePedidosWCF> DesencriptarDetallePedidos(string data)
        {
            List<DetallePedidosWCF> DetallePedidos = new List<DetallePedidosWCF>();
            byte[] decripter = Convert.FromBase64String(data);
            string cadena = Encoding.Unicode.GetString(decripter);
            string[] detallespedidos = cadena.Split(':');
            for (int i = 0; i < detallespedidos.Length; i++)
            {
                string[] detallepedido = detallespedidos[i].Split('¿');
                DetallePedidosWCF DetallePedido = new DetallePedidosWCF();
                DetallePedido.ID_DetallePedido = Convert.ToInt32(detallepedido[0]);
                DetallePedido.ID_Pedido = Convert.ToInt32(detallepedido[1]);
                DetallePedido.ID_Producto = Convert.ToInt32(detallepedido[2]);
                DetallePedido.Codigo = detallepedido[3];
                DetallePedido.NombreProducto = detallepedido[4];
                DetallePedido.Descripcion = detallepedido[5];
                DetallePedido.Cantidad = Convert.ToInt32(detallepedido[6]);
                DetallePedido.ValorUnitario = Convert.ToDecimal(detallepedido[7]);
                DetallePedido.Impuesto = Convert.ToDecimal(detallepedido[8]);
                DetallePedido.SubTotal = Convert.ToDecimal(detallepedido[9]);
                DetallePedidos.Add(DetallePedido);
            }

            return DetallePedidos;
        }

        /* 
         * Metodo
         * Descripcion: Encripta un listado de producto que van a ser sincronizados
         * Entrada: List<ProductosWCF> productos
         * Salida: String
         */
        private String EncriptarProductos(List<ProductosWCF> productos)
        {
            bool primerProducto = true;
            var cadena = new StringBuilder();
            foreach (var item in productos)
            {
                if (primerProducto)
                {
                    primerProducto = false;
                    cadena.Append(item.ID_Producto.ToString());
                    cadena.Append(string.Format("¿{0}", item.ID_Categoria.ToString()));
                    cadena.Append(string.Format("¿{0}", item.ID_Promocion.ToString()));
                    cadena.Append(string.Format("¿{0}", item.NombreProducto.ToString()));
                    cadena.Append(string.Format("¿{0}", item.Codigo.ToString()));
                    cadena.Append(string.Format("¿{0}", item.Descripcion.ToString()));
                    cadena.Append(string.Format("¿{0}", item.Fabricante.ToString()));
                    cadena.Append(string.Format("¿{0}", item.Stock.ToString()));
                    cadena.Append(string.Format("¿{0}", item.Impuesto.ToString()));
                    cadena.Append(string.Format("¿{0}", item.ValorUnitario.ToString()));
                    cadena.Append(string.Format("¿{0}", item.Estado.ToString()));
                }
                else
                {
                    cadena.Append(string.Format(":{0}", item.ID_Producto.ToString()));
                    cadena.Append(string.Format("¿{0}", item.ID_Categoria.ToString()));
                    cadena.Append(string.Format("¿{0}", item.ID_Promocion.ToString()));
                    cadena.Append(string.Format("¿{0}", item.NombreProducto.ToString()));
                    cadena.Append(string.Format("¿{0}", item.Codigo.ToString()));
                    cadena.Append(string.Format("¿{0}", item.Descripcion.ToString()));
                    cadena.Append(string.Format("¿{0}", item.Fabricante.ToString()));
                    cadena.Append(string.Format("¿{0}", item.Stock.ToString()));
                    cadena.Append(string.Format("¿{0}", item.Impuesto.ToString()));
                    cadena.Append(string.Format("¿{0}", item.ValorUnitario.ToString()));
                    cadena.Append(string.Format("¿{0}", item.Estado.ToString()));
                }
            }

            byte[] encripted = Encoding.Unicode.GetBytes(cadena.ToString());
            string salida = Convert.ToBase64String(encripted);

            return salida;
        }
    }
}
