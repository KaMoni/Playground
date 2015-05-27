using System;
using System.ComponentModel;

namespace Wpf_Mvvm_Bikes.ViewModel
{
    public abstract class ViewModelBase : INotifyPropertyChanged, IDisposable
    {
         protected ViewModelBase()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                PropertyChangedEventArgs e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

        public void Dispose()
        {
            this.OnDispose();
        }

        protected virtual void OnDispose()
        {

        }
    }
}

