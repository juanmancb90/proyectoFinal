using System;
namespace WpfApplication1.ViewModel
{
    interface IListadoProductosViewModel
    {
        System.Collections.ObjectModel.ObservableCollection<ProductoViewModel> Productos { get; set; }
    }
}
