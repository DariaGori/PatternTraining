using System;
using PatternIntro.Domain.Contract;

namespace PatternIntro.Domain.Behavior.Flying
{
    public class FlyNoWay : IFlyingBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly :(");
        }
    }
}