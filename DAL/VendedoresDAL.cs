using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    public class VendedoresDAL
    {
        private string con;

        public VendedoresDAL(string cs)
        {
            this.con = cs;
        }

        public List<Vendedores> ObtenerVendedoresDAL()
        {
            List<Vendedores> vendedores = new List<Vendedores>();
            using(DB_AcmeEntities contex = new DB_AcmeEntities()){
                var vendedoresEF = from ven in contex.TB_Vendedor
                               select ven;
                foreach (var item in vendedoresEF)
                {
                    Vendedores vendedorAct = MapearVendedores(item);
                    vendedores.Add(vendedorAct);
                }
            }
            return vendedores;
        }

        private Vendedores MapearVendedores(TB_Vendedor item)
        {
            Vendedores vendedor = new Vendedores();
            vendedor.ID_Vendedor = item.ID_Vendedor;
            vendedor.NombreCompleto = item.NombreCompleto;
            vendedor.NumeroDocumento = item.NumeroDocumento;
            vendedor.NombreUsuario = item.NombreUsuario;
            vendedor.Contrasenia = item.Contrasenia;
            
            return vendedor;
        }
    }
}
