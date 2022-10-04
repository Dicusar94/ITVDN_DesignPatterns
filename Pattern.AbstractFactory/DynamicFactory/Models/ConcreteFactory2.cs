using Pattern.AbstractFactory.DynamicFactory.Enums;
using Pattern.AbstractFactory.DynamicFactory.Interfaces;

namespace Pattern.AbstractFactory.DynamicFactory.Models;

public class ConcreteFactory2 : IAbstractFactory
{
    private dynamic product = null!;

    public dynamic Make(Product product)
    {
        string name = $"{GetType().Namespace}.{product}2";

        this.product = Activator.CreateInstance(Type.GetType(name)!)!;

        return this.product!;
    }
}