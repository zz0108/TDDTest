namespace TDD;

public abstract class Money
{
    protected int _amount;
    protected string _currency;
    
    public Money(int amount,string currency)
    {
        _amount = amount;
        _currency = currency;
    }


    public abstract Money times(int multiplier);

    public static Money dollar(int amount)
    {
        return new Dollar(amount,"USD");
    }
    
    public static Money franc(int amount)
    {
        return new Franc(amount,"CHF");
    }

    public string Currency()
    {
        return _currency;
    }
    
    public override bool Equals(object obj)
    {
        Money money = (Money)obj;
        return _amount == money._amount && GetType().Equals(money.GetType());
    }
}