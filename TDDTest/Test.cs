using System;
using System.Linq.Expressions;
using NUnit.Framework;
using TDD;

namespace TDDTest;

[TestFixture]
public class Tests
{
    [Test]
    public void TestMaltiplication()
    {
        Money five = Money.dollar(5);
        Assert.AreEqual(Money.dollar(10), five.Times(2));
        Assert.AreEqual(Money.dollar(15),five.Times(3));
    }

    [Test]
    public void TestSumPlusMoney()
    {
        ISimpleExpression fiveBucks = Money.dollar(5);
        ISimpleExpression tenFranc = Money.franc(10);
        Bank bank = new Bank();
        bank.AddRate(CurrencyType.CHF,CurrencyType.USD,2);
        ISimpleExpression sum = new Sum(fiveBucks, tenFranc).Plus(fiveBucks);
        Money result = bank.Reduce(sum, CurrencyType.USD);
        Assert.AreEqual(Money.dollar(15),result);
    }

    [Test]
    public void TestSumTimes()
    {
        ISimpleExpression fiveBucks = Money.dollar(5);
        ISimpleExpression tenFranc = Money.franc(10);
        Bank bank = new Bank();
        bank.AddRate(CurrencyType.CHF,CurrencyType.USD,2);
        ISimpleExpression sum = new Sum(fiveBucks, tenFranc).Times(2);
        Money result = bank.Reduce(sum, CurrencyType.USD);
        Assert.AreEqual(Money.dollar(20),result);
    }
    
    [Test]
    public void TestReduceMoneyDifferentCurrency()
    {
        Bank bank = new Bank();
        bank.AddRate(CurrencyType.CHF,CurrencyType.USD,2);
        Money result = bank.Reduce(Money.franc(2), CurrencyType.USD);
        Assert.AreEqual(Money.dollar(1),result);
    }

    [Test]
    public void TestMixedAddition()
    {
        ISimpleExpression fiveBucks = Money.dollar(5);
        ISimpleExpression tenFrancs = Money.franc(10);
        Bank bank = new Bank();
        bank.AddRate(CurrencyType.CHF, CurrencyType.USD, 2);
        Money result = bank.Reduce(fiveBucks.Plus(tenFrancs), CurrencyType.USD);
        Assert.AreEqual(Money.dollar(10),result);
    }
    
    [Test]
    public void TestSimpleAddition()
    {
        Money five = Money.dollar(5);
        ISimpleExpression sum = five.Plus(five);
        Bank bank = new Bank();
        Money reduced = bank.Reduce(sum, CurrencyType.USD);
        Assert.AreEqual(Money.dollar(10),reduced);
    }

    [Test]
    public void TestReduceMoney()
    {
        Bank bank = new Bank();
        Money result = bank.Reduce(Money.dollar(1), CurrencyType.USD);
        Assert.AreEqual(Money.dollar(1),result);
    }
    [Test]
    public void TestReduceSum()
    {
        ISimpleExpression sum = new Sum(Money.dollar(3), Money.dollar(4));
        Bank bank = new Bank();
        Money result = bank.Reduce(sum, CurrencyType.USD);
        Assert.AreEqual(Money.dollar(7),result);
    }

    [Test]
    public void TestPlusReturnsSum()
    {
        Money five = Money.dollar(5);
        ISimpleExpression result = five.Plus(five);
        Sum sum = (Sum)result;
        Assert.AreEqual(five,sum.augend);
        Assert.AreEqual(five,sum.addend);
    }
    [Test]
    public void TestFrancMaltiplication()
    {
        Money five = Money.franc(5);
        Assert.AreEqual(Money.franc(10), five.Times(2));
        Assert.AreEqual(Money.franc(15),five.Times(3));
    }

    [Test]
    public void TestEquality()
    {
        Assert.True(Money.dollar(5).Equals(Money.dollar(5)));
        Assert.False(Money.dollar(5).Equals(Money.dollar(6)));
        Assert.True(Money.franc(5).Equals(Money.franc(5)));
        Assert.False(Money.franc(5).Equals(Money.franc(6)));
        Assert.False(Money.franc(5).Equals(Money.dollar(5)));
    }

    [Test]
    public void TestCurrency()
    {
        Assert.AreEqual(CurrencyType.USD,Money.dollar(1).Currency());
        Assert.AreEqual(CurrencyType.CHF,Money.franc(1).Currency());
    }
}