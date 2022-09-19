namespace Pattern.AbstractFactory.Models.Abstract;

public abstract class AbstractBottle
{
    public abstract void Interact(AbstractWater water);
    public abstract void Interact(AbstractCoverage coverage);
}