using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace WpfApplication1.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        ObservableCollection<BaseViewModel> _viewModel;

        public ObservableCollection<BaseViewModel> PantallaProducto
        {
            get
            {
                if (_viewModel == null)
                {
                    _viewModel = new ObservableCollection<BaseViewModel>();
                }
                return _viewModel;
            }
            set
            {
                _viewModel = value;
            }
        }

        public ObservableCollection<BaseViewModel> PantallaCliente
        {
            get
            {
                if (_viewModel == null)
                {
                    _viewModel = new ObservableCollection<BaseViewModel>();
                }
                return _viewModel;
            }
            set
            {
                _viewModel = value;
            }
        }

        public MainWindowViewModel() 
        {
            ListadoProductosViewModel lpd = new ListadoProductosViewModel();
            BusquedaViewModel bus = new BusquedaViewModel();
            PantallaProducto.Add(lpd);
            PantallaCliente.Add(bus);
        }
    }
}
