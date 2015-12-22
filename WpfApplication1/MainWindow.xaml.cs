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
using WpfApplication1.WebServiceApi;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WebServiceApiClient proxy = null;
        public MainWindow()
        {
            InitializeComponent();
            this.proxy = new WebServiceApiClient("BasicHttpBinding_IWebServiceApi");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Test Web service"+proxy.GetData(3), "Service", MessageBoxButton.OK, MessageBoxImage.Information);

            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var msn = "Juan";
            MessageBox.Show("Test Web service "+ proxy.GetHelloWorld(msn), "Service", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Test get Data BL Web Service" + proxy.GetDataBL(), "Service test", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
