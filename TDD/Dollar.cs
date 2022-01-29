namespace TDD;

public class Dollar : Money
{
    private string currency;
    public Dollar(int amount)
    {
        this.amount = amount;
        currency = "USD";
    }

    public override Money times(int multiplier)
    {
        return new Dollar(amount * multiplier);
    }

    public override string Currency()
    {
        return currency;
    }
}