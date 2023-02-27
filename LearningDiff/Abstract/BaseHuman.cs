using LearningDiff.Abstract.Learning;

namespace LearningDiff.Abstract.Human;
public abstract class BaseHuman
{
    private ILearningBehaviour LearningBehaviour { get; }

    public BaseHuman(ILearningBehaviour learningBehaviour)
    {
        LearningBehaviour = learningBehaviour;
    }
    public void LearnAnything()
    {
        LearningBehaviour.Action();
    }
}