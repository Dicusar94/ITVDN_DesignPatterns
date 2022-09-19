using Pattern.AbstractFactory.Models.Abstract;

namespace Pattern.AbstractFactory.Models.Pepsi;

public class PepsiBottle : AbstractBottle
{
    public override void Interact(AbstractWater water)
    {
        Console.WriteLine($"{this} interacts with {water}");
    }

    public override void Interact(AbstractCoverage coverage)
    {
        Console.WriteLine($"{this} interacts with {coverage}");
    }
}