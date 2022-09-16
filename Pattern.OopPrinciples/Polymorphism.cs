using System.Collections.Generic;
using System;
namespace Pattern.OopPrinciples;

public class Polymorphism
{
    public static void Execute() 
    {
        // Example1();
        Example2();
    }

    private static void Example1()
    {
        Example1IterateAList();
        Example1ImplicitPolymorphism();
    }

    private static void Example1IterateAList()
    {
        var shapes = new List<Shape>
        {
            new Rectangle(),
            new Circle()
        };

        foreach (var shape in shapes)
        {
            shape.Draw();
        }
    }

    private static void Example1ImplicitPolymorphism()
    {
        Circle circle = new Circle();
        circle.Draw(); //Calls the draw circle

        Console.WriteLine();

        Shape shape = circle;
        shape.Draw(); //Calls the draw circle
    }

    private static void Example2()
    {
        var a = new List<A>
        {
            new B(),
            new C(),
            new D()
        };

        foreach (var dl in a)
        {
            dl.DoWork();
        }

        D derivedClass = new D();
        derivedClass.DoWork();

        A baseClass = derivedClass;
        baseClass.DoWork();
    }
}

#region Example1
public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Performing base class drawing task");
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
        base.Draw();
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
        base.Draw();
    }
}

#endregion

#region Example2
public class A
{
    public virtual void DoWork() 
    {
        Console.WriteLine($"Do work {nameof(A)}");
    }
}

public class B : A
{
    public override void DoWork()
    {
        Console.WriteLine($"Do work {nameof(B)}");
    }
}

public class C : B
{
    public sealed override void DoWork()
    {
        Console.WriteLine($"Do work {nameof(C)}");
    }
}

public class D : C
{
    public new void DoWork()
    {
        Console.WriteLine($"Do work {nameof(D)}");
    }
}

#endregion