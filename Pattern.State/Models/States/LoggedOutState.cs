namespace Pattern.State.Models.States;

public class LoggedOutState : BaseState
{
    public override void SingIn(string password)
    {
        const string pass = "dicusar.dv";
        var isPassword = string.Equals(password, pass);

        var msgWrongPassword = "This is the wrong password";
        var msgLogged = "Password is correct you are logged in";
        var msg = isPassword ? msgLogged : msgWrongPassword;

        Console.WriteLine(msg);
        _laptop.ChangeState(new LoggedInState());
    }

    public override void SingOut()
    {
        Console.WriteLine("You are already logged out!");
    }
}