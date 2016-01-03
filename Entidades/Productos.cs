/*
 * Nombre de la Clase: Productos
 * Descripcion: Entidad que mapea la tabla TB_Productos y la convierte en entidad de negocio para las otras capas
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

namespace Entidades
{
    public class Productos
    {
        public int ID_Producto { get; set; }
        public int ID_Categoria { get; set; }
        public int ID_Promocion { get; set; }
        public string NombreProducto { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Fabricante { get; set; }
        public int Stock { get; set; }
        public decimal Impuesto { get; set; }
        public decimal ValorUnitario { get; set; }
        public bool Estado { get; set; }
    }
}
