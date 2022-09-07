using Pattern.StateMachine.Models;

namespace Pattern.StateMachine;

public static class Program
{
    static void Main()
    {
        var father = new Father();

        father.FindOut(Enums.Mark.Two);
        father.FindOut(Enums.Mark.Five);
        father.FindOut(Enums.Mark.Five);
        father.FindOut(Enums.Mark.Five);
    }
}