using Pattern.StateMachine.Enums;
using Pattern.StateMachine.Interfaces;

namespace Pattern.StateMachine.Models.States;

public abstract class BaseState : IState
{
    public abstract void ChangeState(Father father, Mark mark);

    public void HandlerMark(Father father, Mark mark)
    {
        ChangeState(father, mark);
    }
}