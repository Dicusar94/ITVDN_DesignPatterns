using Pattern.AbstractFactory.DynamicFactory.Interfaces;

namespace Pattern.AbstractFactory.DynamicFactory.Models;

public class ProductB2 : IAbstractProductB
{
    public void Interact(IAbstractProductA a)
    {
        string msg = $"{this.GetType().Name} interacts with {a.GetType().Name}";
        Console.WriteLine(msg);
    }
}
