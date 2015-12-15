using BL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.ViewModel
{
    public class BusquedaViewModel : BaseViewModel
    {
        string cs = ConfigurationManager.ConnectionStrings[0].ConnectionString;
        //Busqueda control = new Busqueda();
        ObservableCollection<ClienteViewModel> _clientes;

        public ObservableCollection<ClienteViewModel> Clientes
        {
            get
            {
                return _clientes;
            }
            set
            {
                _clientes = value;
            }
        }

        public BusquedaViewModel()
        {
            CargarCliente();
        }

        public void CargarCliente()
        {
            ClientesBL contextCl = new ClientesBL();
            var clientesBL = contextCl.ObtenerClientesBL(cs);
            if (Clientes == null)
            {
                Clientes = new ObservableCollection<ClienteViewModel>();
            }
            foreach (var item in clientesBL)
            {
                Clientes.Add(new ClienteViewModel(item));
            }
        }
    }
}
