namespace DecoratorPattern;

public class Espresso : Beverage
{
    public Espresso(BeverageSize size)
    {
        Description = "Espresso";
        Size = size;
    }
    
    public override double Cost()
    {
        return Size switch
        {
            BeverageSize.Small => 1.99,
            BeverageSize.Medium => 2.29,
            BeverageSize.Large => 2.59,
            _ => throw new ArgumentException("Invalid beverage size provided!")
        };
    }
}