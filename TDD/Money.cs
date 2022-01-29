namespace TDD;

public class Money
{
    protected int amount;
    
    public override bool Equals(object obj)
    {
        Money money = (Money)obj;
        return amount == money.amount;
    }
}