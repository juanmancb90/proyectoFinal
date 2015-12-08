using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using BL;
using Entidades;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            string cs = ConfigurationManager.ConnectionStrings[0].ConnectionString;
            
            try
            {
                /************ Productos **************/
                ProductosBL contexPro = new ProductosBL();
                List<Productos> productos = contexPro.ObtenerProductosBL(cs);
                foreach (var pro in productos)
                {
                    Console.WriteLine("Producto: ID = {0} - - - Nombre = {1}", pro.ID_Producto, pro.NombreProducto);
                }
                /************ Clientes ***********/
                Console.WriteLine();
                ClientesBL contextCl = new ClientesBL();
                List<Clientes> clientes = contextCl.ObtenerClientesBL(cs);
                foreach (var cl in clientes)
                {
                    Console.WriteLine("Cliente: ID = {0} - - - Nombre = {1}", cl.ID_Cliente, cl.NombreCompleto);
                }
                /******** Vendedores *******/
                Console.WriteLine();
                VendedoresBL contextVen = new VendedoresBL();
                List<Vendedores> vendedores = contextVen.ObtenerVendedoresBL(cs);
                foreach (var item in vendedores)
                {
                    Console.WriteLine("Vendedor: ID = {0} - - - Nombre = {1}", item.ID_Vendedor, item.NombreCompleto);
                }
                /********* Pedidos*******/
                Console.WriteLine();
                PedidosBL contextPed = new PedidosBL();
                List<Pedidos> pedidos = contextPed.ObtenerPedidosBL(cs);
                foreach (var ped in pedidos)
                {
                    Console.WriteLine("Pedido: ID = {0} - - - Cliente = {1} --- ValorNeto = {2}", ped.ID_Pedido, ped.ID_Cliente, ped.ValorNeto);
                }
                /******** Detalle Pedidos *******/
                Console.WriteLine();
                DetallePedidosBL contextDet = new DetallePedidosBL();
                List<DetallePedidos> detallePedidos = contextDet.ObtenerDetallePedidosBL(cs);
                foreach (var det in detallePedidos)
                {
                    Console.WriteLine("Detalle_Pedido: ID = {0} - - - Pedido = {1} - - - Producto = {2}", det.ID_DetallePedido, det.ID_Pedido, det.ID_Producto);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
        }
    }
}
