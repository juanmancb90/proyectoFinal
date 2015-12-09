using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    public class ClientesDAL
    {
        private string con;

        public ClientesDAL(string cs)
        {
            this.con = cs;
        }

        public List<Clientes> ObtenerClientesDAL()
        {
            List<Clientes> clientes = new List<Clientes>();
            using (DB_AcmeEntities contex = new DB_AcmeEntities())
            {
                var clientesEF = from cl in contex.TB_Cliente
                                 select cl;

                foreach (var item in clientesEF)
                {
                    Clientes clienteAct = MapearClientes(item);
                    clientes.Add(clienteAct);
                }
            }
            return clientes;
        }

        private Clientes MapearClientes(TB_Cliente item)
        {
            Clientes cliente = new Clientes();
            cliente.ID_Cliente = item.ID_Cliente;
            cliente.ID_Vendedor = item.ID_Vendedor;
            cliente.ID_Ciudad = item.ID_Ciudad;
            cliente.ID_Documento = item.ID_Documento;
            cliente.NombreCompleto = item.NombreCompleto;
            cliente.NumeroDocumento = item.NumeroDocumento;
            cliente.Telefono = item.Telefono;
            cliente.Celular = item.Celular;
            cliente.Email = item.Email;
            cliente.Direccion = item.Direccion;

            return cliente;
        }
    }
}
