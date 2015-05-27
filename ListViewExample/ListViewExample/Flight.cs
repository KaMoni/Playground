
namespace ListViewExample
{
    public class Flight
    {
        public Flight(string _flightNumber, string _departure, string _destination, int _delayTime)
        {
            this.flightNumber = _flightNumber;
            this.delayTime = _delayTime;
            this.destination = _destination;
            this.departure = _departure;
        }

        public string flightNumber { get; set; }
        public string departure { get; set; }
        public string destination { get; set; }
        public int delayTime { get; set; }
    }
}