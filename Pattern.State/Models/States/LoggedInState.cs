using Pattern.State.Models.Context;

namespace Pattern.State.Models.States;

public class LoggedInState : BaseState
{
    public override void SingIn(string password)
    {
        Console.WriteLine("You are already logged in !");
    }

    public override void SingOut()
    {
        Console.WriteLine("Successfully logged out !");
        _laptop.ChangeState(new LoggedOutState());
    }
}