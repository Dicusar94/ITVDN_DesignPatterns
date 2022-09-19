using Pattern.AbstractFactory.Models;
using Pattern.AbstractFactory.Models.CocaCola;
using Pattern.AbstractFactory.Models.Pepsi;

namespace Pattern.AbstractFactory;

static class Program
{
    static void Main()
    {
        Client client;
        Console.ReadLine();

        client = new Client(new CocaColaFactory());
        client.Run();

        client = new Client(new PepsiFactory());
        client.Run();
    }
}