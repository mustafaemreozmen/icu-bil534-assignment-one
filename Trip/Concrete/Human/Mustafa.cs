

using Trip.Abstract.Human;
using Trip.Abstract.Trip;

namespace Trip.Concrete.Human;
public class Mustafa : BaseHuman
{
    public Mustafa(ITripBehaviour tripBehaviour) : base(tripBehaviour)
    {
    }
}