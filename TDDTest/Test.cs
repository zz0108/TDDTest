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
        Dollar product = five.times(2);
        Assert.AreEqual(10, product.amount);
        product = five.times(3);
        Assert.AreEqual(15,product.amount);
    }
}