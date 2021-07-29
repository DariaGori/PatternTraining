using System;
using StrategyPatternTask.Domain.Contract;

namespace StrategyPatternTask.Domain.Behavior
{
    public class BowAndArrowBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Shoot with an arrow");
        }
    }
}