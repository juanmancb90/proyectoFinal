/*
 * Nombre de la Clase: LoginAuditoriaBL
 * Descripcion: Toma objetos de tipo SQLDetallePedidos creado desde la capa Data_Access_Layer y lo pasa a la capa User_Interface
 * Autor: Equipo Makross - Grupo de Desarrollo
 * Fecha: 14/12/2015
 */

/*
 * Listado de Metodos:
 * >> LoginAuditoriaBL()
 * >> void RegistrarUsuario(string cs, string nombreUsuario)
 */
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
        /* 
         * Metodo
         * Descripcion: Metodo constructor
         * Entrada: void
         * Salida: void
         */
        public LoginAuditoriaBL() { }

        /* 
         * Metodo
         * Descripcion: Retornar un listado de detalle pedidos
         * Entrada: string cs, string nombreUsuario
         * Salida: void
         */
        public void RegistrarUsuario(string cs, string nombreUsuario)
        {
            LoginAuditoriaDAL contexto = new LoginAuditoriaDAL(cs);
            contexto.RegistrarUsuarioLogin(nombreUsuario);
        }
    }
}
