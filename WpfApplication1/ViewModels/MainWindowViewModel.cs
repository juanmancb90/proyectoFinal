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
 * >> ICommand ProductWebServiceCommand
 * >> ICommand PedidosWebServiceCommand
 * >> void PedidosWebServiceExecute()
 * >> string EncriptarDatosDetallePedidos(List<DetallePedidos> detallePedidosBL)
 * >> string EncriptarDatosPedidos(List<Pedidos> pedidosBL)
 * >> void ProductWebServiceExecute()
 * >> List<Productos> Desencriptar(string data)
 * >> bool ProductWebService
 * >> bool PedidoWebService 
 * >>
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
         * Descripcion: Expone un comando de nombre ProductWebServiceCommand y lo relaciona con el data binding del view
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

        /* 
         * Metodo
         * Descripcion: Expone un comando de nombre PedidosWebServiceCommand y lo relaciona con el data binding del view
         * Entrada: void
         * Salida: ICommand
         */
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

        /* 
         * Metodo
         * Descripcion: Especifica que se puede ejecutar el comando PedidosWebServiceCommand
         * Entrada: void
         * Salida: bool
         */
        private void PedidosWebServiceExecute()
        {
            try
            {
                this.proxy = new WebServiceApiClient("WSHttpBinding_IWebServiceApi");
                MessageBoxResult result = MessageBox.Show("¿Desea sincronizar los pedidos con el Sistema Central?", "Alerta Actualización", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {

                    PedidosBL contexto = new PedidosBL();
                    DetallePedidosBL context = new DetallePedidosBL();
                    var fechaActual = DateTime.Today.ToString("yyyy-MM-dd");
                    List<Pedidos> pedidosBL = contexto.ObtenerPedidosPorFecha(cs, fechaActual);
                    List<DetallePedidos> detallePedidosBL = context.ObtenerDetallePedidosId(cs, pedidosBL);
                    if (pedidosBL != null && detallePedidosBL != null)
                    {
                        var pedidosWS = EncriptarDatosPedidos(pedidosBL);
                        var detallePedidosWS = EncriptarDatosDetallePedidos(detallePedidosBL);
                        bool rst1 = proxy.SetPedidosWCFBL(pedidosWS);
                        bool rst2 = proxy.SetDetallePedidosWCFBL(detallePedidosWS);
                        if (rst1 == true && rst2 == true) 
                        {
                            contexto.ActualizarEstadoPedido(cs, pedidosBL);
                            MessageBox.Show("Se ha sincronizado los pedidos con el sistema Central", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido sincronizar los pedidos con el sistema Central", "Información", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido sincronizar los pedidos con el sistema Central", "Información", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(),"Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
                
        }

        /* 
         * Metodo
         * Descripcion: Encripta el listado de detalle de pedidos en cadena string
         * Entrada: List<DetallePedidos> detallePedidosBL
         * Salida: string
         */
        private string EncriptarDatosDetallePedidos(List<DetallePedidos> detallePedidosBL)
        {
            bool primerDetallePedido = true;
            var cadena = new StringBuilder();
            foreach (var item in detallePedidosBL)
            {
                if (primerDetallePedido)
                {
                    primerDetallePedido = false;
                    cadena.Append(item.ID_DetallePedido.ToString());
                    cadena.Append(string.Format("¿{0}", item.ID_Pedido.ToString()));
                    cadena.Append(string.Format("¿{0}", item.ID_Producto.ToString()));
                    cadena.Append(string.Format("¿{0}", item.Codigo.ToString()));
                    cadena.Append(string.Format("¿{0}", item.NombreProducto.ToString()));
                    cadena.Append(string.Format("¿{0}", item.Descripcion.ToString()));
                    cadena.Append(string.Format("¿{0}", item.Cantidad.ToString()));
                    cadena.Append(string.Format("¿{0}", item.ValorUnitario.ToString()));
                    cadena.Append(string.Format("¿{0}", item.Impuesto.ToString()));
                    cadena.Append(string.Format("¿{0}", item.SubTotal.ToString()));
                }
                else
                {
                    cadena.Append(string.Format(":{0}", item.ID_DetallePedido.ToString()));
                    cadena.Append(string.Format("¿{0}", item.ID_Pedido.ToString()));
                    cadena.Append(string.Format("¿{0}", item.ID_Producto.ToString()));
                    cadena.Append(string.Format("¿{0}", item.Codigo.ToString()));
                    cadena.Append(string.Format("¿{0}", item.NombreProducto.ToString()));
                    cadena.Append(string.Format("¿{0}", item.Descripcion.ToString()));
                    cadena.Append(string.Format("¿{0}", item.Cantidad.ToString()));
                    cadena.Append(string.Format("¿{0}", item.ValorUnitario.ToString()));
                    cadena.Append(string.Format("¿{0}", item.Impuesto.ToString()));
                    cadena.Append(string.Format("¿{0}", item.SubTotal.ToString()));
                }
            }

            byte[] encripted = Encoding.Unicode.GetBytes(cadena.ToString());
            string salida = Convert.ToBase64String(encripted);

            return salida;
        }

        /* 
         * Metodo
         * Descripcion: Encripta el listado de pedidos a sincronizar
         * Entrada: List<Pedidos> pedidosBL
         * Salida: string
         */
        private string EncriptarDatosPedidos(List<Pedidos> pedidosBL)
        {
            bool Pedido = true;
            var cadena = new StringBuilder();
            foreach (var item in pedidosBL)
            {
                if (Pedido)
                {
                    Pedido = false;
                    cadena.Append(item.ID_Pedido.ToString());
                    cadena.Append(string.Format("¿{0}", item.ID_Cliente.ToString()));
                    cadena.Append(string.Format("¿{0}", item.FechaRegistro.ToString()));
                    cadena.Append(string.Format("¿{0}", item.TotalBruto.ToString()));
                    cadena.Append(string.Format("¿{0}", item.Impuesto.ToString()));
                    cadena.Append(string.Format("¿{0}", item.ValorNeto.ToString()));
                    cadena.Append(string.Format("¿{0}", item.Estado.ToString()));
                }
                else
                {
                    cadena.Append(string.Format("#{0}", item.ID_Pedido.ToString()));
                    cadena.Append(string.Format("¿{0}", item.ID_Cliente.ToString()));
                    cadena.Append(string.Format("¿{0}", item.FechaRegistro.ToString()));
                    cadena.Append(string.Format("¿{0}", item.TotalBruto.ToString()));
                    cadena.Append(string.Format("¿{0}", item.Impuesto.ToString()));
                    cadena.Append(string.Format("¿{0}", item.ValorNeto.ToString()));
                    cadena.Append(string.Format("¿{0}", item.Estado.ToString()));
                }
            }

            byte[] encripted = Encoding.Unicode.GetBytes(cadena.ToString());
            string salida = Convert.ToBase64String(encripted);

            return salida;
        }

        /* 
         * Metodo
         * Descripcion: Especifica la implementacion del comando ProductWebServiceCommand
         * Entrada: void
         * Salida: void
         */
        private void ProductWebServiceExecute()
        {
            try
            {
                this.proxy = new WebServiceApiClient("WSHttpBinding_IWebServiceApi");
                MessageBoxResult result = MessageBox.Show("¿Desea sincronizar el inventario de productos mediante el Sistema Central?", "Alerta Actualización", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    var data = proxy.GetProductosWCFBL();
                    ProductosBL contexto = new ProductosBL();
                    if (data != null)
                    {
                        var productos = Desencriptar(data);
                        foreach (var item in productos)
                        {
                            contexto.SincronizarProductosBL(cs, item);
                        }
                        MessageBox.Show("Se ha sincronizado los prodcutos del inventario con el sistema Central", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido sincronizar los prodcutos del inventario con el sistema Central", "Información", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("error detectado:\n" + e.ToString(), "Error en Sincronizacion", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        /* 
         * Metodo
         * Descripcion: Desencripta la cadena de string correspondiente a los productos del web service
         * Entrada: string data
         * Salida: List<Productos>
         */
        private List<Productos> Desencriptar(string data)
        {
            List<Productos> Productos = new List<Entidades.Productos>();
            byte[] decripter = Convert.FromBase64String(data);
            string cadena = Encoding.Unicode.GetString(decripter);
            string[] productos = cadena.Split(':');
            for (int i = 0; i < productos.Length; i++)
            {
                string[] producto = productos[i].Split('¿');
                Productos Producto = new Productos();
                Producto.ID_Producto = Convert.ToInt32(producto[0]);
                Producto.ID_Categoria = Convert.ToInt32(producto[1]);
                Producto.ID_Promocion = Convert.ToInt32(producto[2]);
                Producto.NombreProducto = producto[3];
                Producto.Codigo = producto[4];
                Producto.Descripcion = producto[5];
                Producto.Fabricante = producto[6];
                Producto.Stock = Convert.ToInt32(producto[7]);
                Producto.Impuesto = Convert.ToDecimal(producto[8]);
                Producto.ValorUnitario = Convert.ToDecimal(producto[9]);
                Producto.Estado = Convert.ToBoolean(producto[10]);
                Productos.Add(Producto);
            }
            return Productos;
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

        /* 
         * Metodo
         * Descripcion: Especifica que se puede ejecutar el comando PedidosWebServiceCommand
         * Entrada: void
         * Salida: bool
         */
        public bool PedidoWebService 
        {
            get
            {
                return true;
            }
        }
    }
}
