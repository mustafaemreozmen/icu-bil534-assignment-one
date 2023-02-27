
using LearningDiff.Abstract.Learning;

namespace LearningDiff.Concrete.Learning;
public class Read : ILearningBehaviour
{
    public void Action()
    {
        Console.WriteLine("I'm a reader");
    }
}