namespace DecoratorPattern;

internal static class Program
{
    private static void Main()
    {
        var beverage1 = new Espresso(BeverageSize.Medium);
        Console.WriteLine($"{beverage1.GetDescription()}: {beverage1.Cost()} $");

        Beverage beverage2 = new Decaf(BeverageSize.Large);
        beverage2 = new Mocha(beverage2);
        beverage2 = new Soy(beverage2);
        Console.WriteLine($"{beverage2.GetDescription()}: {beverage2.Cost()} $");
    }
}