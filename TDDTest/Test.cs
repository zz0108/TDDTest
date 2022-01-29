using NUnit.Framework;
using TDD;

namespace TDDTest;

[TestFixture]
public class Tests
{
    [Test]
    public void testMaltiplication()
    {
        Dollar five = new Dollar(5);
        five.times(2);
        Assert.AreEqual(10, five.amount);
    }
}