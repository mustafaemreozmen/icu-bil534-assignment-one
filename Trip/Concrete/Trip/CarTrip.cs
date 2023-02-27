using Trip.Abstract.Trip;

namespace Trip.Concrete.Trip;
public class CarTrip : ITripBehaviour
{
    public void Go()
    {
        Console.WriteLine("VINNN!");
    }
}