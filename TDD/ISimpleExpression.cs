namespace TDD;

public interface ISimpleExpression
{
    Money Reduce(Bank bank,string to);
    ISimpleExpression Plus(ISimpleExpression addend);
    ISimpleExpression Times(int multiplier);
}