/*
 * Nombre de la Clase: ClientesBL
 * Descripcion: Toma el objeto de tipo SQLClientes creado desde la capa Data_Access_Layer y lo pasa a la capa User_Interface
 * Autor: Equipo Makross - Grupo de Desarrollo
 * Fecha: 14/12/2015
 */

/*
 * Listado de Metodos:
 * >> List<Clientes> ObtenerClientes(string cs)
 * >> void SincronizarClientesBL(String cs, Clientes cliente = null)
 */

using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class ClientesBL
    {
        /* 
         * Metodo
         * Descripcion: Retornar un listado de clientes
         * Entrada: string
         * Salida: List<Clientes>
         */
        public List<Clientes> ObtenerClientes(string cs)
        {
            ClientesDAL contexto = new ClientesDAL(cs);
            List<Clientes> clientes = contexto.ObtenerCliente();
            return (clientes);
        }

        /* 
         * Metodo
         * Descripcion: sincroniza un listado de clientes
         * Entrada: String cs, Clientes cliente = null
         * Salida: void
         */
        public void SincronizarClientesBL(String cs, Clientes cliente = null)
        {
            ClientesDAL contexto = new ClientesDAL(cs);
            if (cliente != null)
            {
                contexto.sincronizarCliente(cliente);
            }
        }
    }
}
