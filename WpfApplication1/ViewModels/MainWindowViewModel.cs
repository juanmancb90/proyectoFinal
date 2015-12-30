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

namespace WpfApplication1.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        /* 
         * Metodo
         * Descripcion: Metodo descriptor de acceso que declara una propiedad de tipo ObservableCollection<BaseViewModel> - Propiedad que entiende nuestro negocio
         * Entrada: void
         * Salida: ObservableCollection<BaseViewModel>
         */
        private string cs = ConfigurationManager.ConnectionStrings[0].ConnectionString;
        ObservableCollection<BaseViewModel> _viewModels;
        private WebServiceApiClient proxy = null;
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
                    contexto.insertarProductoBl(cs, productoActual.ObtenerEntidad());
                }
                MessageBox.Show("Se ha sincronizado los prodcutos del inventario con el sistema Central", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        /* 
         * Metodo
         * Descripcion: Especifica que se puede ejecutar el comando BuscarProductoCommand
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
    }
}
