/*
 * Nombre de la Clase: LoginAuditoriaDAL
 * Descripcion: Establecer una conexión a la base de datos
 * Autor: Equipo Makross - Grupo de Desarrollo
 * Fecha: 28/12/2015
 */

/*
 * Listado de Metodos:
 * >> LoginAuditoriaDAL(string cs) 
 * >> void RegistrarUsuarioLogin(string nombreUsuario)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    public class LoginAuditoriaDAL
    {
        private string cn;

        /* 
         * Metodo
         * Descripcion: Metodo constructor que recibe un parametro string
         * Entrada: string
         * Salida: void
         */
        public LoginAuditoriaDAL(string cs) 
        {
            this.cn = cs;
        }

        /* 
         * Metodo
         * Descripcion: Metodo que registra el usuario que acaba de logearse
         * Entrada: string
         * Salida: void
         */
        public void RegistrarUsuarioLogin(string nombreUsuario)
        {
            using (DB_AcmeEntities contexto = new DB_AcmeEntities())
            {
                contexto.InsertarUsuarioLogin(nombreUsuario);
                contexto.SaveChanges();
            }
        }
    }
}
