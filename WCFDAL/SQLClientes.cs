/*
 * Nombre de la Clase: SQLClientes
 * Descripcion: Establecer una conexión a la base de datos
 * Autor: Equipo Makross - Grupo de Desarrollo
 * Fecha: 28/12/2015
 */

/*
 * Listado de Metodos:
 * >> SQLClientes(string cs)
 * >> List<ClientesWCF> ObtenerCliente()
 * >> ClientesWCF MapearCliente(TB_Cliente item)
 * >> void InsertarCliente(ClientesWCF cliente)
 * >> void ActualizarCliente(ClientesWCF cliente)
 * >> TB_Cliente mapearProducto(ClientesWCF item)
 * >> void EliminarCliente(int idCliente)
 */
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFEntidades;

namespace WCFDAL
{
    public class SQLClientes
    {
        private string cs;

        /* 
        * Metodo
        * Descripcion: Metodo constructor que recibe un parametro string
        * Entrada: string
        * Salida: void
        */
        public SQLClientes(string cs)
        {
            this.cs = cs;
        }


        /* 
        * Metodo
        * Descripcion: Metodo cque retorna un listado de clientes
        * Entrada: void
        * Salida:  List<ClientesWCF>
        */
        public List<ClientesWCF> ObtenerCliente()
        {
            List<ClientesWCF> clientes = new List<ClientesWCF>();

            using (DB_Acme_DevEntities contexto = new DB_Acme_DevEntities())
            {
                var SQLCliente = from cliente in contexto.TB_Cliente select cliente;
                foreach (var item in SQLCliente)
                {
                    ClientesWCF clienteActual = MapearCliente(item);
                    clientes.Add(clienteActual);
                }
            }

            return (clientes);
        }

        /* 
         * Metodo
         * Descripcion: Mapea la Entidad
         * Entrada: TB_Cliente item
         * Salida: ClientesWCF
         */
        private ClientesWCF MapearCliente(TB_Cliente item)
        {
            ClientesWCF cliente = new ClientesWCF();

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

        #region InsertarCliente
        /* 
         * Metodo
         * Descripcion: Insertar un cliente
         * Entrada: ClientesWCF cliente
         * Salida: void
         */
        public void InsertarCliente(ClientesWCF cliente)
        {
            using (DB_Acme_DevEntities contexto = new DB_Acme_DevEntities())
            {
                try
                {
                    TB_Cliente Cliente = mapearProducto(cliente);
                    ObjectParameter idCliente = new ObjectParameter("ID_Cliente", typeof(int));
                    contexto.InsertarCliente(idCliente, Cliente.ID_Vendedor, Cliente.ID_Ciudad, Cliente.ID_Documento, Cliente.NombreCompleto, Cliente.NumeroDocumento, Cliente.Telefono, Cliente.Celular, Cliente.Email, Cliente.Direccion);
                    contexto.SaveChanges();
                }
                catch (Exception e)
                {
                    e.ToString();
                }
            }
        }

        #endregion
        
        #region ACTUALIZAR CLIENTE
        /* 
         * Metodo
         * Descripcion: Actualizar un cliente
         * Entrada: ClientesWCF cliente
         * Salida: void
         */
        public void ActualizarCliente(ClientesWCF cliente)
        {
            using (DB_Acme_DevEntities contexto = new DB_Acme_DevEntities())
            {
                try
                {
                    TB_Cliente Cliente = mapearProducto(cliente);
                    ObjectParameter idCliente = new ObjectParameter("ID_Cliente", typeof(int));
                    contexto.ActualizarCliente(idCliente, Cliente.ID_Vendedor, Cliente.ID_Ciudad, Cliente.ID_Documento, Cliente.NombreCompleto, Cliente.NumeroDocumento, Cliente.Telefono, Cliente.Celular, Cliente.Email, Cliente.Direccion);
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
        * Descripcion: Mapear la entidad
        * Entrada: ClientesWCF item
        * Salida: TB_Cliente
        */
        private TB_Cliente mapearProducto(ClientesWCF item)
        {
            TB_Cliente cliente = new TB_Cliente();
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
            return cliente;
        }
        #endregion

        #region ELIMINAR CLIENTE
        /* 
         * Metodo
         * Descripcion: Eliminar un cliente
         * Entrada: int idCliente
         * Salida: void
         */
        public void EliminarCliente(int idCliente)
        {
            using (DB_Acme_DevEntities contexto = new DB_Acme_DevEntities())
            {
                contexto.EliminarCliente(idCliente);
                contexto.SaveChanges();
            }
        }
        #endregion
    }
}
