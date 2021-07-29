using StrategyPatternTask.Domain.Contract;

namespace StrategyPatternTask.Domain
{
    public class Character
    {
        public IWeaponBehavior WeaponBehavior { get; set; } = default!;
    }
}