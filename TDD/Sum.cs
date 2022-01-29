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

    public Money Reduce(Bank bank,string to)
    {
        int amount = augend.Reduce(bank,to)._amount + addend.Reduce(bank,to)._amount;
        return new Money(amount, to);
    }

    public ISimpleExpression Plus(ISimpleExpression addend)
    {
        return new Sum(this,addend);
    }
}