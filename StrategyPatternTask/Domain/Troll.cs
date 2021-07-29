using StrategyPatternTask.Domain.Behavior;

namespace StrategyPatternTask.Domain
{
    public class Troll : Character
    {
        public Troll()
        {
            WeaponBehavior = new AxeBehavior();
        }
    }
}