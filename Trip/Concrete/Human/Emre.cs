

using Trip.Abstract.Human;
using Trip.Abstract.Trip;

namespace Trip.Concrete.Human;
public class Emre : BaseHuman
{
    public Emre(ITripBehaviour tripBehaviour) : base(tripBehaviour)
    {
    }
}