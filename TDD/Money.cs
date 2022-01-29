namespace TDD;

public class Money : ISimpleExpression
{
    public int _amount;
    protected string _currency;
    
    
    public Money(int amount,string currency)
    {
        _amount = amount;
        _currency = currency;
    }

    public Money Reduce(Bank bank,string to)
    {
        int rate = bank.Rate(_currency, to);
        return new Money(_amount / rate,to);
    } 
    public ISimpleExpression Times(int multiplier)
    {
        return new Money(multiplier * _amount,_currency);
    }

    public ISimpleExpression Plus(ISimpleExpression addend)
    {
        return new Sum(this,addend);
    }

    public static Money dollar(int amount)
    {
        return new Money(amount,"USD");
    }
    
    public static Money franc(int amount)
    {
        return new Money(amount,"CHF");
    }

    public string Currency()
    {
        return _currency;
    }
    
    public override bool Equals(object obj)
    {
        Money money = (Money)obj;
        return _amount == money._amount && Currency().Equals(money._currency);
    }
}