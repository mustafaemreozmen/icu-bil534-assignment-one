using Trip.Abstract.Trip;

namespace Trip.Concrete.Trip;
public class ShipTrip : ITripBehaviour
{
    public void Go()
    {
        Console.WriteLine("CHUFCHUF!");
    }
}