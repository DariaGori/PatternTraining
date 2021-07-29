using StrategyPatternTask.Domain.Behavior;

namespace StrategyPatternTask.Domain
{
    public class King : Character
    {
        public King()
        {
            WeaponBehavior = new KnifeBeavior();
        }
    }
}