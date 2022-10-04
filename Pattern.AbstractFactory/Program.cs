using Pattern.AbstractFactory.DynamicFactory.Enums;
using Pattern.AbstractFactory.Models;
using Pattern.AbstractFactory.Models.CocaCola;
using Pattern.AbstractFactory.Models.Pepsi;
using DynamicClient = Pattern.AbstractFactory.DynamicFactory.Models.Client;

namespace Pattern.AbstractFactory;

static class Program
{
    static void Main()
    {
        Console.ReadLine();
        Example2();
    }

    private static void Example1()
    {
        Client client;
        Console.ReadLine();

        client = new Client(new CocaColaFactory());
        client.Run();

        client = new Client(new PepsiFactory());
        client.Run();
    }

    private static void Example2()
    {
        DynamicClient client = new(Factory.ConcreteFactory1);
        client.Run();
    }
}