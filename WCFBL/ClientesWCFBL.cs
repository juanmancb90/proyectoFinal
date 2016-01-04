/*
 * Nombre de la Clase: ClientesWCFBL
 * Descripcion: Toma objetos de tipo SQLPedidos creado desde la capa Data_Access_Layer y lo pasa a la capa User_Interface
 * Autor: Equipo Makross - Grupo de Desarrollo
 * Fecha: 14/12/2015
 */

/*
 * Listado de Metodos:
 * >> public List<ClientesWCF> ObtenerClientes(string cs)
 * >> void InsertarClienteBL(String cs, ClientesWCF idCliente = null)
 * >> void ActualizarClienteBL(String cs, ClientesWCF idCliente = null)
 * >> void EliminarClienteBL(String cs, ClientesWCF idCliente = null)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFEntidades;
using WCFDAL;

namespace WCFBL
{
    public class ClientesWCFBL
    {
        /* 
         * Metodo
         * Descripcion: Retornar un listado de clientes
         * Entrada: string
         * Salida: List<ClientesWCF>
         */
        public List<ClientesWCF> ObtenerClientes(string cs)
        {
            SQLClientes contexto = new SQLClientes(cs);
            List<ClientesWCF> clientes = contexto.ObtenerCliente();
            return (clientes);
        }

        /* 
         * Metodo
         * Descripcion: Insertar un cliente
         * Entrada: String cs, ClientesWCF idCliente = null
         * Salida: void
         */
        public void InsertarClienteBL(String cs, ClientesWCF idCliente = null)
        {
            SQLClientes contexto = new SQLClientes(cs);
            if (idCliente != null)
            {
                contexto.InsertarCliente(idCliente);
            }
        }

        /* 
         * Metodo
         * Descripcion: Actualizar un cliente
         * Entrada: String cs, ClientesWCF idCliente = null
         * Salida: void
         */
        public void ActualizarClienteBL(String cs, ClientesWCF idCliente = null)
        {
            SQLClientes contexto = new SQLClientes(cs);
            if (idCliente != null)
            {
                contexto.ActualizarCliente(idCliente);
            }
        }

        /* 
         * Metodo
         * Descripcion: Eliminar un cliente
         * Entrada: String cs, ClientesWCF idCliente = null
         * Salida: void
         */
        public void EliminarClienteBL(String cs, ClientesWCF idCliente = null)
        {
            SQLClientes contexto = new SQLClientes(cs);
            if (idCliente != null)
            {
                contexto.EliminarCliente(idCliente.ID_Cliente);
            }
        }
    }
}
