using Factory = Pattern.AbstractFactory.Models.Abstract.AbstractFactory;

namespace Pattern.AbstractFactory.Models.Pepsi;

public class PepsiFactory : Factory
{
    public override Abstract.AbstractBottle CreateBottle()
    {
        return new PepsiBottle();
    }

    public override Abstract.AbstractCoverage CreateCoverage()
    {
        return new PepsiCoverage();
    }

    public override Abstract.AbstractWater CreateWater()
    {
        return new PepsiWater();
    }
}