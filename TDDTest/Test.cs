using NUnit.Framework;

namespace TDDTest;

[TestFixture]
public class Tests
{
    [Test]
    public void Test1()
    {
        Dollar five = new Dollar(5);
        five.times(2);
        Assert.Equals(10, five.amount);
    }
}