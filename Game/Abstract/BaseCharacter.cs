using Game.Abstract.Weapon;

namespace Game.Abstract.Character;

public abstract class BaseCharacter
{
    private IWeaponBehaviour WeaponBehaviour { get; }
    public BaseCharacter(IWeaponBehaviour weaponBehaviour)
    {
        WeaponBehaviour = weaponBehaviour;
    }
    public void Fight()
    {
        WeaponBehaviour.Attack();
    }

    public void Hide()
    {
        WeaponBehaviour.Reload();
    }
}