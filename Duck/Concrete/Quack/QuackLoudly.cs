using Duck.Abstract.Quack;

namespace Duck.Concrete.Fly;
public class QuackLoudly : IQuackBehaviour
{
    public void Quack()
    {
        Console.WriteLine("QUAAAAAACCCK");
    }
}