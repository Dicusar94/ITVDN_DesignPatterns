using Pattern.StateMachine.Enums;

namespace Pattern.StateMachine.Models.States;

public class NeutralState : BaseState
{
    public NeutralState()
    {
        Console.WriteLine($"Father is in {nameof(NeutralState)}: ");
        Hope();
    }

    public override void ChangeState(Father father, Mark mark)
    {
        switch (mark)
        {
            case Mark.Two:
                father.State = new PityState();
                break;
            case Mark.Five:
                father.State = new JoyState();
                break;
        }
    }

    public static void Hope()
    {
        Console.WriteLine("Hopes for good marks");
    }
}