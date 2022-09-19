namespace Pattern.AbstractFactory.Models.Abstract;

public abstract class AbstractFactory
{
    public abstract AbstractWater CreateWater();
    public abstract AbstractBottle CreateBottle();
    public abstract AbstractCoverage CreateCoverage();
}