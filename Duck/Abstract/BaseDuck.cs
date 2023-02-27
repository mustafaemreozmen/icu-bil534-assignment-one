using Duck.Abstract.Fly;
using Duck.Abstract.Quack;

namespace Duck.Abstract.Duck;

public abstract class BaseDuck
{
    private IQuackBehaviour QuackBehaviour { get; }
    private IFlyBehaviour FlyBehaviour { get; }

    public BaseDuck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour)
    {
        FlyBehaviour = flyBehaviour;
        QuackBehaviour = quackBehaviour;
    }
    public void PerformQuack()
    {
        QuackBehaviour.Quack();
    }

    public void PerformFly()
    {
        FlyBehaviour.Fly();
    }

}