using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace BL
{
    public class VendedoresBL
    {
        public List<Vendedores> ObtenerVendedoresBL(string cs)
        {
            VendedoresDAL contex = new VendedoresDAL(cs);
            List<Vendedores> vendedor = contex.ObtenerVendedoresDAL();

            return vendedor;
        }
    }
}
