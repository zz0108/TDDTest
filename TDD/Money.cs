﻿namespace TDD;

public abstract class Money
{
    protected int amount;

    public abstract Money times(int multiplier);

    public static Money dollar(int amount)
    {
        return new Dollar(amount);
    }
    
    public static Money franc(int amount)
    {
        return new Franc(amount);
    }
    
    public override bool Equals(object obj)
    {
        Money money = (Money)obj;
        return amount == money.amount && GetType().Equals(money.GetType());
    }
}