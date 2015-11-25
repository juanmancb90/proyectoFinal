using System;
using System.Collections.Generic;
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
    /// Interaction logic for ListadoProductos.xaml
    /// </summary>
    public partial class ListadoProductos : UserControl
    {
        public ListadoProductos()
        {
            InitializeComponent();
            List<Producto> productos = new List<Producto>();

            productos.Add(new Producto { Descripcion = "Esto es un dorito", Nombre = "DORITOS", Imagen = "/WpfApplication1;component/productos/doritos.jpg", Oferta = true, Precio = 800 });

             productos.Add(new Producto { Descripcion = "Esto es un cheeto", Nombre = "CHEETOS", Imagen = "/WpfApplication1;component/productos/cheetos.jpg", Oferta = false, Precio = 700 });

             productos.Add(new Producto { Descripcion = "Esto es un margarita limon", Nombre = "MARGARITA LIMON", Imagen = "/WpfApplication1;component/productos/margaritalimon.jpg", Oferta = false, Precio = 700 });

             productos.Add(new Producto { Descripcion = "Esto es un margarita natual", Nombre = "MARGARITA NATURAL", Imagen = "/WpfApplication1;component/productos/margaritanatural.jpg", Oferta = false, Precio = 700 });

             productos.Add(new Producto { Descripcion = "Esto es un margarita pollo", Nombre = "MARGARITA POLLO", Imagen = "/WpfApplication1;component/productos/margaritapollo.jpg", Oferta = false, Precio = 700 });
            this.listado.ItemsSource = productos;
        }
    }
}
