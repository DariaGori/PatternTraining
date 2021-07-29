using System;
using StrategyPatternTask.Domain.Contract;

namespace StrategyPatternTask.Domain.Behavior
{
    public class AxeBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Hit with an axe");
        }
    }
}