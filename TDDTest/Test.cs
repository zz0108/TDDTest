using NUnit.Framework;
using TDD;

namespace TDDTest;

[TestFixture]
public class Tests
{
    [Test]
    public void TestMaltiplication()
    {
        Dollar five = new Dollar(5);
        Assert.AreEqual(new Dollar(10), five.times(2));
        Assert.AreEqual(new Dollar(15),five.times(3));
    }

    [Test]
    public void TestEquality()
    {
        Assert.True(new Dollar(5).Equals(new Dollar(5)));
        Assert.False(new Dollar(5).Equals(new Dollar(6)));
    }
}