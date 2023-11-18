using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using StaticMock;

namespace StaticMock.Sandbox;

public class Program
{
    static void Main(string[] args)
    {

        //var result1 = new MockStatic(
        //    () => StaticClass.DoWork(It.IsAny<int>(), It.IsAny<int>()))
        //    .ReplaceWith((string a, string b) =>
        //    {
        //        Console.WriteLine($"The numbers you have put in are: {a} and {b}!");
        //    })
        //    .Compile();


        StaticClass.DoWork(1, 2);

    }
}



