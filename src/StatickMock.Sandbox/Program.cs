using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using StaticMock;

namespace StaticMock.Sandbox;

public partial class Program
{
    [MockStatic]
    private static MockStatic mockableObject =
        MockStatic
        .Mock(() => StaticClass.DoWork(1, 2))
        .ReplaceWith(() =>
        {
            Console.WriteLine("Hello");
        });

    static void Main(string[] args)
    {
        StaticClass.DoWork(1, 2);
    }

    static partial void HelloFrom(string name);


}

public static class StaticClass
{
    public static void DoWork(params int[] numbers)
    {
        Console.WriteLine($"Doing work with numbers: {string.Join(", ", numbers)}");
    }
}


