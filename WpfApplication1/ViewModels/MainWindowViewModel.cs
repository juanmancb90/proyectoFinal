/*
 * Nombre de la Clase: MainWindowViewModel
 * Descripcion: View model de la pantalla principal
 * Autor: Equipo Makross - Grupo de Desarrollo
 * Fecha: 14/12/2015
 */

/*
 * Listado de Metodos:
 * >> ObservableCollection<BaseViewModel> Pantallas
 * >> MainWindowViewModel()
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.ServiceModel;
using System.Windows;
using WpfApplication1.WebServiceReference;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using BL;
using System.Configuration;
using Entidades;

namespace WpfApplication1.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private string cs = ConfigurationManager.ConnectionStrings[0].ConnectionString;
        ObservableCollection<BaseViewModel> _viewModels;
        private WebServiceApiClient proxy = null;
        /* 
         * Metodo
         * Descripcion: Metodo descriptor de acceso que declara una propiedad de tipo ObservableCollection<BaseViewModel> - Propiedad que entiende nuestro negocio
         * Entrada: void
         * Salida: ObservableCollection<BaseViewModel>
         */
        public ObservableCollection<BaseViewModel> Pantallas
        {
            get
            {
                if (_viewModels == null)
                    _viewModels = new ObservableCollection<BaseViewModel>();
                return _viewModels;
            }
            set
            {
                _viewModels = value;
                OnPropertyChanged("Pantallas");
            }
        }

        /* 
         * Metodo
         * Descripcion: Metodo constructor por defecto
         * Entrada: void
         * Salida: void
         */
        public MainWindowViewModel()
        {
            PedidosViewModel pedidosVM = new PedidosViewModel();
            Pantallas.Add(pedidosVM);
        }

        /* 
         * Metodo
         * Descripcion: Expone un comando de nombre BuscarProductoCommand y lo relaciona con el data binding del view
         * Entrada: void
         * Salida: ICommand
         */
        RelayCommand _ProductWebServiceCommand;
        public ICommand ProductWebServiceCommand
        {
            get
            {
                if (_ProductWebServiceCommand == null)
                    _ProductWebServiceCommand = new RelayCommand(param => this.ProductWebServiceExecute(), param => this.ProductWebService);
                return (_ProductWebServiceCommand);
            }
        }


        RelayCommand _PedidosWebServiceCommand;
        public ICommand PedidosWebServiceCommand
        {
            get
            {
                if(_PedidosWebServiceCommand == null)
                    _PedidosWebServiceCommand = new RelayCommand(param => this.PedidosWebServiceExecute(), param => this.PedidoWebService);
                return _PedidosWebServiceCommand;
            }
        }

        private void PedidosWebServiceExecute()
        {
            this.proxy = new WebServiceApiClient("WSHttpBinding_IWebServiceApi");
            MessageBoxResult result = MessageBox.Show("¿Desea sincronizar los pedidos con el Sistema Central?", "Alerta Actualización", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                
                PedidosBL contexto = new PedidosBL();
                DetallePedidosBL context = new DetallePedidosBL();
                List<Pedidos> pedidosBL = contexto.ObtenerPedidos(cs);
                List<DetallePedidos> detallePedidosBL = context.ObtenerDetallePedidos(cs);
                if (pedidosBL != null && detallePedidosBL != null)
                {
                    var pedidosWS = TransformarDatosPedidos(pedidosBL).ToArray();
                    var detallePedidosWS = TransformarDatosDetallePedidos(detallePedidosBL).ToArray(); 
                    bool rst1 = proxy.SetPedidosWCFBL(pedidosWS);
                    bool rst2 = proxy.SetDetallePedidosWCFBL(detallePedidosWS);
                    MessageBox.Show("Se ha sincronizado los pedidos con el sistema Central" + rst2 + "--" + rst1, "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("No se ha podido sincronizar los pedidos con el sistema Central", "Información", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

            }
        }

        private List<DetallePedidosWCF> TransformarDatosDetallePedidos(List<DetallePedidos> detallePedidosBL)
        {
            List<DetallePedidosWCF> DetallePedidos = new List<DetallePedidosWCF>();
            foreach (var item in detallePedidosBL)
            {
                DetallePedidosWCF detallePedidoActual = MapearDetallePedidos(item);
                DetallePedidos.Add(detallePedidoActual);
            }

            return DetallePedidos;
        }

        private List<PedidosWCF> TransformarDatosPedidos(List<Pedidos> pedidosBL)
        {
            List<PedidosWCF> pedidos = new List<PedidosWCF>();
            foreach (var item in pedidosBL)
            {
                PedidosWCF pedidoActual = MapearPedido(item);
                pedidos.Add(pedidoActual);
            }

            return pedidos;
        }


        private DetallePedidosWCF MapearDetallePedidos(DetallePedidos item)
        {
            DetallePedidosWCF detallePedido = new DetallePedidosWCF();
            detallePedido.ID_DetallePedido = item.ID_DetallePedido;
            detallePedido.ID_Pedido = item.ID_Pedido;
            detallePedido.ID_Producto = item.ID_Producto;
            detallePedido.Codigo = item.Codigo;
            detallePedido.NombreProducto = item.NombreProducto;
            detallePedido.Descripcion = item.Descripcion;
            detallePedido.Cantidad = item.Cantidad;
            detallePedido.ValorUnitario = item.ValorUnitario;
            detallePedido.Impuesto = item.Impuesto;
            detallePedido.SubTotal = item.SubTotal;

            return detallePedido;
        }


        private PedidosWCF MapearPedido(Pedidos item)
        {
            
            PedidosWCF pedido = new PedidosWCF();
            pedido.ID_Pedido = item.ID_Pedido;
            pedido.ID_Cliente = item.ID_Cliente;
            pedido.FechaRegistro = item.FechaRegistro;
            pedido.TotalBruto = item.TotalBruto;
            pedido.Impuesto = item.Impuesto;
            pedido.ValorNeto = item.ValorNeto;
            pedido.Estado = item.Estado;

            return pedido;
        }

        

        /* 
         * Metodo
         * Descripcion: Especifica la implementacion del comando BuscarProductoCommand - Busca un producto en particular
         * Entrada: void
         * Salida: void
         */
        private void ProductWebServiceExecute()
        {
            this.proxy = new WebServiceApiClient("BasicHttpBinding_IWebServiceApi");
            
            MessageBoxResult result = MessageBox.Show("¿Desea sincronizar el inventario de productos mediante el Sistema Central?", "Alerta Actualización", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                var data = proxy.GetProductosWCFBL();
                ProductosBL contexto = new ProductosBL();
                ProductoViewModel productoActual = new ProductoViewModel();
                if (data != null)
                {
                    foreach (var item in data)
                    {
                        productoActual.ID_Producto = item.ID_Producto;
                        productoActual.ID_Categoria = item.ID_Categoria;
                        productoActual.ID_Promocion = item.ID_Promocion;
                        productoActual.NombreProducto = item.NombreProducto;
                        productoActual.Codigo = item.Codigo;
                        productoActual.Descripcion = item.Descripcion;
                        productoActual.Fabricante = item.Fabricante;
                        productoActual.Stock = item.Stock;
                        productoActual.Impuesto = item.Impuesto;
                        productoActual.ValorUnitario = item.ValorUnitario;
                        productoActual.Estado = item.Estado;
                        contexto.SincronizarProductosBL(cs, productoActual.ObtenerEntidad());
                    }
                    MessageBox.Show("Se ha sincronizado los prodcutos del inventario con el sistema Central", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("No se ha podido sincronizar los prodcutos del inventario con el sistema Central", "Información", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                
            }
        }

        /* 
         * Metodo
         * Descripcion: Especifica que se puede ejecutar el comando ProductWebServiceCommand
         * Entrada: void
         * Salida: bool
         */
        public bool ProductWebService
        {
            get
            {
                return (true);
            }
        }
    
        public bool PedidoWebService 
        {
            get
            {
                return true;
            }
        }
    }
}
