namespace TDD;

public class Dollar : Money
{
    public Dollar(int amount, string currency) : base(amount, currency)
    {
        
    }

    public override Money times(int multiplier)
    {
        return dollar(_amount * multiplier);
    }
}