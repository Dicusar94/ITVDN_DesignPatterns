using Pattern.AbstractFactory.DynamicFactory.Enums;

namespace Pattern.AbstractFactory.DynamicFactory.Interfaces;

public interface IAbstractFactory
{
    dynamic Make(Product product);
}