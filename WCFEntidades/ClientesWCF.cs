/*
 * Nombre de la Clase: ClientesWCF
 * Descripcion: Entidad que mapea la tabla TB_Clientes y la convierte en entidad de negocio para las otras capas
 * Autor: Equipo Makross - Grupo de Desarrollo
 * Fecha: 28/12/2015
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

namespace WCFEntidades
{
    public class ClientesWCF
    {
        public int ID_Cliente { get; set; }
        public int ID_Vendedor { get; set; }
        public int ID_Ciudad { get; set; }
        public int ID_Documento { get; set; }
        public string NombreCompleto { get; set; }
        public string NumeroDocumento { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
    }
}
