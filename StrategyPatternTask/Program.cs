using StrategyPatternTask.Domain;
using StrategyPatternTask.Domain.Behavior;

namespace StrategyPatternTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Character queen = new Queen();
            
            queen.Fight();

            Character troll = new Troll();
            
            // Changing the class behavior at the runtime
            troll.Fight();
            troll.WeaponBehavior = new BowAndArrowBehavior();
            troll.Fight();
        }
    }
}