namespace DecoratorPattern;

public class Mocha : CondimentDecorator
{
    private readonly Beverage _beverage;

    public Mocha(Beverage beverage)
    {
        _beverage = beverage;
        Size = beverage.Size;
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", Mocha";
    }

    public override double Cost()
    {
        var condimentCost = Size switch
        {
            BeverageSize.Small => 0.2,
            BeverageSize.Medium => 0.4,
            BeverageSize.Large => 0.6,
            _ => throw new ArgumentException("Invalid beverage size provided!")
        };
        
        return _beverage.Cost() + condimentCost;
    }
}