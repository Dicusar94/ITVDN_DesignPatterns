using Pattern.StateMachine.Enums;
using Pattern.StateMachine.Interfaces;
using Pattern.StateMachine.Models.States;

namespace Pattern.StateMachine.Models;

public class Father
{
    public IState State { get; set; }
    public Father()
    {
        State = new NeutralState();
    }

    public void FindOut(Mark mark)
    {
        State.HandlerMark(this, mark);
    }
}