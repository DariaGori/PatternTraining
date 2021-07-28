using System;
using PatternIntro.Domain.Contract;

namespace PatternIntro.Domain.Behavior.Quacking
{
    public class MuteQuack : IQuackingBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("<< No sound >>");
        }
    }
}