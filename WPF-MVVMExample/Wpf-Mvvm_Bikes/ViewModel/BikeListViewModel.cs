using System;
using System.Collections.ObjectModel;
using Wpf_Mvvm_Bikes.DataAccess;

namespace Wpf_Mvvm_Bikes.ViewModel
{
    class BikeListViewModel : ViewModelBase
    {
        readonly BikeRepository _bikeRepository;

        public ObservableCollection<Model.Bike> AllBikes
        {
            get;
            private set;
        }

        public BikeListViewModel(BikeRepository bikeRepository)
        {
            if (bikeRepository == null)
            {
                throw new ArgumentNullException("bikeRepository");
            }
            _bikeRepository = bikeRepository;
            this.AllBikes = new ObservableCollection<Model.Bike>(_bikeRepository.GetBikes());
        }

        protected override void OnDispose()
        {
            this.AllBikes.Clear();
        }
    }
}

       
