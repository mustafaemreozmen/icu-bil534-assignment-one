using Game.Abstract.Weapon;

namespace Game.Concrete.Weapon;
public class AK47 : IWeaponBehaviour
{
    public void Attack()
    {
        Console.WriteLine("TATATATATATA!");
    }

    public void Reload()
    {
        Console.WriteLine("TIK... SLIKSLIK!");
    }
}