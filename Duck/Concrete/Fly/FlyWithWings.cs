using Duck.Abstract.Fly;

namespace Duck.Concrete.Fly;
public class FlyWithWings : IFlyBehaviour
{
    public void Fly()
    {
        Console.WriteLine("I HAVE WINGS");
    }
}