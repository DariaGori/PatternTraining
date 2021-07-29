using StrategyPatternTask.Domain.Behavior;

namespace StrategyPatternTask.Domain
{
    public class Knight : Character
    {
        public Knight()
        {
            WeaponBehavior = new SwordBehavior();
        }
    }
}