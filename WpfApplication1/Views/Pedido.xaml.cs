using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApplication1.Modelo;

namespace WpfApplication1.Views
{
    /// <summary>
    /// Interaction logic for Pedido.xaml
    /// </summary>
    public partial class Pedido : UserControl
    {
        public Pedido()
        {
            InitializeComponent();
            ObservableCollection<Producto> productos = new ObservableCollection<Producto>();

            productos.Add(new Producto { Descripcion = "Esto es un dorito", Nombre = "DORITOS", Imagen = "/WpfApplication1;component/productos/doritos.jpg", Oferta = true, Precio = 800, Cantidad = 1 });

            productos.Add(new Producto { Descripcion = "Esto es un cheeto", Nombre = "CHEETOS", Imagen = "/WpfApplication1;component/productos/cheetos.jpg", Oferta = false, Precio = 700, Cantidad = 2 });

            Modelo.Pedido pedido = new Modelo.Pedido();
            pedido.Productos = productos;
            pedido.Total = pedido.Productos.Sum(p => p.Precio * p.Cantidad);
            this.DataContext = pedido;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Modelo.Pedido pedido = this.DataContext as Modelo.Pedido;


            pedido.Productos.Add(new Producto { Descripcion = "Esto es un margarita pollo", Nombre = "MARGARITA POLLO", Imagen = "/WpfApplication1;component/productos/margaritapollo.jpg", Oferta = false, Precio = 700 });

        }
    }
}
