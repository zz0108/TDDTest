namespace TDD;

public class Franc : Money
{
    private string currency;
    public Franc(int amount)
    {
        this.amount = amount;
        currency = "CHF";
    }

    public override Money times(int multiplier)
    {
        return new Franc(amount * multiplier);
    }

    public override string Currency()
    {
        return currency;
    }
}