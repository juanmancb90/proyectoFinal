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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebService.IWebServiceApi")]
    public interface IWebServiceApi {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceApi/GetProductosWCFBL", ReplyAction="http://tempuri.org/IWebServiceApi/GetProductosWCFBLResponse")]
        string GetProductosWCFBL();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceApi/GetProductosWCFBL", ReplyAction="http://tempuri.org/IWebServiceApi/GetProductosWCFBLResponse")]
        System.Threading.Tasks.Task<string> GetProductosWCFBLAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceApi/GetClientesWCFBL", ReplyAction="http://tempuri.org/IWebServiceApi/GetClientesWCFBLResponse")]
        string GetClientesWCFBL();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceApi/GetClientesWCFBL", ReplyAction="http://tempuri.org/IWebServiceApi/GetClientesWCFBLResponse")]
        System.Threading.Tasks.Task<string> GetClientesWCFBLAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceApi/SetPedidosWCFBL", ReplyAction="http://tempuri.org/IWebServiceApi/SetPedidosWCFBLResponse")]
        bool SetPedidosWCFBL(string pedidos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceApi/SetPedidosWCFBL", ReplyAction="http://tempuri.org/IWebServiceApi/SetPedidosWCFBLResponse")]
        System.Threading.Tasks.Task<bool> SetPedidosWCFBLAsync(string pedidos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceApi/SetDetallePedidosWCFBL", ReplyAction="http://tempuri.org/IWebServiceApi/SetDetallePedidosWCFBLResponse")]
        bool SetDetallePedidosWCFBL(string detallePedidos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebServiceApi/SetDetallePedidosWCFBL", ReplyAction="http://tempuri.org/IWebServiceApi/SetDetallePedidosWCFBLResponse")]
        System.Threading.Tasks.Task<bool> SetDetallePedidosWCFBLAsync(string detallePedidos);
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
        
        public string GetProductosWCFBL() {
            return base.Channel.GetProductosWCFBL();
        }
        
        public System.Threading.Tasks.Task<string> GetProductosWCFBLAsync() {
            return base.Channel.GetProductosWCFBLAsync();
        }
        
        public string GetClientesWCFBL() {
            return base.Channel.GetClientesWCFBL();
        }
        
        public System.Threading.Tasks.Task<string> GetClientesWCFBLAsync() {
            return base.Channel.GetClientesWCFBLAsync();
        }
        
        public bool SetPedidosWCFBL(string pedidos) {
            return base.Channel.SetPedidosWCFBL(pedidos);
        }
        
        public System.Threading.Tasks.Task<bool> SetPedidosWCFBLAsync(string pedidos) {
            return base.Channel.SetPedidosWCFBLAsync(pedidos);
        }
        
        public bool SetDetallePedidosWCFBL(string detallePedidos) {
            return base.Channel.SetDetallePedidosWCFBL(detallePedidos);
        }
        
        public System.Threading.Tasks.Task<bool> SetDetallePedidosWCFBLAsync(string detallePedidos) {
            return base.Channel.SetDetallePedidosWCFBLAsync(detallePedidos);
        }
    }
}
