using Pattern.StateMachine.Enums;

namespace Pattern.StateMachine.Models.States;

public class PityState : BaseState
{
    public PityState()
    {
        Console.WriteLine($"Father is in ${nameof(PityState)}");
        Calm();
    }

    public override void ChangeState(Father father, Mark mark)
    {
        switch (mark)
        {
            case Mark.Two:
                father.State = new NeutralState();
                break;
            case Mark.Five:
                father.State = new JoyState();
                break;
        }
    }

    private static void Calm()
    {
        Console.WriteLine("Father calming down the son");
    }
}