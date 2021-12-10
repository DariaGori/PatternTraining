namespace DecoratorPattern;

public abstract class Beverage
{
    protected string Description = "Unknown beverage";

    public BeverageSize Size { get; set; }

    public virtual string GetDescription()
    {
        return Description;
    }
    
    public abstract double Cost();
}