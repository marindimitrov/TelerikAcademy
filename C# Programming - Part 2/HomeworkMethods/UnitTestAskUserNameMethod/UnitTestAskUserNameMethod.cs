using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class UnitTestAskUserNameMethod
{
    [TestMethod]
    public void TestMethod1()
    {
        string result = AskUserNameMethod.CatchName("Marin");
        Assert.AreEqual("Marin", result);
    }
}
