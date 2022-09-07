using Pattern.State.Models.Context;

namespace Pattern.State.Models.States;

public abstract class BaseState
{
    protected Laptop _laptop = null!;

    public void SetState(Laptop laptop)
    {
        _laptop = laptop;
    }
    public abstract void SingIn(string password);
    public abstract void SingOut();
}