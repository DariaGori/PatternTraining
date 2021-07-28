using System;
using PatternIntro.Domain.Behavior.Flying;
using PatternIntro.Domain.Behavior.Quacking;

namespace PatternIntro.Domain
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyingBehavior = new FlyWithWings();
            QuackingBehavior = new Quack();
        }
        
        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck!");
        }
    }
}