using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_Mvvm_Bikes.Model;

namespace Wpf_Mvvm_Bikes.DataAccess
{
    public class BikeRepository
    {
        readonly List<Bike> _bikes;
        public BikeRepository()
        {
            if (_bikes == null)
	        {
                _bikes = new List<Bike>();
	        }
            _bikes.Add(Bike.CreateBike("Dartmoore", "Wish"));
            _bikes.Add(Bike.CreateBike("Dartmoore", "Phantom"));
            _bikes.Add(Bike.CreateBike("Echo", "Mark II"));
        }

        public List<Bike> GetBikes()
        {
            return new List<Bike>(_bikes);
        }
    }
}
