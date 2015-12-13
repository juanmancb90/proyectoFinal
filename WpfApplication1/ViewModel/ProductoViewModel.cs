using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace WpfApplication1.ViewModel
{
    public class ProductoViewModel : BaseViewModel
    {
        private int id_producto;
        private int id_categoria;
        private int id_promocion;
        private string nombreProducto;
        private string codigo;
        private string descripcion;
        private string fabricante;
        private int stock;
        private decimal impuesto;
        private decimal valorUnitario;
        private bool estado;
        private byte[] imagen;

        public int ID_Producto
        {
            get
            {
                return this.id_producto;
            }
            set
            {
                this.id_producto = value;
            }
        }

        public int ID_Categoria
        {
            get
            {
                return this.id_categoria;
            }
            set
            {
                this.id_categoria = value;
            }
        }

        public int ID_Promocion
        {
            get
            {
                return this.id_promocion;
            }
            set
            {
                this.id_promocion = value;
            }
        }

        public string NombreProducto
        {
            get
            {
                return this.nombreProducto;
            }
            set
            {
                this.nombreProducto = value;
            }
        }

        public string Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }

        public string Fabricante
        {
            get
            {
                return this.fabricante;
            }
            set
            {
                this.fabricante = value;
            }
        }

        public int Stock 
        {
            get
            {
                return this.stock;
            }
            set
            {
                this.stock = value;
            }
        }

        public decimal Impuesto
        {
            get
            {
                return this.impuesto;
            }
            set
            {
                this.impuesto = value;
            }
        }

        public decimal ValorUnitario 
        {
            get
            {
                return this.valorUnitario;
            }
            set
            {
                this.valorUnitario = value;
            }
        }

        public bool Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        public byte[] Imagen
        {
            get
            {
                return this.imagen;
            }
            set
            {
                this.imagen = value;
            }
        }

        public ProductoViewModel() { }

        public ProductoViewModel(Productos producto)
        {
            ID_Producto = producto.ID_Producto;
            ID_Categoria = producto.ID_Categoria;
            ID_Promocion = producto.ID_Promocion;
            NombreProducto = producto.NombreProducto;
            Codigo = producto.Codigo;
            Descripcion = producto.Descripcion;
            Fabricante = producto.Fabricante;
            Stock = producto.Stock;
            Impuesto = producto.Impuesto;
            ValorUnitario = producto.ValorUnitario;
            Estado = producto.Estado;
            Imagen = producto.Imagen;
        }
    }
}
