namespace TDD;

public class Dollar : Money
{
    public int amount;
    
    public Dollar(int amount)
    {
        this.amount = amount;
    }

    public Dollar times(int multiplier)
    {
        return new Dollar(amount * multiplier);
    }

    public override bool Equals(object obj)
    {
        Dollar dollar = (Dollar)obj;
        return amount == dollar.amount;
    }
}