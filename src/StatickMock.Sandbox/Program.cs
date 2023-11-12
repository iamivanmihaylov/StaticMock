using System;
using System.Linq.Expressions;
using System.Reflection.Emit;
using StatickMock;

namespace StatickMock.Sandbox;

public class Program
{
    static void Main(string[] args)
    {
        var result1 = new MockStatic(
            () => StaticClass.DoWork(It.IsAny<int>(), It.IsAny<int>()))
            .ReplaceWith((string a, string b) =>
            {
            Console.WriteLine($"The numbers you have put in are: {a} and {b}!");
            })
            .Compile();


        var result2 = new MockStatic(
            () => StaticClass.Calculate(It.IsAny<int>(), It.IsAny<int>()))
            .ReplaceWith((int a, int b) =>
            {
                return a - b;
            }).Compile();

        StaticClass.DoWork(1, 2);
    }
}




