using Game.Abstract.Character;
using Game.Abstract.Weapon;

namespace Game.Concrete.Character;

public class Ninja : BaseCharacter
{
    public Ninja(IWeaponBehaviour weaponBehaviour) : base(weaponBehaviour)
    {
    }
}