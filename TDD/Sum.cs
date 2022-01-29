namespace TDD;

public class Sum : ISimpleExpression
{
    public Sum(Money augend, Money addend)
    {
        this.addend = addend;
        this.augend = augend;
    }
    public Money augend { get; set; }
    public Money addend { get; set; }

    public Money Reduce(Bank bank,string to)
    {
        int amount = augend.Reduce(bank,to)._amount + addend.Reduce(bank,to)._amount;
        return new Money(amount, to);
    }
}