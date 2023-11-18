using System.Linq.Expressions;

namespace StaticMock;
public class MockStatic
{

    public MockStatic(Expression action)
    {
    }

    public static MockStatic Mock(Expression expression)
    {
        return new MockStatic(expression);
    }

    public MockStatic ReplaceWith(Action action)
    {
        return this;
    }

    public MockStatic Returns(int a)
    {
        return this;
    }
}