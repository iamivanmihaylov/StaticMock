namespace StatickMock;

public class It
{
    public static T IsAny<T>()
    {
        return default;
    }
}