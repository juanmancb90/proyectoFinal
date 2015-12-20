using BL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Entidades;


namespace WpfApplication1.ViewModel
{
    public class ListadoProductosViewModel : BaseViewModel
    {
        string cs = ConfigurationManager.ConnectionStrings[0].ConnectionString;
        ObservableCollection<ProductoViewModel> _productos;
        //private bool esNuevo;

        public ObservableCollection<ProductoViewModel> Productos
        {
            get
            {
                return _productos;
            }
            set
            {
                _productos = value;
            }
        }

        public ListadoProductosViewModel()
        {
            CargarProductos();
        }

        public void CargarProductos()
        {
            ProductosBL contexPro = new ProductosBL();
            var productosBL = contexPro.ObtenerProductosBL(cs);
            if (Productos == null)
            {
                Productos = new ObservableCollection<ProductoViewModel>();
            }
            foreach (var item in productosBL)
            {
                Productos.Add(new ProductoViewModel(item));
            }
        }

        RelayCommand _agregarCommand;
        public ICommand AgregarCommand
        {
            get
            {
                if (_agregarCommand == null)
                    _agregarCommand = new RelayCommand(param => this.AgregarExecute(), param => this.CanAgregarExecute);
                return _agregarCommand;
            }

        }

        private void AgregarExecute()
        {
            //implementacion agregar
            /*esNuevo = true;
            EmpleadoViewModel empleadoNuevo = new EmpleadoViewModel();
            this.Empleados.Add(empleadoNuevo);
            this.EmpleadoActual = empleadoNuevo;
            HabilitarEdicion();*/
        }

        public bool CanAgregarExecute
        {
            get
            { return true; }
        }
    }
}
