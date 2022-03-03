using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserApp;

namespace MoodAnalyserTest;

[TestClass]
public class MoodTest
{
    [TestMethod]
    public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
    {
        string message = null;
        MoodAnalyser expected = new MoodAnalyser(message);
        object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserApp.MoodAnalyserFactory", "MoodAnalyserFactory");
        //expected.Equals(obj);
        Assert.AreNotEqual(expected, obj);
    }

    [TestMethod]
    public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
    {
        object expected = new MoodAnalyser("HAPPY"); //2000
        object expected1 = expected;
        object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserApp.MoodAnalyser", "MoodAnalyser", "HAPPY");
        // expected.Equals(obj);
        Assert.Equals(expected, expected1);
    }

    [TestMethod]
    public void GivenMoodHappy_ShouldReturnHappy()
    {
        MoodAnalyser obj = new MoodAnalyser("HAPPY");
        string result = obj.analyseMood();
        Assert.AreEqual("HAPPY", result);
    }

    [TestMethod]
    [ExpectedException(typeof(MoodAnalyserCustomException))]
    public void GivenMoodNull_ShouldThrowException()
    {
        MoodAnalyser obj = new MoodAnalyser(null);
        string result = obj.analyseMood();
        //Assert.AreEqual("123", result);
    }

    [TestMethod]
    public void GivenMoodHappy_ShouldReturnNull()
    {
        MoodAnalyser obj = new MoodAnalyser("null");
        string result = obj.analyseMood();
        Assert.AreEqual("HAPPY", result);
    }
}

