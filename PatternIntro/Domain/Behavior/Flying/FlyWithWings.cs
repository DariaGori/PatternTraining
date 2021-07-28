using System;
using PatternIntro.Domain.Contract;

namespace PatternIntro.Domain.Behavior.Flying
{
    public class FlyWithWings : IFlyingBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}