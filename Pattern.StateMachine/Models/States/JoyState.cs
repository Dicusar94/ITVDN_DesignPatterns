using Pattern.StateMachine.Enums;

namespace Pattern.StateMachine.Models.States;

public class JoyState : BaseState
{
    public JoyState()
    {
        Console.WriteLine($"Father is in {nameof(JoyState)}");
        Joy();
    }

    public override void ChangeState(Father father, Mark mark)
    {
        switch (mark)
        {
            case Mark.Two:
                father.State = new PityState();
                break;
            case Mark.Five:
                father.State = new NeutralState();
                break;
        }
    }

    private static void Joy()
    {
        Console.WriteLine("Is feeling joyful for his son.");
    }
}