using MathOperation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest;

[TestClass]
public class MathOperationTest
{
    private Demo demo = new Demo();

    [TestMethod]
    [DataRow(2, 4, 6)]
    [DataRow(12, 43, 55)]
    [DataRow(2, -4, -2)]
    [DataRow(-2, -4, -6)]
    [DataRow(2, 0, 2)]
    public void TestAdd(int num1, int num2, int expectation)
    {
        var result = demo.Add(num1, num2);
        Assert.AreEqual(expectation, result);
    }
}
