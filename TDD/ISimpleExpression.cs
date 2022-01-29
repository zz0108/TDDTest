namespace TDD;

public interface ISimpleExpression
{
    Money Reduce(Bank bank,CurrencyType to);
    ISimpleExpression Plus(ISimpleExpression addend);
    ISimpleExpression Times(int multiplier);
}