namespace DecoratorPattern;

public class Milk : CondimentDecorator
{
    private readonly Beverage _beverage;

    public Milk(Beverage beverage)
    {
        _beverage = beverage;
        Size = beverage.Size;
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", Milk";
    }

    public override double Cost()
    {
        var condimentCost = Size switch
        {
            BeverageSize.Small => 0.1,
            BeverageSize.Medium => 0.2,
            BeverageSize.Large => 0.3,
            _ => throw new ArgumentException("Invalid beverage size provided!")
        };
        
        return _beverage.Cost() + condimentCost;
    }
}