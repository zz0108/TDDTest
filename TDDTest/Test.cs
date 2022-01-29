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
        Assert.AreEqual(Money.dollar(10), five.times(2));
        Assert.AreEqual(Money.dollar(15),five.times(3));
    }
    
    [Test]
    public void TestFrancMaltiplication()
    {
        Money five = Money.franc(5);
        Assert.AreEqual(Money.franc(10), five.times(2));
        Assert.AreEqual(Money.franc(15),five.times(3));
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
}