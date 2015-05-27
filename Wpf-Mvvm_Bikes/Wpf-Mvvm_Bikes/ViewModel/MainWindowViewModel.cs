using System.Collections.ObjectModel;
using Wpf_Mvvm_Bikes.DataAccess;

namespace Wpf_Mvvm_Bikes.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        readonly BikeRepository _employeeRepository;

        ObservableCollection<ViewModelBase> _viewModels;

        public MainWindowViewModel()
        {
            _employeeRepository = new BikeRepository();
            //create an instance to our viewmodel and add it to our collection
            BikeListViewModel viewModel = new BikeListViewModel(_employeeRepository);
            this.ViewModels.Add(viewModel);
        }

        public ObservableCollection<ViewModelBase> ViewModels
        {
            get 
            {
                if (_viewModels == null)
                {
                    _viewModels = new ObservableCollection<ViewModelBase>();
                }
                return _viewModels;
            }
        }
    }
}
