namespace DecoratorPattern;

public class HouseBlend : Beverage
{
    public HouseBlend(BeverageSize size)
    {
        Description = "House blend coffee";
        Size = size;
    }
    public override double Cost()
    {
        return Size switch
        {
            BeverageSize.Small => 0.89,
            BeverageSize.Medium => 1.19,
            BeverageSize.Large => 1.49,
            _ => throw new ArgumentException("Invalid beverage size provided!")
        };
    }
}