using Pattern.StateMachine.Enums;
using Pattern.StateMachine.Interfaces;

namespace Pattern.StateMachine.Models.States;

public class BaseState : IState
{
    public virtual void ChangeState(Father father, Mark mark)
    {
    }

    public void HandlerMark(Father father, Mark mark)
    {
        ChangeState(father, mark);
    }
}