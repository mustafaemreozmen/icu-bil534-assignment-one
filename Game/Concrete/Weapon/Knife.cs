using Game.Abstract.Weapon;

namespace Game.Concrete.Weapon;
public class Knife : IWeaponBehaviour
{
    public void Attack()
    {
        Console.WriteLine("SLAK!");
    }

    public void Reload()
    {
        Console.WriteLine("Are you serious? Reload the knife?");
    }
}