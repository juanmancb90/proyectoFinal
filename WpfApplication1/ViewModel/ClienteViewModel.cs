using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication1.ViewModel
{
    public class ClienteViewModel
    {
        private int id_cliente;
        private int id_vendedor;
        private int id_ciudad;
        private int id_documento;
        private string nombrecompleto;
        private string numerodocumento;
        private string telefono;
        private string celular;
        private string email;
        private string direccion;

        public int ID_Cliente
        {
            get
            {
                return this.id_cliente;
            }
            set
            {
                this.id_cliente = value;
            }
        }

        public int ID_Vendedor
        {
            get
            {
                return this.id_vendedor;
            }
            set
            {
                this.id_vendedor = value;
            }
        }

        public int ID_Ciudad
        {
            get
            {
                return this.id_ciudad;
            }
            set
            {
                this.id_ciudad = value;
            }
        }

        public int ID_Documento
        {
            get
            {
                return this.id_documento;
            }
            set
            {
                this.id_documento = value;
            }
        }

        public string NombreCompleto
        {
            get
            {
                return this.nombrecompleto;
            }
            set
            {
                this.nombrecompleto = value;
            }
        }

        public string NumeroDocumento
        {
            get
            {
                return this.numerodocumento;
            }
            set
            {
                this.numerodocumento = value;
            }
        }

        public string Telefono
        {
            get
            {
                return this.telefono;
            }
            set
            {
                this.telefono = value;
            }
        }

        public string Celular
        {
            get
            {
                return this.celular;
            }
            set
            {
                this.celular = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public string Direccion
        {
            get
            {
                return this.direccion;
            }
            set
            {
                this.direccion = value;
            }
        }

        public ClienteViewModel() { }

        public ClienteViewModel(Clientes cliente)
        {
            ID_Cliente = cliente.ID_Cliente;
            ID_Vendedor = cliente.ID_Vendedor;
            ID_Ciudad = cliente.ID_Ciudad;
            ID_Documento= cliente.ID_Documento;
            NombreCompleto = cliente.NombreCompleto;
            NumeroDocumento = cliente.NumeroDocumento;
            Telefono = cliente.Telefono;
            Celular = cliente.Celular;
            Email = cliente.Email;
            Direccion = cliente.Email;
        }
    }
}
