using System;
using PatternIntro.Domain.Behavior.Flying;
using PatternIntro.Domain.Behavior.Quacking;

namespace PatternIntro.Domain
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyingBehavior = new FlyNoWay();
            QuackingBehavior = new MuteQuack();
        }
        
        public override void Display()
        {
            Console.WriteLine("I'm a model duck!");
        }
    }
}