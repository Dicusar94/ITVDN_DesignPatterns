using Pattern.AbstractFactory.DynamicFactory.Enums;

namespace Pattern.AbstractFactory.DynamicFactory.Models;

public class Client
{
    private readonly dynamic _factory;
    private readonly dynamic _productA;
    private readonly dynamic _productB;

    public Client(Factory factory)
    {
        string name = $"{GetType().Namespace}.{factory}";
        _factory = Activator.CreateInstance(Type.GetType(name)!)!;
        _productA = _factory.Make(Product.ProductA);
        _productB = _factory.Make(Product.ProductB);
    }

    public void Run()
    {
        _productB.Interact(_productA);
    }
}