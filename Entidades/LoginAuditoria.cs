/*
 * Nombre de la Clase: LoginAuditoria
 * Descripcion: Entidad que mapea la tabla TB_LoginAuditoria y la convierte en entidad de negocio para las otras capas
 * Autor: Equipo Makross - Grupo de Desarrollo
 * Fecha: 14/12/2015
 */

/*
 * Listado de Metodos:
 * >> 
 * >> 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LoginAuditoria
    {
        public int ID_Login { get; set; }
        public string NombreUsuario { get; set; }
        public System.DateTime FechaIngreso { get; set; }
    }
}
