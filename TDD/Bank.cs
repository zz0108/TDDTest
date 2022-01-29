namespace TDD;

public class Bank
{
    public Money Reduce(ISimpleExpression source, string to)
    {
        return source.Reduce(to);
    }
}