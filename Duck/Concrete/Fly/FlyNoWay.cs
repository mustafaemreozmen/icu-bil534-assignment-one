using Duck.Abstract.Fly;

namespace Duck.Concrete.Fly;
public class FlyNoWay : IFlyBehaviour
{
    public void Fly()
    {
        Console.WriteLine("ARE YOU KIDDING ME? HOW CAN I FLY?");
    }
}