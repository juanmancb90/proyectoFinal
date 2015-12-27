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
        RelayCommand _TestWebServiceCommand;
        public ICommand TestWebServiceCommand
        {
            get
            {
                if (_TestWebServiceCommand == null)
                    _TestWebServiceCommand = new RelayCommand(param => this.TestConnectionWBExecute(), param => this.TestConnectionWB);
                return (_TestWebServiceCommand);
            }
        }

        /* 
         * Metodo
         * Descripcion: Especifica la implementacion del comando BuscarProductoCommand - Busca un producto en particular
         * Entrada: void
         * Salida: void
         */
        private void TestConnectionWBExecute()
        {
            this.proxy = new WebServiceApiClient("BasicHttpBinding_IWebServiceApi");
            var data = proxy.GetDataBL();
            MessageBox.Show("Test Connection Web service: " + data, "Mensaje Test", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /* 
         * Metodo
         * Descripcion: Especifica que se puede ejecutar el comando BuscarProductoCommand
         * Entrada: void
         * Salida: bool
         */
        public bool TestConnectionWB
        {
            get
            {
                return (true);
            }
        }
    }
}
