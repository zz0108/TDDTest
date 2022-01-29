namespace TDD;

public class Bank
{
    public Money reduce(ISimpleExpression source, string to)
    {
        if (typeof(Money).IsInstanceOfType(source)) return (Money)source;
        Sum sum = (Sum)source;
        return sum.reduce(to);
    }
}