using Game.Abstract.Character;
using Game.Abstract.Weapon;

namespace Game.Concrete.Character;

public class Soldier : BaseCharacter
{
    public Soldier(IWeaponBehaviour weaponBehaviour) : base(weaponBehaviour)
    {
    }
}