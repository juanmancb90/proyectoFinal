using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace WpfApplication1.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged, IDisposable
    {
        private bool estaOcupado;
        //ObservableCollection<String> error;

        public bool EstaOCupado
        {
            get
            {
                return estaOcupado;
            }
            set
            {
                estaOcupado = value;
                OnPropertyChanged("EstaOcupado");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Dispose()
        {
            this.OnDispose();
        }

        protected virtual void OnDispose()
        {
            throw new NotImplementedException();
        }

    }

}
