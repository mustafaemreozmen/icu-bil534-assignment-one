using Duck.Abstract;
using Duck.Abstract.Duck;
using Duck.Abstract.Fly;
using Duck.Abstract.Quack;

namespace Duck.Concrete.Duck;

public class ToyDuck : BaseDuck
{
    public ToyDuck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour) : base(flyBehaviour, quackBehaviour)
    {
    }
}