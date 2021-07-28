using System;
using PatternIntro.Domain.Contract;

namespace PatternIntro.Domain.Behavior.Quacking
{
    public class Squeak : IQuackingBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("Squeak");
        }
    }
}