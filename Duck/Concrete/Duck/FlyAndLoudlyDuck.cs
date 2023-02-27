using Duck.Abstract;
using Duck.Abstract.Duck;
using Duck.Abstract.Fly;
using Duck.Abstract.Quack;

namespace Duck.Concrete.Duck;

public class FlyAndLoudlyDuck : BaseDuck
{
    public FlyAndLoudlyDuck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour) : base(flyBehaviour, quackBehaviour)
    {
    }
}