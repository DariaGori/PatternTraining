namespace DecoratorPattern;

public class Soy : CondimentDecorator
{
    private readonly Beverage _beverage;

    public Soy(Beverage beverage)
    {
        _beverage = beverage;
        Size = beverage.Size;
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", Soy";
    }

    public override double Cost()
    {
        var condimentCost = Size switch
        {
            BeverageSize.Small => 0.15,
            BeverageSize.Medium => 0.3,
            BeverageSize.Large => 0.45,
            _ => throw new ArgumentException("Invalid beverage size provided!")
        };
        
        return _beverage.Cost() + condimentCost;
    }
}