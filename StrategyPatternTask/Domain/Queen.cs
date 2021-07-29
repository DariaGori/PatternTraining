using StrategyPatternTask.Domain.Behavior;

namespace StrategyPatternTask.Domain
{
    public class Queen : Character
    {
        public Queen()
        {
            WeaponBehavior = new BowAndArrowBehavior();
        }
    }
}