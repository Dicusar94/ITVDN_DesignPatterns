using Factory = Pattern.AbstractFactory.Models.Abstract.AbstractFactory;

namespace Pattern.AbstractFactory.Models.CocaCola;

public class CocaColaFactory : Factory
{
    public override Abstract.AbstractBottle CreateBottle()
    {
        return new CocaColaBottle();
    }

    public override Abstract.AbstractCoverage CreateCoverage()
    {
        return new CocaColaCoverage();
    }

    public override Abstract.AbstractWater CreateWater()
    {
        return new CocaColaWater();
    }
}