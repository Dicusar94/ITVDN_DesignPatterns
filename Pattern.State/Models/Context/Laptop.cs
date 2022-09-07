using Pattern.State.Models.States;

namespace Pattern.State.Models.Context;

public class Laptop
{
    private BaseState _state = null!;
    public Laptop()
    {
        ChangeState(new LoggedOutState());
    }

    public void ChangeState(BaseState state)
    {
        _state = state;
        _state.SetState(this);
    }

    public void SingIn(string password)
    {
        _state.SingIn(password);
    }

    public void SingOut()
    {
        _state.SingOut();
    }
}