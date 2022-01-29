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

    public Money reduce(string to)
    {
        int amount = augend._amount + addend._amount;
        return new Money(amount, to);
    }
}