
namespace Wpf_Mvvm_Bikes.Model
{
    public class Bike
    {
        public static Bike CreateBike(string brand, string name)
        {
            return new Bike { Brand = brand, Name = name };
        }
        public string Brand { get; set; }
        public string Name { get; set; }
    }
}
