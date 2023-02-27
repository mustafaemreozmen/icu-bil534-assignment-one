using Duck.Abstract.Quack;

namespace Duck.Concrete.Fly;
public class MuteQuack : IQuackBehaviour
{
    public void Quack()
    {
        Console.WriteLine("sssht...");
    }
}