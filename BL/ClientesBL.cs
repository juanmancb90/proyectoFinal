using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace BL
{
    public class ClientesBL
    {
        public List<Clientes> ObtenerClientesBL(string cs)
        {
            ClientesDAL context = new ClientesDAL(cs);
            List<Clientes> cliente = context.ObtenerClientesDAL();

            return cliente;
        }
    }
}
