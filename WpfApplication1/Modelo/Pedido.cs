using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Modelo
{
    public class Pedido
    {
        public decimal Total { get; set; }
        public ObservableCollection<Producto> Productos { get; set; }
    }
}
