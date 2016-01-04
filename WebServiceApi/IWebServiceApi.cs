/*
 * Nombre de la Clase: IWebServiceApi
 * Descripcion: Interface que define los ServiceContract y OperationContract que expondra el servicio web
 * Autor: Equipo Makross - Grupo de Desarrollo
 * Fecha: 28/12/2015
 */

/*
 * Listado de Metodos:
 * >> string GetProductosWCFBL();
 * >> bool SetPedidosWCFBL(string pedidos);
 * >> bool SetDetallePedidosWCFBL(string detallePedidos);
 * >> string GetClientesWCFBL();
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFEntidades;

namespace WebServiceApi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWebServiceApi
    {
        /* 
         * Metodo
         * Descripcion: Metodo para obtener los Productos del inventario central
         * Entrada: void
         * Salida: string
         */
        [OperationContract]
        string GetProductosWCFBL();

        /* 
         * Metodo
         * Descripcion: Metodo para obtener los Productos del inventario central
         * Entrada: void
         * Salida: string
         */
        [OperationContract]
        string GetClientesWCFBL();

        /* 
         * Metodo
         * Descripcion: Metodo sincronizar los pedidos del desconectado al sistema central
         * Entrada: string pedidos
         * Salida: bool
         */
        [OperationContract]
        bool SetPedidosWCFBL(string pedidos);

        /* 
         * Metodo
         * Descripcion: Metodo sincronizar los detalles de pedidos del desconectado al sistema central
         * Entrada: string detallePedidos
         * Salida: bool
         */
        [OperationContract]
        bool SetDetallePedidosWCFBL(string detallePedidos);

    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WebServiceApi.ContractType".
    /*
    [DataContract]
    public class ProductosWCF
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
    }*/
}
