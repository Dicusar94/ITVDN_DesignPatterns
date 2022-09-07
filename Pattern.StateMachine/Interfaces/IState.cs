using Pattern.StateMachine.Enums;
using Pattern.StateMachine.Models;

namespace Pattern.StateMachine.Interfaces;

public interface IState
{
    void HandlerMark(Father father, Mark mark);
    void ChangeState(Father father, Mark mark);
}