using System.Runtime.CompilerServices;

namespace StaticMock.Sandbox
{
    public class GeneratedCode
    {
        [InterceptsLocation("""C:\Users\Ivan Mihaylov\source\repos\StatickMock\src\StatickMock.Sandbox\Program.cs""", 22, 21)]
        public static void Intercept(int a, int b)
        {
            Console.WriteLine($"I have INTERCEPTED you {a} {b}");
        }
    }
}
