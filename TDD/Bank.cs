namespace TDD;

public class Bank
{
    public Money reduce(ISimpleExpression source, string to)
    {
        return source.reduce(to);
    }
}