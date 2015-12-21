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
        ObservableCollection<BaseViewModel> _viewModelPantallaProducto, _viewModelPantallaCliente;

        public ObservableCollection<BaseViewModel> PantallaProducto
        {
            get
            {
                if (_viewModelPantallaProducto == null)
                {
                    _viewModelPantallaProducto = new ObservableCollection<BaseViewModel>();
                }
                return _viewModelPantallaProducto;
            }
            set
            {
                _viewModelPantallaProducto = value;
            }
        }

        public ObservableCollection<BaseViewModel> PantallaCliente
        {
            get
            {
                if (_viewModelPantallaCliente == null)
                {
                    _viewModelPantallaCliente = new ObservableCollection<BaseViewModel>();
                }
                return _viewModelPantallaCliente;
            }
            set
            {
                _viewModelPantallaCliente = value;
            }
        }

        public MainWindowViewModel() 
        {
            LoadViewProducto();
            LoadViewCliente();
        }

        public void LoadViewProducto()
        {
            ListadoProductosViewModel lpd = new ListadoProductosViewModel();
            PantallaProducto.Add(lpd);
        }

        public void LoadViewCliente()
        {
            BusquedaViewModel bus = new BusquedaViewModel();
            PantallaCliente.Add(bus);
        }

        
    }
}
