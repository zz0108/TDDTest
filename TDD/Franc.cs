namespace TDD;

public class Franc : Money
{
    public Franc(int amount, string currency) : base(amount, currency)
    {
        
    }
    public override Money times(int multiplier)
    {
        return franc(_amount * multiplier);
    }
}