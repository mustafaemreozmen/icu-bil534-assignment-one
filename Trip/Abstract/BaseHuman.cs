using Trip.Abstract.Trip;
namespace Trip.Abstract.Human;

public abstract class BaseHuman
{
    private ITripBehaviour TripBehaviour { get; }

    public BaseHuman(ITripBehaviour tripBehaviour)
    {
        TripBehaviour = tripBehaviour;
    }
    public void Reach()
    {
        TripBehaviour.Go();
    }
}