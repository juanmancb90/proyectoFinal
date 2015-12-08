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
                ProductosBL contex = new ProductosBL();
                List<Productos> productos = contex.ObtenerProductosBL(cs);
                foreach (var pro in productos)
                {
                    Console.WriteLine("Producto: ID = {0} --- Nombre = {1}", pro.ID_Producto, pro.NombreProducto);
                }
                Console.WriteLine();
                ClientesBL context = new ClientesBL();
                List<Clientes> clientes = context.ObtenerClientesBL(cs);
                foreach (var cl in clientes)
                {
                    Console.WriteLine("Cliente: ID={0} - - - Nombre = {1}", cl.ID_Cliente, cl.NombreCompleto);
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
