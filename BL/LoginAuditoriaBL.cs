using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class LoginAuditoriaBL
    {
        public LoginAuditoriaBL() { }

        public void RegistrarUsuario(string cs, string nombreUsuario)
        {
            LoginAuditoriaDAL contexto = new LoginAuditoriaDAL(cs);
            contexto.RegistrarUsuarioLogin(nombreUsuario);
        }
    }
}
