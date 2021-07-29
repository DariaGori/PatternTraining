using System;
using StrategyPatternTask.Domain.Contract;

namespace StrategyPatternTask.Domain.Behavior
{
    public class KnifeBeavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Pierce with a knife");
        }
    }
}