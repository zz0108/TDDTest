namespace TDD;

public class Bank
{
    public Money Reduce(ISimpleExpression source, string to)
    {
        return source.Reduce(this,to);
    }

    public int Rate(string from, string to)
    {
        return from.Equals("CHF") && to.Equals("USD") ? 2 : 1;
    }
}