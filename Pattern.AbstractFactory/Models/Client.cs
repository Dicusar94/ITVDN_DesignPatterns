using Pattern.AbstractFactory.Models.Abstract;
using Factory = Pattern.AbstractFactory.Models.Abstract.AbstractFactory;

namespace Pattern.AbstractFactory.Models;

public class Client
{
    private readonly AbstractBottle bottle;
    private readonly AbstractWater water;
    private readonly AbstractCoverage coverage;

    public Client(Factory factory)
    {
        water = factory.CreateWater();
        bottle = factory.CreateBottle();
        coverage = factory.CreateCoverage();
    }

    public void Run()
    {
        bottle.Interact(water);
        bottle.Interact(coverage);
    }
}