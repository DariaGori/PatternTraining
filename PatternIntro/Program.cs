using PatternIntro.Domain;
using PatternIntro.Domain.Behavior.Flying;

namespace PatternIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            
            mallard.PerformQuack();
            mallard.PerformFly();
            
            Duck model = new ModelDuck();
            
            // Changing the class behavior at the runtime
            model.PerformFly();
            model.FlyingBehavior = new FlyRocketPowered();
            model.PerformFly();
        }
    }
}