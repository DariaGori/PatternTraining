using System;
using PatternIntro.Domain.Contract;

namespace PatternIntro.Domain.Behavior.Quacking
{
    public class Quack : IQuackingBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("Quack");
        }
    }
}