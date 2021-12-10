namespace DecoratorPattern;

public class DarkRoast : Beverage
{
    public DarkRoast(BeverageSize size)
    {
        Description = "Dark roast";
        Size = size;
    }
    
    public override double Cost()
    {
        return Size switch
        {
            BeverageSize.Small => 0.99,
            BeverageSize.Medium => 1.29,
            BeverageSize.Large => 1.59,
            _ => throw new ArgumentException("Invalid beverage size provided!")
        };
    }
}