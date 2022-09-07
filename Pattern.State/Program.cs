using Pattern.State.Models.Context;
using Pattern.State.Models.States;

namespace Pattern.State;

public static class Program
{
    static void Main()
    {
        var laptop = new Laptop();
        laptop.SingIn("dicusar.dv");
        laptop.SingIn("adsfasdfasdf");
        laptop.SingOut();
        laptop.SingOut();
        laptop.SingIn("xxx");
    }
}