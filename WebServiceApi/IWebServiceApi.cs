using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
//using WCFEntidades;


namespace WebServiceApi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWebServiceApi
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        string GetHelloWorld(string name);
        // TODO: Add your service operations here
        [OperationContract]
        string GetDataBL();

        [OperationContract]
        List<ProductosWCF> GetProductosWCFBL();
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WebServiceApi.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
    
    [DataContract]
    public class ProductosWCF
    {
        [DataMember]
        public int ID_Producto { get; set; }
        [DataMember]
        public int ID_Categoria { get; set; }
        [DataMember]
        public int ID_Promocion { get; set; }
        [DataMember]
        public string NombreProducto { get; set; }
        [DataMember]
        public string Codigo { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public string Fabricante { get; set; }
        [DataMember]
        public int Stock { get; set; }
        [DataMember]
        public decimal Impuesto { get; set; }
        [DataMember]
        public decimal ValorUnitario { get; set; }
        [DataMember]
        public bool Estado { get; set; }
    }
}
