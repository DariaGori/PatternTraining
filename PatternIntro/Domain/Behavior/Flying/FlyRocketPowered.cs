using System;
using PatternIntro.Domain.Contract;

namespace PatternIntro.Domain.Behavior.Flying
{
    public class FlyRocketPowered : IFlyingBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}