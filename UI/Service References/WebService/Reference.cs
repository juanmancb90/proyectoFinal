﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UI.WebService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductosWCF", Namespace="http://schemas.datacontract.org/2004/07/WCFEntidades")]
    [System.SerializableAttribute()]
    public partial class ProductosWCF : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FabricanteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_CategoriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_ProductoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ID_PromocionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ImpuestoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreProductoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StockField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ValorUnitarioField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoField, value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((this.EstadoField.Equals(value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fabricante {
            get {
                return this.FabricanteField;
            }
            set {
                if ((object.ReferenceEquals(this.FabricanteField, value) != true)) {
                    this.FabricanteField = value;
                    this.RaisePropertyChanged("Fabricante");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID_Categoria {
            get {
                return this.ID_CategoriaField;
            }
            set {
                if ((this.ID_CategoriaField.Equals(value) != true)) {
                    this.ID_CategoriaField = value;
                    this.RaisePropertyChanged("ID_Categoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID_Producto {
            get {
                return this.ID_ProductoField;
            }
            set {
                if ((this.ID_ProductoField.Equals(value) != true)) {
                    this.ID_ProductoField = value;
                    this.RaisePropertyChanged("ID_Producto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID_Promocion {
            get {
                return this.ID_PromocionField;
            }
            set {
                if ((this.ID_PromocionField.Equals(value) != true)) {
                    this.ID_PromocionField = value;
                    this.RaisePropertyChanged("ID_Promocion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Impuesto {
            get {
                return this.ImpuestoField;
            }
            set {
                if ((this.ImpuestoField.Equals(value) != true)) {
                    this.ImpuestoField = value;
                    this.RaisePropertyChanged("Impuesto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreProducto {
            get {
                return this.NombreProductoField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreProductoField, value) != true)) {
                    this.NombreProductoField = value;
                    this.RaisePropertyChanged("NombreProducto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Stock {
            get {
                return this.StockField;
            }
            set {
                if ((this.StockField.Equals(value) != true)) {
                    this.StockField = value;
                    this.RaisePropertyChanged("Stock");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal ValorUnitario {
            get {
                return this.ValorUnitarioField;
            }
            set {
                if ((this.ValorUnitarioField.Equals(value) != true)) {
                    this.ValorUnitarioField = value;
                    this.RaisePropertyChanged("ValorUnitario");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebService.IWebServiceApi")]
    public interface IWebServiceApi {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceApi/GetData", ReplyAction="http://tempuri.org/IWebServiceApi/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceApi/GetData", ReplyAction="http://tempuri.org/IWebServiceApi/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceApi/GetHelloWorld", ReplyAction="http://tempuri.org/IWebServiceApi/GetHelloWorldResponse")]
        string GetHelloWorld(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceApi/GetHelloWorld", ReplyAction="http://tempuri.org/IWebServiceApi/GetHelloWorldResponse")]
        System.Threading.Tasks.Task<string> GetHelloWorldAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceApi/GetDataBL", ReplyAction="http://tempuri.org/IWebServiceApi/GetDataBLResponse")]
        string GetDataBL();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceApi/GetDataBL", ReplyAction="http://tempuri.org/IWebServiceApi/GetDataBLResponse")]
        System.Threading.Tasks.Task<string> GetDataBLAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceApi/GetProductosWCFBL", ReplyAction="http://tempuri.org/IWebServiceApi/GetProductosWCFBLResponse")]
        UI.WebService.ProductosWCF[] GetProductosWCFBL();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceApi/GetProductosWCFBL", ReplyAction="http://tempuri.org/IWebServiceApi/GetProductosWCFBLResponse")]
        System.Threading.Tasks.Task<UI.WebService.ProductosWCF[]> GetProductosWCFBLAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWebServiceApiChannel : UI.WebService.IWebServiceApi, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceApiClient : System.ServiceModel.ClientBase<UI.WebService.IWebServiceApi>, UI.WebService.IWebServiceApi {
        
        public WebServiceApiClient() {
        }
        
        public WebServiceApiClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceApiClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceApiClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceApiClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public string GetHelloWorld(string name) {
            return base.Channel.GetHelloWorld(name);
        }
        
        public System.Threading.Tasks.Task<string> GetHelloWorldAsync(string name) {
            return base.Channel.GetHelloWorldAsync(name);
        }
        
        public string GetDataBL() {
            return base.Channel.GetDataBL();
        }
        
        public System.Threading.Tasks.Task<string> GetDataBLAsync() {
            return base.Channel.GetDataBLAsync();
        }
        
        public UI.WebService.ProductosWCF[] GetProductosWCFBL() {
            return base.Channel.GetProductosWCFBL();
        }
        
        public System.Threading.Tasks.Task<UI.WebService.ProductosWCF[]> GetProductosWCFBLAsync() {
            return base.Channel.GetProductosWCFBLAsync();
        }
    }
}
