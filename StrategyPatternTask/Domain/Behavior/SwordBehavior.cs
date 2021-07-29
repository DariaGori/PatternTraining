using System;
using StrategyPatternTask.Domain.Contract;

namespace StrategyPatternTask.Domain.Behavior
{
    public class SwordBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Strike with a sword");
        }
    }
}