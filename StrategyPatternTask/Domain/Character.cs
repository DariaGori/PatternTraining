using StrategyPatternTask.Domain.Contract;

namespace StrategyPatternTask.Domain
{
    public abstract class Character
    {
        public IWeaponBehavior WeaponBehavior { get; set; } = default!;

        public void Fight()
        {
            WeaponBehavior.UseWeapon();
        }
    }
}