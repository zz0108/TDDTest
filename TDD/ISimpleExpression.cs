namespace TDD;

public interface ISimpleExpression
{
    Money Reduce(Bank bank,string to);
}