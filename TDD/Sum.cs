namespace TDD;

public class Sum : ISimpleExpression
{
    public Sum(ISimpleExpression augend, ISimpleExpression addend)
    {
        this.addend = addend;
        this.augend = augend;
    }
    public ISimpleExpression augend { get; set; }
    public ISimpleExpression addend { get; set; }

    public Money Reduce(Bank bank,CurrencyType to)
    {
        int amount = augend.Reduce(bank,to)._amount + addend.Reduce(bank,to)._amount;
        return new Money(amount, to);
    }

    public ISimpleExpression Plus(ISimpleExpression addend)
    {
        return new Sum(this,addend);
    }

    public ISimpleExpression Times(int multiplier)
    {
        return new Sum(augend.Times(multiplier), addend.Times(multiplier));
    }
}