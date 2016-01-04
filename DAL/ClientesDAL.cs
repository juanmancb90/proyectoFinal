/*
 * Nombre de la Clase: ClientesDAL
 * Descripcion: Establecer una conexión a la base de datos
 * Autor: Equipo Makross - Grupo de Desarrollo
 * Fecha: 14/12/2015
 */

/*
 * Listado de Metodos:
 * >> ClientesDAL(string cs)
 * >> List<Clientes> ObtenerCliente()
 * >> Clientes MapearCliente(TB_Cliente item)
 * >> TB_Cliente mapearCliente(Clientes item)
 * >> void sincronizarCliente(Clientes cliente)
 */

using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;

namespace DAL
{
    public class ClientesDAL
    {
        private string cs;

        /* 
         * Metodo
         * Descripcion: Metodo constructor que recibe un parametro string
         * Entrada: string
         * Salida: void
         */
        public ClientesDAL(string cs)
        {
            this.cs = cs;
        }

        /* 
         * Metodo
         * Descripcion: Retorna un listado de clientes
         * Entrada: void
         * Salida: List<Clientes>
         */
        public List<Clientes> ObtenerCliente()
        {
            List<Clientes> clientes = new List<Clientes>();

            using (DB_AcmeEntities contexto = new DB_AcmeEntities())
            {
                var SQLCliente = from cliente in contexto.TB_Cliente select cliente;

                foreach (var item in SQLCliente)
                {
                    Clientes clienteActual = MapearCliente(item);
                    clientes.Add(clienteActual);
                }
            }

            return (clientes);
        }

        /* 
         * Metodo
         * Descripcion: Mapea los atributos de un cliente
         * Entrada: TB_Cliente
         * Salida: Clientes
         */
        private Clientes MapearCliente(TB_Cliente item)
        {
            Clientes cliente = new Clientes();

            cliente.ID_Cliente = item.ID_Cliente;
            cliente.ID_Vendedor = item.ID_Vendedor;
            cliente.ID_Ciudad = item.ID_Ciudad;
            cliente.ID_Documento = item.ID_Documento;
            cliente.NombreCompleto = item.NombreCompleto;
            cliente.NumeroDocumento = item.NumeroDocumento;
            cliente.Telefono = item.Telefono;
            cliente.Celular = item.Celular;
            cliente.Email = item.Email;
            cliente.Direccion = item.Direccion;

            return (cliente);
        }

        /* 
         * Metodo
         * Descripcion: sincronizar los clientes
         * Entrada: Clientes cliente
         * Salida: void
         */
        public void sincronizarCliente(Clientes cliente)
        {
            using (DB_AcmeEntities contexto = new DB_AcmeEntities())
            {
                try
                {
                    TB_Cliente Cliente = mapearCliente(cliente);
                    ObjectParameter idCliente = new ObjectParameter("ID_Cliente", typeof(int));
                    contexto.SincronizarCliente(idCliente, Cliente.ID_Vendedor, Cliente.ID_Ciudad, Cliente.ID_Documento, Cliente.NombreCompleto, Cliente.NumeroDocumento, Cliente.Telefono, Cliente.Celular, Cliente.Email, Cliente.Direccion);
                    contexto.SaveChanges();
                }
                catch (Exception e)
                {
                    e.ToString();
                }
            }
        }

        /* 
         * Metodo
         * Descripcion: Mapea los atributos de un cliente
         * Entrada: Clientes item
         * Salida: TB_Cliente
         */
        private TB_Cliente mapearCliente(Clientes item)
        {
            TB_Cliente Cliente = new TB_Cliente();
            Cliente.ID_Cliente = item.ID_Cliente;
            Cliente.ID_Vendedor = item.ID_Vendedor;
            Cliente.ID_Ciudad = item.ID_Ciudad;
            Cliente.ID_Documento = item.ID_Documento;
            Cliente.NombreCompleto = item.NombreCompleto;
            Cliente.NumeroDocumento = item.NumeroDocumento;
            Cliente.Telefono = item.Telefono;
            Cliente.Celular = item.Celular;
            Cliente.Email = item.Email;
            Cliente.Direccion = item.Direccion;
            return Cliente;
        }
    }
}