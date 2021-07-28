using System;
using PatternIntro.Domain.Contract;

namespace PatternIntro.Domain
{
    public abstract class Duck
    {
        public IFlyingBehavior FlyingBehavior { get; set; }
        public IQuackingBehavior QuackingBehavior { get; set; }
        
        public abstract void Display();
        
        public void PerformFly() {
            FlyingBehavior.Fly();
        }
        public void PerformQuack() {
            QuackingBehavior.DoQuack();
        }
        public void Swim() {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}