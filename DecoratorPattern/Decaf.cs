namespace DecoratorPattern;

public class Decaf : Beverage
{
    public Decaf(BeverageSize size)
    {
        Description = "Decaf";
        Size = size;
    }
    
    public override double Cost()
    {
        return Size switch
        {
            BeverageSize.Small => 1.05,
            BeverageSize.Medium => 1.35,
            BeverageSize.Large => 1.65,
            _ => throw new ArgumentException("Invalid beverage size provided!")
        };
    }
}