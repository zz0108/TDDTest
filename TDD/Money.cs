namespace TDD;

public class Money
{
    protected int _amount;
    protected string _currency;
    
    public Money(int amount,string currency)
    {
        _amount = amount;
        _currency = currency;
    }


    public Money times(int multiplier)
    {
        return new Money(multiplier * _amount,_currency);
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