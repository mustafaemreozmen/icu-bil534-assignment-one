
using LearningDiff.Abstract.Learning;

namespace LearningDiff.Concrete.Learning;
public class Write : ILearningBehaviour
{
    public void Action()
    {
        Console.WriteLine("I'm a writer");
    }
}