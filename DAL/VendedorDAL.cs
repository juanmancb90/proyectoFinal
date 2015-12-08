using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VendedorDAL
    {
        private string con;

        public VendedorDAL(string cs)
        {
            this.con = cs;
        }
    }
}
